namespace term
{
    partial class Form_Playground
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
            this.lbl_preview = new System.Windows.Forms.Label();
            this.txt_preview = new System.Windows.Forms.TextBox();
            this.cmd_preview = new System.Windows.Forms.Button();
            this.cob_preview = new System.Windows.Forms.ComboBox();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_X = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_preview
            // 
            this.lbl_preview.AutoSize = true;
            this.lbl_preview.Location = new System.Drawing.Point(13, 77);
            this.lbl_preview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(138, 22);
            this.lbl_preview.TabIndex = 1;
            this.lbl_preview.Text = "Preview-Label";
            this.lbl_preview.Visible = false;
            // 
            // txt_preview
            // 
            this.txt_preview.Location = new System.Drawing.Point(12, 113);
            this.txt_preview.Name = "txt_preview";
            this.txt_preview.Size = new System.Drawing.Size(100, 29);
            this.txt_preview.TabIndex = 2;
            this.txt_preview.Visible = false;
            // 
            // cmd_preview
            // 
            this.cmd_preview.Location = new System.Drawing.Point(12, 12);
            this.cmd_preview.Name = "cmd_preview";
            this.cmd_preview.Size = new System.Drawing.Size(115, 45);
            this.cmd_preview.TabIndex = 3;
            this.cmd_preview.Text = "button1";
            this.cmd_preview.UseVisualStyleBackColor = true;
            this.cmd_preview.Visible = false;
            // 
            // cob_preview
            // 
            this.cob_preview.FormattingEnabled = true;
            this.cob_preview.Location = new System.Drawing.Point(12, 161);
            this.cob_preview.Name = "cob_preview";
            this.cob_preview.Size = new System.Drawing.Size(121, 30);
            this.cob_preview.TabIndex = 4;
            this.cob_preview.Visible = false;
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(442, 87);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(64, 22);
            this.lbl_y.TabIndex = 5;
            this.lbl_y.Text = "label1";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(442, 23);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(64, 22);
            this.lbl_X.TabIndex = 6;
            this.lbl_X.Text = "label2";
            // 
            // Form_Playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 293);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.cob_preview);
            this.Controls.Add(this.cmd_preview);
            this.Controls.Add(this.txt_preview);
            this.Controls.Add(this.lbl_preview);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Playground";
            this.Text = "Arbeitsfläche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Playground_FormClosing);
            this.Load += new System.EventHandler(this.Form_Playground_Load);
            this.Click += new System.EventHandler(this.Form_Playground_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Playground_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_preview;
        public System.Windows.Forms.TextBox txt_preview;
        public System.Windows.Forms.Button cmd_preview;
        public System.Windows.Forms.ComboBox cob_preview;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_X;
    }
}