namespace Game
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
            this.SuspendLayout();
            // 
            // lbl_preview
            // 
            this.lbl_preview.AutoSize = true;
            this.lbl_preview.Location = new System.Drawing.Point(132, 99);
            this.lbl_preview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(96, 14);
            this.lbl_preview.TabIndex = 1;
            this.lbl_preview.Text = "Preview-Label";
            this.lbl_preview.Visible = false;
            // 
            // txt_preview
            // 
            this.txt_preview.Location = new System.Drawing.Point(111, 158);
            this.txt_preview.Name = "txt_preview";
            this.txt_preview.Size = new System.Drawing.Size(100, 22);
            this.txt_preview.TabIndex = 2;
            this.txt_preview.Visible = false;
            // 
            // Form_Playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 293);
            this.Controls.Add(this.txt_preview);
            this.Controls.Add(this.lbl_preview);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Playground";
            this.Text = "Arbeitsfläche";
            this.Load += new System.EventHandler(this.Form_Playground_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_preview;
        public System.Windows.Forms.TextBox txt_preview;
    }
}