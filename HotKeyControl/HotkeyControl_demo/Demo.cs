using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotkeyControl_demo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void btnCopyDown_Click(object sender, EventArgs e)
        {
            this.hkControl2.Hotkey = this.hkControl1.Hotkey;
            this.hkControl2.HotkeyModifiers = this.hkControl1.HotkeyModifiers;
        }

        private void btnCopyUp_Click(object sender, EventArgs e)
        {
            this.hkControl1.Hotkey = this.hkControl2.Hotkey;
            this.hkControl1.HotkeyModifiers = this.hkControl2.HotkeyModifiers;
        }
    }
}