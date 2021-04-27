namespace term
{
    partial class Form_Toolbox
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
            this.listToolbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listToolbox
            // 
            this.listToolbox.BackColor = System.Drawing.Color.Gray;
            this.listToolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listToolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listToolbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listToolbox.FormattingEnabled = true;
            this.listToolbox.ItemHeight = 27;
            this.listToolbox.Items.AddRange(new object[] {
            "Label",
            "Button",
            "ComboBox",
            "TextBox"});
            this.listToolbox.Location = new System.Drawing.Point(0, 0);
            this.listToolbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listToolbox.Name = "listToolbox";
            this.listToolbox.Size = new System.Drawing.Size(128, 223);
            this.listToolbox.TabIndex = 3;
            this.listToolbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form_Toolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(128, 223);
            this.Controls.Add(this.listToolbox);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Toolbox";
            this.Text = "Form_Toolbox";
            this.Load += new System.EventHandler(this.Form_Toolbox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listToolbox;
    }
}