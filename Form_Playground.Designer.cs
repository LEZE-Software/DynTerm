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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Playground));
            this.lbl_preview = new System.Windows.Forms.Label();
            this.txt_preview = new System.Windows.Forms.TextBox();
            this.cmd_preview = new System.Windows.Forms.Button();
            this.cob_preview = new System.Windows.Forms.ComboBox();
            this.infoStrip_playground = new System.Windows.Forms.StatusStrip();
            this.lbl_newObjectPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmd_displayMainForm = new System.Windows.Forms.ToolStripSplitButton();
            this.infoStrip_playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_preview
            // 
            this.lbl_preview.AutoSize = true;
            this.lbl_preview.Location = new System.Drawing.Point(13, 77);
            this.lbl_preview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(111, 18);
            this.lbl_preview.TabIndex = 1;
            this.lbl_preview.Text = "Preview-Label";
            this.lbl_preview.Visible = false;
            // 
            // txt_preview
            // 
            this.txt_preview.Location = new System.Drawing.Point(12, 113);
            this.txt_preview.Name = "txt_preview";
            this.txt_preview.Size = new System.Drawing.Size(100, 26);
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
            this.cob_preview.Size = new System.Drawing.Size(121, 26);
            this.cob_preview.TabIndex = 4;
            this.cob_preview.Visible = false;
            // 
            // infoStrip_playground
            // 
            this.infoStrip_playground.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.infoStrip_playground.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_newObjectPos,
            this.cmd_displayMainForm});
            this.infoStrip_playground.Location = new System.Drawing.Point(0, 267);
            this.infoStrip_playground.Name = "infoStrip_playground";
            this.infoStrip_playground.Size = new System.Drawing.Size(575, 26);
            this.infoStrip_playground.TabIndex = 7;
            this.infoStrip_playground.Text = "statusStrip1";
            // 
            // lbl_newObjectPos
            // 
            this.lbl_newObjectPos.Name = "lbl_newObjectPos";
            this.lbl_newObjectPos.Size = new System.Drawing.Size(15, 21);
            this.lbl_newObjectPos.Text = "-";
            // 
            // cmd_displayMainForm
            // 
            this.cmd_displayMainForm.Image = ((System.Drawing.Image)(resources.GetObject("cmd_displayMainForm.Image")));
            this.cmd_displayMainForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmd_displayMainForm.Name = "cmd_displayMainForm";
            this.cmd_displayMainForm.Size = new System.Drawing.Size(180, 24);
            this.cmd_displayMainForm.Text = "Bearbeitungsmodus";
            // 
            // Form_Playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 293);
            this.Controls.Add(this.infoStrip_playground);
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
            this.infoStrip_playground.ResumeLayout(false);
            this.infoStrip_playground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_preview;
        public System.Windows.Forms.TextBox txt_preview;
        public System.Windows.Forms.Button cmd_preview;
        public System.Windows.Forms.ComboBox cob_preview;
        private System.Windows.Forms.StatusStrip infoStrip_playground;
        private System.Windows.Forms.ToolStripStatusLabel lbl_newObjectPos;
        private System.Windows.Forms.ToolStripSplitButton cmd_displayMainForm;
    }
}