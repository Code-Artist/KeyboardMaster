namespace HotkeyControl_demo
{
    partial class Demo
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
            this.hkControl1 = new exscape.HotkeyControl();
            this.hkControl2 = new exscape.HotkeyControl();
            this.btnCopyDown = new System.Windows.Forms.Button();
            this.btnCopyUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hkControl1
            // 
            this.hkControl1.Hotkey = System.Windows.Forms.Keys.None;
            this.hkControl1.HotkeyModifiers = System.Windows.Forms.Keys.None;
            this.hkControl1.Location = new System.Drawing.Point(12, 12);
            this.hkControl1.Name = "hkControl1";
            this.hkControl1.Size = new System.Drawing.Size(207, 20);
            this.hkControl1.TabIndex = 0;
            // 
            // hkControl2
            // 
            this.hkControl2.Hotkey = System.Windows.Forms.Keys.None;
            this.hkControl2.HotkeyModifiers = System.Windows.Forms.Keys.None;
            this.hkControl2.Location = new System.Drawing.Point(12, 38);
            this.hkControl2.Name = "hkControl2";
            this.hkControl2.Size = new System.Drawing.Size(207, 20);
            this.hkControl2.TabIndex = 2;
            // 
            // btnCopyDown
            // 
            this.btnCopyDown.Location = new System.Drawing.Point(225, 11);
            this.btnCopyDown.Name = "btnCopyDown";
            this.btnCopyDown.Size = new System.Drawing.Size(69, 23);
            this.btnCopyDown.TabIndex = 1;
            this.btnCopyDown.Text = "Copy down";
            this.btnCopyDown.UseVisualStyleBackColor = true;
            this.btnCopyDown.Click += new System.EventHandler(this.btnCopyDown_Click);
            // 
            // btnCopyUp
            // 
            this.btnCopyUp.Location = new System.Drawing.Point(226, 37);
            this.btnCopyUp.Name = "btnCopyUp";
            this.btnCopyUp.Size = new System.Drawing.Size(68, 23);
            this.btnCopyUp.TabIndex = 3;
            this.btnCopyUp.Text = "Copy up";
            this.btnCopyUp.UseVisualStyleBackColor = true;
            this.btnCopyUp.Click += new System.EventHandler(this.btnCopyUp_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 66);
            this.Controls.Add(this.btnCopyUp);
            this.Controls.Add(this.btnCopyDown);
            this.Controls.Add(this.hkControl2);
            this.Controls.Add(this.hkControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Demo";
            this.Text = "HotkeyControl demo application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private exscape.HotkeyControl hkControl1;
        private exscape.HotkeyControl hkControl2;
        private System.Windows.Forms.Button btnCopyDown;
        private System.Windows.Forms.Button btnCopyUp;
    }
}

