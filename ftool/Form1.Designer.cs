namespace ftool
{
    partial class UI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.windowName1 = new System.Windows.Forms.ComboBox();
            this.KeyCbo1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDelay1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(261, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // windowName1
            // 
            this.windowName1.FormattingEnabled = true;
            this.windowName1.Location = new System.Drawing.Point(35, 49);
            this.windowName1.Name = "windowName1";
            this.windowName1.Size = new System.Drawing.Size(220, 28);
            this.windowName1.TabIndex = 2;
            // 
            // KeyCbo1
            // 
            this.KeyCbo1.FormattingEnabled = true;
            this.KeyCbo1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.KeyCbo1.Location = new System.Drawing.Point(31, 111);
            this.KeyCbo1.Name = "KeyCbo1";
            this.KeyCbo1.Size = new System.Drawing.Size(62, 28);
            this.KeyCbo1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Window Name";
            // 
            // txtDelay1
            // 
            this.txtDelay1.Location = new System.Drawing.Point(113, 113);
            this.txtDelay1.Name = "txtDelay1";
            this.txtDelay1.Size = new System.Drawing.Size(83, 26);
            this.txtDelay1.TabIndex = 10;
            this.txtDelay1.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Delay (ms)";
            // 
            // fKeyCheckBox
            // 
            this.fKeyCheckBox.AutoSize = true;
            this.fKeyCheckBox.Location = new System.Drawing.Point(31, 146);
            this.fKeyCheckBox.Name = "fKeyCheckBox";
            this.fKeyCheckBox.Size = new System.Drawing.Size(117, 24);
            this.fKeyCheckBox.TabIndex = 12;
            this.fKeyCheckBox.Text = "Use F-Keys";
            this.fKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 196);
            this.Controls.Add(this.fKeyCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDelay1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyCbo1);
            this.Controls.Add(this.windowName1);
            this.Controls.Add(this.checkBox1);
            this.Name = "UI";
            this.Text = "Wood\'s Ftool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox windowName1;
        private System.Windows.Forms.ComboBox KeyCbo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDelay1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fKeyCheckBox;
    }
}

