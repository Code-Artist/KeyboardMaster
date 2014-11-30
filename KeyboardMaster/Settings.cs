using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class Settings : Form
    {
        private KeyManagerData keyManager;
        public Settings()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn tbComboBox = (DataGridViewComboBoxColumn)tbItems.Columns[2];
            tbComboBox.Items.Clear();
            tbComboBox.Items.AddRange(Enum.GetNames(typeof(KeyManagerActionType)));
            cbActivationMode.Items.AddRange(Enum.GetNames(typeof(KeyManagerActivationSequenceType)));
            UpdateActivationSequenceMode();
        }

        internal DialogResult ShowDialog(KeyManagerData sender)
        {
            keyManager = sender;
            return ShowDialog();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            cbActivationMode.SelectedIndex = (int)keyManager.ActivationType;
            txtActivationSequence.Text = keyManager.ActivationSequence;
            txtTimeout.Text = keyManager.SequenceTimeout.ToString();
            hotKeyCtrl.HotkeyModifiers = keyManager.Modifier;
            hotKeyCtrl.Hotkey = keyManager.ActivationKey;

            tbItems.Rows.Clear();
            tbItems.Rows.Add(keyManager.Items.Count);
            for (int x = 0; x < keyManager.Items.Count; x++)
            {
                KeyManagerItem ptrItem = keyManager.Items[x];
                DataGridViewRow ptrRow = tbItems.Rows[x];

                ptrRow.Cells[0].Value = ptrItem.HotKey;
                ptrRow.Cells[1].Value = ptrItem.Name;
                ptrRow.Cells[2].Value = ptrItem.ActionType.ToString();
                ptrRow.Cells[3].Value = ptrItem.Application;
                ptrRow.Cells[4].Value = ptrItem.Argument;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            PopulateItems();
            if (ValidateConfiguration())
            {
                UpdateSettings();
                keyManager.Save();
                return;
            }
            else
                DialogResult = DialogResult.None;
        }

        private string GetCellValue(DataGridViewCell sender)
        {
            return (sender.Value == null) ? string.Empty : sender.Value.ToString();
        }

        List<KeyManagerItem> ActionItems;
        private void PopulateItems()
        {
            ActionItems = new List<KeyManagerItem>();
            foreach (DataGridViewRow ptrRow in tbItems.Rows)
            {
                KeyManagerItem tItem = new KeyManagerItem();
                string tHotKey = GetCellValue(ptrRow.Cells[0]);
                tItem.HotKey = string.IsNullOrEmpty(tHotKey) ? (char)0x00 : tHotKey[0];
                tItem.Name = GetCellValue(ptrRow.Cells[1]);
                tItem.ActionType = (KeyManagerActionType)Enum.Parse(typeof(KeyManagerActionType),
                                        ptrRow.Cells[2].Value.ToString());
                tItem.Application = GetCellValue(ptrRow.Cells[3]);
                tItem.Argument = GetCellValue(ptrRow.Cells[4]);
                ActionItems.Add(tItem);
            }
        }

        private bool ValidateConfiguration()
        {
            for (int x = 0; x < ActionItems.Count; x++)
            {
                KeyManagerItem ptrItem = ActionItems[x];
                if (string.IsNullOrEmpty(ptrItem.Name))
                {
                    MessageBox.Show("Row " + x.ToString() + ": Name cannot be empty!", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (ptrItem.ActionType == KeyManagerActionType.StartProgram)
                {
                    if (string.IsNullOrEmpty(ptrItem.Application))
                    {
                        MessageBox.Show("Row " + x.ToString() + ": Target application not defined!", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void UpdateSettings()
        {
            switch (cbActivationMode.SelectedIndex)
            {
                case 0:
                    keyManager.ActivationType = KeyManagerActivationSequenceType.Sequence;
                    keyManager.ActivationSequence = txtActivationSequence.Text;
                    keyManager.SequenceTimeout = Convert.ToInt32(txtTimeout.Text);
                    break;

                case 1:
                    keyManager.ActivationType = KeyManagerActivationSequenceType.ComboKey;
                    keyManager.Modifier = hotKeyCtrl.HotkeyModifiers;
                    keyManager.ActivationKey = hotKeyCtrl.Hotkey;
                    break;
            }

            keyManager.Items.Clear();
            keyManager.Items.AddRange(ActionItems);
        }

        private void TableSelectedCellChanged()
        {
            if (tbItems.SelectedCells.Count == 0)
            {
                btRemove.Enabled = false;
                btMoveUp.Enabled = false;
                btMoveDown.Enabled = false;
            }
            else
            {
                btRemove.Enabled = true;
                if (tbItems.SelectedCells[0].RowIndex == 0)
                {
                    //First row selected
                    btMoveDown.Enabled = true;
                    btMoveUp.Enabled = false;
                }
                else if (tbItems.SelectedCells[0].RowIndex == (tbItems.Rows.Count - 1))
                {
                    //Last row selected
                    btMoveDown.Enabled = false;
                    btMoveUp.Enabled = true;
                }
                else
                {
                    //Intermediate row
                    btMoveDown.Enabled = true;
                    btMoveUp.Enabled = true;
                }
            }
        }

        private void tbItems_SelectionChanged(object sender, EventArgs e)
        {
            TableSelectedCellChanged();
        }

        #region [ Buttton Control ]

        private void btAdd_Click(object sender, EventArgs e)
        {
            tbItems.Rows.Add(1);
            tbItems.CurrentCell = tbItems.Rows[tbItems.Rows.Count - 1].Cells[0];
            tbItems.BeginEdit(true);
            tbItems.Rows[tbItems.CurrentCell.RowIndex].Cells[2].Value = "StartProgram";
        }

        #endregion

        private void btRemove_Click(object sender, EventArgs e)
        {
            tbItems.Rows.Remove(tbItems.Rows[tbItems.CurrentCell.RowIndex]);
            TableSelectedCellChanged();
        }

        private void TableMoveCurrentRow(int newRowIndex)
        {
            int currentIndex = tbItems.CurrentCell.RowIndex;
            DataGridViewRow ptrRow = tbItems.Rows[tbItems.CurrentCell.RowIndex];
            tbItems.Rows.Remove(ptrRow);
            tbItems.Rows.Insert(newRowIndex, ptrRow);
            tbItems.CurrentCell = tbItems.Rows[newRowIndex].Cells[tbItems.CurrentCell.ColumnIndex];
        }

        private void btMoveUp_Click(object sender, EventArgs e)
        {
            TableMoveCurrentRow(tbItems.CurrentCell.RowIndex - 1);
        }

        private void btMoveDown_Click(object sender, EventArgs e)
        {
            TableMoveCurrentRow(tbItems.CurrentCell.RowIndex + 1);
        }

        private void cbActivationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateActivationSequenceMode();
        }

        private void UpdateActivationSequenceMode()
        {
            switch (cbActivationMode.SelectedIndex)
            {
                case 0: //KeyManagerActivationSequenceType.Sequence
                    pnSequenceKeys.Visible = true;
                    pnComboKey.Visible = false;
                    break;

                case 1: //KeyManagerActivationSequenceType.ComboKey
                    pnSequenceKeys.Visible = false;
                    pnComboKey.Visible = true;
                    break;
            }
        }

    }
}
