using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardMaster
{
    enum KeyManagerActionType { StartProgram, ShutDown, Restart };
    enum KeyManagerActivationSequenceType { Sequence, ComboKey };
    
    internal class KeyManagerData
    {
        public string ConfigFile { get; private set; }

        public KeyManagerActivationSequenceType ActivationType { get; set; }
        public string ActivationSequence { get; set; } //Sequence Mode
        public Keys Modifier { get; set; }  //ComboKey Mode
        public Keys ActivationKey { get; set; } //ComboKey Mode

        public int SequenceTimeout { get; set; }
        public List<KeyManagerItem> Items { get; set; }

        public KeyManagerData(string configFile) { 
            Items = new List<KeyManagerItem>();
            ActivationType = KeyManagerActivationSequenceType.Sequence;
            ConfigFile = configFile;
        }

        public void LoadConfig(string configFile)
        {
            ConfigFile = configFile;
            Items.Clear();
            using (KeyManagerDataSet DConfig = new KeyManagerDataSet())
            {
                DConfig.ReadXml(configFile);
                if (DConfig.KeyManager.Count == 0) throw new FormatException("Invalid configuration file: " + configFile);
                KeyManagerDataSet.KeyManagerRow ptrDev = DConfig.KeyManager[0];
                ActivationSequence = ptrDev.ActivationSequence;
                SequenceTimeout = ptrDev.SequenceTimeout;
                ActivationType = (KeyManagerActivationSequenceType) Enum.Parse(typeof(KeyManagerActivationSequenceType), ptrDev.ActivationType);
                Modifier = (Keys)ptrDev.ComboKeyModifiers;
                ActivationKey = (Keys)ptrDev.ComboKey;

                foreach (KeyManagerDataSet.KeyManagerItemRow ptrItem in ptrDev.GetKeyManagerItemRows())
                {
                    KeyManagerItem tItem = new KeyManagerItem();
                    tItem.Name = ptrItem.Name;
                    tItem.Application = ptrItem.Application;
                    tItem.Argument = ptrItem.Arguments;
                    tItem.ActionType = (KeyManagerActionType)Enum.Parse(typeof(KeyManagerActionType), ptrItem.ActionType);
                    tItem.HotKey = ptrItem.HotKey;
                    Items.Add(tItem);
                }
            }
        }

        public void LoadDefaultConfig()
        {
            Items.Clear();
            ActivationType = KeyManagerActivationSequenceType.Sequence;
            ActivationSequence = "+5";
            SequenceTimeout = 5000;

            Items.Add(new KeyManagerItem()
                {
                    Name = "ShutDown",
                    ActionType = KeyManagerActionType.ShutDown,
                    HotKey = '1'
                });

            Items.Add(new KeyManagerItem()
                {
                    Name = "Restart",
                    ActionType = KeyManagerActionType.Restart,
                    HotKey = '2'
                });

            Items.Add(new KeyManagerItem()
                {
                    Name = "Notepad",
                    ActionType = KeyManagerActionType.StartProgram,
                    Application = "Notepad.exe",
                    Argument = "",
                    HotKey = '3'
                });
        }

        public void Save() { Save(ConfigFile); }

        public void Save(string filePath)
        {
            using (KeyManagerDataSet DConfig = new KeyManagerDataSet())
            {
                KeyManagerDataSet.KeyManagerRow ptrDev = DConfig.KeyManager.NewKeyManagerRow();
                ptrDev.ID = 0;
                ptrDev.ActivationSequence = ActivationSequence;
                ptrDev.SequenceTimeout = SequenceTimeout;
                ptrDev.ActivationType = ActivationType.ToString();
                ptrDev.ComboKeyModifiers = (int)Modifier;
                ptrDev.ComboKey = (int)ActivationKey;
                DConfig.KeyManager.AddKeyManagerRow(ptrDev);

                int tID = 0;
                foreach (KeyManagerItem ptrItem in Items)
                {
                    KeyManagerDataSet.KeyManagerItemRow tItem = DConfig.KeyManagerItem.NewKeyManagerItemRow();
                    tItem.ID = tID++;
                    tItem.ParentKey = ptrDev.ID;
                    tItem.Name = ptrItem.Name;
                    tItem.Application = ptrItem.Application;
                    tItem.Arguments = ptrItem.Argument;
                    tItem.ActionType = ptrItem.ActionType.ToString();
                    tItem.HotKey = ptrItem.HotKey;
                    DConfig.KeyManagerItem.AddKeyManagerItemRow(tItem);
                }
                DConfig.WriteXml(filePath);
            }
        }
    }

    internal class KeyManagerItem
    {
        public string Name { get; set; }
        public string Application { get; set; }
        public string Argument { get; set; }
        public KeyManagerActionType ActionType { get; set; }
        public char HotKey { get; set; }
        public object BindedControl { get; set; }
    }

}
