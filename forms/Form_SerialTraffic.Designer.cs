namespace term
{
    partial class Form_SerialTraffic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SerialTraffic));
            this.list_traffic = new System.Windows.Forms.ListBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lbl_connectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.images_connectButton = new System.Windows.Forms.ImageList(this.components);
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_traffic
            // 
            this.list_traffic.BackColor = System.Drawing.SystemColors.MenuText;
            this.list_traffic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_traffic.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_traffic.ForeColor = System.Drawing.Color.LawnGreen;
            this.list_traffic.FormattingEnabled = true;
            this.list_traffic.ItemHeight = 19;
            this.list_traffic.Items.AddRange(new object[] {
            "Ausgabefenster für seriellen Datenverkehr"});
            this.list_traffic.Location = new System.Drawing.Point(0, 0);
            this.list_traffic.Name = "list_traffic";
            this.list_traffic.Size = new System.Drawing.Size(800, 425);
            this.list_traffic.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_connectionState});
            this.statusBar.Location = new System.Drawing.Point(0, 403);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // lbl_connectionState
            // 
            this.lbl_connectionState.Image = ((System.Drawing.Image)(resources.GetObject("lbl_connectionState.Image")));
            this.lbl_connectionState.Name = "lbl_connectionState";
            this.lbl_connectionState.Size = new System.Drawing.Size(80, 17);
            this.lbl_connectionState.Text = "Verbunden";
            // 
            // images_connectButton
            // 
            this.images_connectButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images_connectButton.ImageStream")));
            this.images_connectButton.TransparentColor = System.Drawing.Color.Transparent;
            this.images_connectButton.Images.SetKeyName(0, "network-disconnect.png");
            this.images_connectButton.Images.SetKeyName(1, "network-connect.png");
            // 
            // Form_SerialTraffic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.list_traffic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_SerialTraffic";
            this.ShowIcon = false;
            this.Text = "Serieller Datenverkehr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SerialTraffic_FormClosing);
            this.Load += new System.EventHandler(this.Form_SerialTraffic_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lbl_connectionState;
        public System.Windows.Forms.ListBox list_traffic;
        private System.Windows.Forms.ImageList images_connectButton;
    }
}