namespace KeyboardMaster
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.gpActivationSequence = new System.Windows.Forms.GroupBox();
            this.pnComboKey = new System.Windows.Forms.Panel();
            this.hotKeyCtrl = new exscape.HotkeyControl();
            this.label4 = new System.Windows.Forms.Label();
            this.pnSequenceKeys = new System.Windows.Forms.Panel();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActivationSequence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbActivationMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpActionItems = new System.Windows.Forms.GroupBox();
            this.tbItems = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colApplication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArguments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btRemove = new System.Windows.Forms.ToolStripButton();
            this.btMoveUp = new System.Windows.Forms.ToolStripButton();
            this.btMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.gpActivationSequence.SuspendLayout();
            this.pnComboKey.SuspendLayout();
            this.pnSequenceKeys.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpActionItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbItems)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 41);
            this.panel1.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(626, 8);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(545, 8);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // gpActivationSequence
            // 
            this.gpActivationSequence.Controls.Add(this.pnComboKey);
            this.gpActivationSequence.Controls.Add(this.pnSequenceKeys);
            this.gpActivationSequence.Controls.Add(this.panel3);
            this.gpActivationSequence.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpActivationSequence.Location = new System.Drawing.Point(3, 3);
            this.gpActivationSequence.Name = "gpActivationSequence";
            this.gpActivationSequence.Size = new System.Drawing.Size(708, 51);
            this.gpActivationSequence.TabIndex = 1;
            this.gpActivationSequence.TabStop = false;
            this.gpActivationSequence.Text = "Activation Sequence";
            // 
            // pnComboKey
            // 
            this.pnComboKey.Controls.Add(this.hotKeyCtrl);
            this.pnComboKey.Controls.Add(this.label4);
            this.pnComboKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnComboKey.Location = new System.Drawing.Point(480, 16);
            this.pnComboKey.Name = "pnComboKey";
            this.pnComboKey.Padding = new System.Windows.Forms.Padding(5);
            this.pnComboKey.Size = new System.Drawing.Size(218, 32);
            this.pnComboKey.TabIndex = 6;
            // 
            // hotKeyCtrl
            // 
            this.hotKeyCtrl.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotKeyCtrl.Hotkey = System.Windows.Forms.Keys.None;
            this.hotKeyCtrl.HotkeyModifiers = System.Windows.Forms.Keys.None;
            this.hotKeyCtrl.Location = new System.Drawing.Point(66, 5);
            this.hotKeyCtrl.Name = "hotKeyCtrl";
            this.hotKeyCtrl.Size = new System.Drawing.Size(135, 20);
            this.hotKeyCtrl.TabIndex = 0;
            this.hotKeyCtrl.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Combo Key";
            // 
            // pnSequenceKeys
            // 
            this.pnSequenceKeys.Controls.Add(this.txtTimeout);
            this.pnSequenceKeys.Controls.Add(this.label2);
            this.pnSequenceKeys.Controls.Add(this.txtActivationSequence);
            this.pnSequenceKeys.Controls.Add(this.label1);
            this.pnSequenceKeys.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSequenceKeys.Location = new System.Drawing.Point(160, 16);
            this.pnSequenceKeys.Name = "pnSequenceKeys";
            this.pnSequenceKeys.Padding = new System.Windows.Forms.Padding(5);
            this.pnSequenceKeys.Size = new System.Drawing.Size(320, 32);
            this.pnSequenceKeys.TabIndex = 4;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTimeout.Location = new System.Drawing.Point(228, 5);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(80, 20);
            this.txtTimeout.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(152, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "   Timeout (ms)";
            // 
            // txtActivationSequence
            // 
            this.txtActivationSequence.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtActivationSequence.Location = new System.Drawing.Point(61, 5);
            this.txtActivationSequence.Name = "txtActivationSequence";
            this.txtActivationSequence.Size = new System.Drawing.Size(91, 20);
            this.txtActivationSequence.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sequence";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbActivationMode);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(157, 32);
            this.panel3.TabIndex = 5;
            // 
            // cbActivationMode
            // 
            this.cbActivationMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbActivationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivationMode.FormattingEnabled = true;
            this.cbActivationMode.Location = new System.Drawing.Point(39, 5);
            this.cbActivationMode.Name = "cbActivationMode";
            this.cbActivationMode.Size = new System.Drawing.Size(110, 21);
            this.cbActivationMode.TabIndex = 1;
            this.cbActivationMode.SelectedIndexChanged += new System.EventHandler(this.cbActivationMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mode";
            // 
            // gpActionItems
            // 
            this.gpActionItems.Controls.Add(this.tbItems);
            this.gpActionItems.Controls.Add(this.toolStrip1);
            this.gpActionItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpActionItems.Location = new System.Drawing.Point(3, 54);
            this.gpActionItems.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gpActionItems.Name = "gpActionItems";
            this.gpActionItems.Padding = new System.Windows.Forms.Padding(10);
            this.gpActionItems.Size = new System.Drawing.Size(708, 340);
            this.gpActionItems.TabIndex = 2;
            this.gpActionItems.TabStop = false;
            this.gpActionItems.Text = "Action Items";
            // 
            // tbItems
            // 
            this.tbItems.AllowUserToAddRows = false;
            this.tbItems.AllowUserToDeleteRows = false;
            this.tbItems.AllowUserToResizeColumns = false;
            this.tbItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colName,
            this.colType,
            this.colApplication,
            this.colArguments});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbItems.Location = new System.Drawing.Point(10, 48);
            this.tbItems.MultiSelect = false;
            this.tbItems.Name = "tbItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbItems.RowHeadersVisible = false;
            this.tbItems.RowTemplate.DefaultCellStyle.Format = "F4";
            this.tbItems.RowTemplate.DefaultCellStyle.NullValue = null;
            this.tbItems.RowTemplate.Height = 18;
            this.tbItems.Size = new System.Drawing.Size(688, 282);
            this.tbItems.TabIndex = 4;
            this.tbItems.SelectionChanged += new System.EventHandler(this.tbItems_SelectionChanged);
            // 
            // colKey
            // 
            this.colKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            this.colKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colKey.Width = 40;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 164;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 164;
            // 
            // colApplication
            // 
            this.colApplication.HeaderText = "Application";
            this.colApplication.Name = "colApplication";
            this.colApplication.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colArguments
            // 
            this.colArguments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArguments.HeaderText = "Arguments";
            this.colArguments.Name = "colArguments";
            this.colArguments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btRemove,
            this.btMoveUp,
            this.btMoveDown});
            this.toolStrip1.Location = new System.Drawing.Point(10, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdd
            // 
            this.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAdd.Image = global::KeyboardMaster.Properties.Resources.Add;
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 22);
            this.btAdd.Text = "toolStripButton1";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRemove.Image = global::KeyboardMaster.Properties.Resources.Remove;
            this.btRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(23, 22);
            this.btRemove.Text = "toolStripButton5";
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btMoveUp
            // 
            this.btMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btMoveUp.Image = global::KeyboardMaster.Properties.Resources.MoveUp;
            this.btMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(23, 22);
            this.btMoveUp.Text = "toolStripButton6";
            this.btMoveUp.Click += new System.EventHandler(this.btMoveUp_Click);
            // 
            // btMoveDown
            // 
            this.btMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btMoveDown.Image = global::KeyboardMaster.Properties.Resources.MoveDown;
            this.btMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(23, 22);
            this.btMoveDown.Text = "toolStripButton7";
            this.btMoveDown.Click += new System.EventHandler(this.btMoveDown_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // Settings
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(714, 438);
            this.Controls.Add(this.gpActionItems);
            this.Controls.Add(this.gpActivationSequence);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.gpActivationSequence.ResumeLayout(false);
            this.pnComboKey.ResumeLayout(false);
            this.pnComboKey.PerformLayout();
            this.pnSequenceKeys.ResumeLayout(false);
            this.pnSequenceKeys.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gpActionItems.ResumeLayout(false);
            this.gpActionItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbItems)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.GroupBox gpActivationSequence;
        private System.Windows.Forms.TextBox txtActivationSequence;
        private System.Windows.Forms.GroupBox gpActionItems;
        internal System.Windows.Forms.DataGridView tbItems;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btRemove;
        private System.Windows.Forms.ToolStripButton btMoveUp;
        private System.Windows.Forms.ToolStripButton btMoveDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArguments;
        private System.Windows.Forms.Panel pnSequenceKeys;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbActivationMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnComboKey;
        private exscape.HotkeyControl hotKeyCtrl;
        private System.Windows.Forms.Label label4;
    }
}