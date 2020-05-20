namespace Game
{
    partial class Form_Array
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
            this.pan_field1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pan_field1
            // 
            this.pan_field1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pan_field1.Location = new System.Drawing.Point(12, 12);
            this.pan_field1.Name = "pan_field1";
            this.pan_field1.Size = new System.Drawing.Size(218, 218);
            this.pan_field1.TabIndex = 1;
            // 
            // Form_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pan_field1);
            this.Name = "Form_Array";
            this.Text = "Form_Array";
            this.Load += new System.EventHandler(this.Form_Array_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_field1;
    }
}