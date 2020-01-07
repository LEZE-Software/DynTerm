namespace Game
{
    partial class Form1
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
            this.pan_field1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.lbl_keyword = new System.Windows.Forms.Label();
            this.txt_displayText = new System.Windows.Forms.TextBox();
            this.lbl_displayText = new System.Windows.Forms.Label();
            this.cob_chooseFunction = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pan_field1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_field1
            // 
            this.pan_field1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pan_field1.Controls.Add(this.label3);
            this.pan_field1.Controls.Add(this.label2);
            this.pan_field1.Controls.Add(this.label1);
            this.pan_field1.Location = new System.Drawing.Point(12, 12);
            this.pan_field1.Name = "pan_field1";
            this.pan_field1.Size = new System.Drawing.Size(218, 218);
            this.pan_field1.TabIndex = 0;
            this.pan_field1.MouseHover += new System.EventHandler(this.pan_field_MouseOver);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Tag = "func3";
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "func2";
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "func1";
            this.label1.Text = "label1";
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(366, 106);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(100, 20);
            this.txt_keyword.TabIndex = 1;
            // 
            // lbl_keyword
            // 
            this.lbl_keyword.AutoSize = true;
            this.lbl_keyword.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_keyword.Location = new System.Drawing.Point(363, 90);
            this.lbl_keyword.Name = "lbl_keyword";
            this.lbl_keyword.Size = new System.Drawing.Size(51, 13);
            this.lbl_keyword.TabIndex = 2;
            this.lbl_keyword.Text = "Keyword.";
            // 
            // txt_displayText
            // 
            this.txt_displayText.Location = new System.Drawing.Point(542, 106);
            this.txt_displayText.Name = "txt_displayText";
            this.txt_displayText.Size = new System.Drawing.Size(100, 20);
            this.txt_displayText.TabIndex = 3;
            // 
            // lbl_displayText
            // 
            this.lbl_displayText.AutoSize = true;
            this.lbl_displayText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_displayText.Location = new System.Drawing.Point(539, 90);
            this.lbl_displayText.Name = "lbl_displayText";
            this.lbl_displayText.Size = new System.Drawing.Size(65, 13);
            this.lbl_displayText.TabIndex = 4;
            this.lbl_displayText.Text = "Anzeigetext:";
            // 
            // cob_chooseFunction
            // 
            this.cob_chooseFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_chooseFunction.FormattingEnabled = true;
            this.cob_chooseFunction.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3"});
            this.cob_chooseFunction.Location = new System.Drawing.Point(667, 105);
            this.cob_chooseFunction.Name = "cob_chooseFunction";
            this.cob_chooseFunction.Size = new System.Drawing.Size(121, 21);
            this.cob_chooseFunction.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Disconnect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cob_chooseFunction);
            this.Controls.Add(this.lbl_displayText);
            this.Controls.Add(this.txt_displayText);
            this.Controls.Add(this.lbl_keyword);
            this.Controls.Add(this.txt_keyword);
            this.Controls.Add(this.pan_field1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pan_field1.ResumeLayout(false);
            this.pan_field1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_field1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.Label lbl_keyword;
        private System.Windows.Forms.TextBox txt_displayText;
        private System.Windows.Forms.Label lbl_displayText;
        private System.Windows.Forms.ComboBox cob_chooseFunction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

