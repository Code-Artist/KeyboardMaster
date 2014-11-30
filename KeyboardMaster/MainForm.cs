using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using System.Diagnostics;
using System.IO;

namespace KeyboardMaster
{
    public partial class MainForm : Form
    {
        private KeyboardHookListener keyboardHook;
        private string ConfigFile = "KeyboardMasterConfig.xml";
        private KeyManagerData KbManager;
        private Button refButton;
        private bool StartMonitoring = false;

        public bool Armed { get; set; }
        private DateTime FirstKey;
        private bool InSequence;
        private int keyIndex;
        private Keys ModifierKeysPressed;

        public MainForm()
        {
            InitializeComponent();

            Text += " - Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            KbManager = new KeyManagerData(ConfigFile);

            keyboardHook = new KeyboardHookListener(new GlobalHooker());
            keyboardHook.KeyPress += new KeyPressEventHandler(keyboardHook_KeyPress);
            keyboardHook.KeyDown += new KeyEventHandler(keyboardHook_KeyDown);
            keyboardHook.KeyUp += new KeyEventHandler(keyboardHook_KeyUp);
            keyboardHook.Enabled = true;

            //Get properties from btRef
            refButton = new Button();
            refButton.Width = btRef.Width;
            refButton.Height = btRef.Height;

            //Default Settings - Debug
            KbManager.LoadDefaultConfig();
            Armed = true;
            keyIndex = 0;
        }

        #region [ Keyboard Hook Events ]

        private void UpdateModifierKeyStatus(KeyEventArgs e)
        {
            ModifierKeysPressed = e.Modifiers;
        }

        void keyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateModifierKeyStatus(e);
        }

        void keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateModifierKeyStatus(e);
            if (e.KeyCode == Keys.Escape)
            {
                Trace.WriteLine("ESC key pressed.");
                StartMonitor(); return;
            }

            if (!Armed || !StartMonitoring) return;
            if (KbManager.ActivationType == KeyManagerActivationSequenceType.ComboKey)
            {
                if (KbManager.Modifier == ModifierKeysPressed)
                {
                    if (KbManager.ActivationKey == e.KeyCode)
                    {
                        StopMonitor();
                        Trace.WriteLine("Combo keys matched.");
                    }
                }
            }
        }

        void keyboardHook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Armed || !StartMonitoring) return;
            if (KbManager.ActivationType != KeyManagerActivationSequenceType.Sequence) return;

            if (KbManager.ActivationSequence.Length == 0) return;
            Trace.WriteLine("Processing keys...");

            //Time out detection
            if (InSequence)
            {
                if ((DateTime.Now - FirstKey).TotalMilliseconds > KbManager.SequenceTimeout)
                {
                    //Time out - Restart sequence;
                    keyIndex = 0;
                    InSequence = false;
                    Trace.WriteLine("Time out...");
                }
            }


            //Key capture sequence
            if (keyIndex == 0)
            {
                keyIndex = 0;
                if (e.KeyChar == KbManager.ActivationSequence[keyIndex])
                {
                    //First key matched
                    Trace.WriteLine("Matched key index " + keyIndex.ToString());
                    keyIndex++;
                    InSequence = true;
                    FirstKey = DateTime.Now;
                }
            }
            else
            {
                if (e.KeyChar == KbManager.ActivationSequence[keyIndex])
                {
                    Trace.WriteLine("Matched key index " + keyIndex.ToString());
                    keyIndex++;
                    if (keyIndex == KbManager.ActivationSequence.Length)
                    {
                        //All keys matched, show application form.
                        StopMonitor();
                        Trace.WriteLine("All matched.");
                        keyIndex = 0; InSequence = false;

                    }
                }
                else
                {
                    keyIndex = 0; InSequence = false;
                }
            }
        }

        #endregion

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (AppClosing == true) return;
            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (AppClosing == true) return;
            StartMonitor();
        }

        private void StartMonitor()
        {
            if (!Armed) return;
            if (StartMonitoring) return;
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
            //keyboardHook.Enabled = true;
            StartMonitoring = true;
            Trace.WriteLine("Key capture enabled.");
        }

        private void StopMonitor()
        {
            if(!StartMonitoring) return;
            //================================================
            //IMPORTANT: 
            // Do not change sequence for the following 3 lines
            // Will cause StackOverflow exception.
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.Activate();
            //================================================

            //keyboardHook.Enabled = false;
            StartMonitoring = false;
            Trace.WriteLine("Key capture disabled.");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(ConfigFile)) KbManager.LoadConfig(ConfigFile);
            else
            {
                KbManager.LoadDefaultConfig();
                KbManager.Save(ConfigFile);
            }
            UpdatePanels();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Armed) StartMonitor();
        }

        private bool AppClosing = false;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppClosing = true;
        }

        private void UpdatePanels()
        {
            layoutPanel.Controls.Clear();

            foreach (KeyManagerItem ptrItem in KbManager.Items)
            {
                Button tButton = new Button();
                layoutPanel.Controls.Add(tButton);
                if (ptrItem.HotKey != (char)0x00)
                    tButton.Text = "&" + ptrItem.HotKey + " - " + ptrItem.Name;
                else
                    tButton.Text = ptrItem.Name;
                tButton.UseMnemonic = true;
                tButton.Parent = layoutPanel;
                tButton.Height = refButton.Height;
                tButton.Width = refButton.Width;
                tButton.Click += new EventHandler(tButton_Click);
                ptrItem.BindedControl = tButton;

            }
        }

        private void tButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine(((Button)sender).Text + " clicked.");
            KeyManagerItem ptrItem = KbManager.Items.Find(item => item.BindedControl == sender);
            ProcessAction(ptrItem);
        }

        private void ProcessAction(KeyManagerItem item)
        {
            switch (item.ActionType)
            {
                case KeyManagerActionType.StartProgram:
                    Process.Start(item.Application, item.Argument);
                    break;

                case KeyManagerActionType.ShutDown:
                    //Process.Start("shutdown", "/s /t 10");
                    break;

                case KeyManagerActionType.Restart:
                    //Process.Start("shutdown", "/r /t 10");
                    break;
            }

            StartMonitor();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Settings dialog = new Settings())
                {
                    Armed = false;
                    Trace.WriteLine("Showing Configuration Form...");
                    DialogResult result = dialog.ShowDialog(KbManager);
                    Trace.WriteLine("Configuration form closed.");
                    if (result == DialogResult.OK) UpdatePanels();
                }
            }
            finally { Armed = true; }
        }

        #region [ Tray Menu ]

        private void trayRestore_Click(object sender, EventArgs e)
        {
            StopMonitor();
        }

        private void trayExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}
