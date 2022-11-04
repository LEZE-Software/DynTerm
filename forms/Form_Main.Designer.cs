namespace term
{
    partial class Form_Center
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Center));
            this.cmd_openPort = new System.Windows.Forms.Button();
            this.cmd_closePort = new System.Windows.Forms.Button();
            this.grp_serialPort = new System.Windows.Forms.GroupBox();
            this.cmd_addSimSerialAnswer = new System.Windows.Forms.Button();
            this.lbl_simulateSerialInput_A = new System.Windows.Forms.Label();
            this.txt_simSerialInput = new System.Windows.Forms.TextBox();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.menuItem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_connection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_openConnectionSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_showSerialTraffic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_view = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_showTraffic = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_showPlayground = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_rules = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_createNewRule = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_editRule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_functions = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_createNewFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_editFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grp_serialPort.SuspendLayout();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_openPort
            // 
            this.cmd_openPort.Location = new System.Drawing.Point(6, 19);
            this.cmd_openPort.Name = "cmd_openPort";
            this.cmd_openPort.Size = new System.Drawing.Size(75, 23);
            this.cmd_openPort.TabIndex = 7;
            this.cmd_openPort.Text = "Connect";
            this.cmd_openPort.UseVisualStyleBackColor = true;
            this.cmd_openPort.Click += new System.EventHandler(this.cmd_openPort_Click);
            // 
            // cmd_closePort
            // 
            this.cmd_closePort.Location = new System.Drawing.Point(119, 19);
            this.cmd_closePort.Name = "cmd_closePort";
            this.cmd_closePort.Size = new System.Drawing.Size(75, 23);
            this.cmd_closePort.TabIndex = 8;
            this.cmd_closePort.Text = "Disconnect";
            this.cmd_closePort.UseVisualStyleBackColor = true;
            this.cmd_closePort.Click += new System.EventHandler(this.cmd_closePort_Click);
            // 
            // grp_serialPort
            // 
            this.grp_serialPort.Controls.Add(this.cmd_addSimSerialAnswer);
            this.grp_serialPort.Controls.Add(this.lbl_simulateSerialInput_A);
            this.grp_serialPort.Controls.Add(this.cmd_openPort);
            this.grp_serialPort.Controls.Add(this.txt_simSerialInput);
            this.grp_serialPort.Controls.Add(this.cmd_closePort);
            this.grp_serialPort.Location = new System.Drawing.Point(12, 640);
            this.grp_serialPort.Name = "grp_serialPort";
            this.grp_serialPort.Size = new System.Drawing.Size(200, 132);
            this.grp_serialPort.TabIndex = 9;
            this.grp_serialPort.TabStop = false;
            this.grp_serialPort.Text = "Serielle Schnittstelle";
            // 
            // cmd_addSimSerialAnswer
            // 
            this.cmd_addSimSerialAnswer.Location = new System.Drawing.Point(119, 99);
            this.cmd_addSimSerialAnswer.Name = "cmd_addSimSerialAnswer";
            this.cmd_addSimSerialAnswer.Size = new System.Drawing.Size(75, 23);
            this.cmd_addSimSerialAnswer.TabIndex = 12;
            this.cmd_addSimSerialAnswer.Text = "Ausführen";
            this.cmd_addSimSerialAnswer.UseVisualStyleBackColor = true;
            this.cmd_addSimSerialAnswer.Click += new System.EventHandler(this.cmd_addSimSerialAnswer_Click);
            // 
            // lbl_simulateSerialInput_A
            // 
            this.lbl_simulateSerialInput_A.AutoSize = true;
            this.lbl_simulateSerialInput_A.Location = new System.Drawing.Point(3, 57);
            this.lbl_simulateSerialInput_A.Name = "lbl_simulateSerialInput_A";
            this.lbl_simulateSerialInput_A.Size = new System.Drawing.Size(95, 13);
            this.lbl_simulateSerialInput_A.TabIndex = 11;
            this.lbl_simulateSerialInput_A.Text = "Eingabe simulieren";
            // 
            // txt_simSerialInput
            // 
            this.txt_simSerialInput.Location = new System.Drawing.Point(6, 73);
            this.txt_simSerialInput.Name = "txt_simSerialInput";
            this.txt_simSerialInput.Size = new System.Drawing.Size(188, 20);
            this.txt_simSerialInput.TabIndex = 10;
            // 
            // main_menu
            // 
            this.main_menu.BackColor = System.Drawing.Color.YellowGreen;
            this.main_menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.main_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_file,
            this.menuItem_connection,
            this.menuItem_view,
            this.menuItem_rules,
            this.menuItem_functions});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1585, 32);
            this.main_menu.TabIndex = 12;
            this.main_menu.Text = "menuStrip1";
            // 
            // menuItem_file
            // 
            this.menuItem_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmd_About});
            this.menuItem_file.Image = ((System.Drawing.Image)(resources.GetObject("menuItem_file.Image")));
            this.menuItem_file.Name = "menuItem_file";
            this.menuItem_file.Size = new System.Drawing.Size(73, 28);
            this.menuItem_file.Text = "Datei";
            // 
            // cmd_About
            // 
            this.cmd_About.Image = ((System.Drawing.Image)(resources.GetObject("cmd_About.Image")));
            this.cmd_About.Name = "cmd_About";
            this.cmd_About.Size = new System.Drawing.Size(170, 30);
            this.cmd_About.Text = "Versionshinweis";
            this.cmd_About.Click += new System.EventHandler(this.cmd_About_Click);
            // 
            // menuItem_connection
            // 
            this.menuItem_connection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmd_connect,
            this.cmd_openConnectionSettings,
            this.cmd_showSerialTraffic});
            this.menuItem_connection.Image = ((System.Drawing.Image)(resources.GetObject("menuItem_connection.Image")));
            this.menuItem_connection.Name = "menuItem_connection";
            this.menuItem_connection.Size = new System.Drawing.Size(152, 28);
            this.menuItem_connection.Text = "Serielle Verbindung";
            // 
            // cmd_connect
            // 
            this.cmd_connect.Image = ((System.Drawing.Image)(resources.GetObject("cmd_connect.Image")));
            this.cmd_connect.Name = "cmd_connect";
            this.cmd_connect.Size = new System.Drawing.Size(235, 30);
            this.cmd_connect.Text = "Verbinden";
            this.cmd_connect.Click += new System.EventHandler(this.cmd_connect_Click);
            // 
            // cmd_openConnectionSettings
            // 
            this.cmd_openConnectionSettings.Image = ((System.Drawing.Image)(resources.GetObject("cmd_openConnectionSettings.Image")));
            this.cmd_openConnectionSettings.Name = "cmd_openConnectionSettings";
            this.cmd_openConnectionSettings.Size = new System.Drawing.Size(235, 30);
            this.cmd_openConnectionSettings.Text = "Verbindungseinstellungen...";
            this.cmd_openConnectionSettings.Click += new System.EventHandler(this.cmd_openConnectionSettings_Click);
            // 
            // cmd_showSerialTraffic
            // 
            this.cmd_showSerialTraffic.Image = ((System.Drawing.Image)(resources.GetObject("cmd_showSerialTraffic.Image")));
            this.cmd_showSerialTraffic.Name = "cmd_showSerialTraffic";
            this.cmd_showSerialTraffic.Size = new System.Drawing.Size(235, 30);
            this.cmd_showSerialTraffic.Tag = "";
            this.cmd_showSerialTraffic.Text = "Datenverkehr anzeigen";
            this.cmd_showSerialTraffic.Click += new System.EventHandler(this.cmd_showSerialTraffic_Click);
            // 
            // menuItem_view
            // 
            this.menuItem_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmd_showTraffic,
            this.cmd_showPlayground});
            this.menuItem_view.Image = ((System.Drawing.Image)(resources.GetObject("menuItem_view.Image")));
            this.menuItem_view.Name = "menuItem_view";
            this.menuItem_view.Size = new System.Drawing.Size(84, 28);
            this.menuItem_view.Text = "Ansicht";
            // 
            // cmd_showTraffic
            // 
            this.cmd_showTraffic.Image = ((System.Drawing.Image)(resources.GetObject("cmd_showTraffic.Image")));
            this.cmd_showTraffic.Name = "cmd_showTraffic";
            this.cmd_showTraffic.Size = new System.Drawing.Size(188, 30);
            this.cmd_showTraffic.Tag = "";
            this.cmd_showTraffic.Text = "Serial Monitor";
            this.cmd_showTraffic.Click += new System.EventHandler(this.cmd_showSerialTraffic_Click);
            // 
            // cmd_showPlayground
            // 
            this.cmd_showPlayground.Image = ((System.Drawing.Image)(resources.GetObject("cmd_showPlayground.Image")));
            this.cmd_showPlayground.Name = "cmd_showPlayground";
            this.cmd_showPlayground.Size = new System.Drawing.Size(188, 30);
            this.cmd_showPlayground.Text = "Arbeitsfläche";
            this.cmd_showPlayground.Visible = false;
            this.cmd_showPlayground.Click += new System.EventHandler(this.cmd_openPlayground_Click);
            // 
            // menuItem_rules
            // 
            this.menuItem_rules.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmd_createNewRule,
            this.cmd_editRule});
            this.menuItem_rules.Image = ((System.Drawing.Image)(resources.GetObject("menuItem_rules.Image")));
            this.menuItem_rules.Name = "menuItem_rules";
            this.menuItem_rules.Size = new System.Drawing.Size(82, 28);
            this.menuItem_rules.Text = "Regeln";
            // 
            // cmd_createNewRule
            // 
            this.cmd_createNewRule.Image = ((System.Drawing.Image)(resources.GetObject("cmd_createNewRule.Image")));
            this.cmd_createNewRule.Name = "cmd_createNewRule";
            this.cmd_createNewRule.Size = new System.Drawing.Size(194, 30);
            this.cmd_createNewRule.Tag = "";
            this.cmd_createNewRule.Text = "Neu...";
            this.cmd_createNewRule.Click += new System.EventHandler(this.menu_createNewRule_Click);
            // 
            // cmd_editRule
            // 
            this.cmd_editRule.Image = ((System.Drawing.Image)(resources.GetObject("cmd_editRule.Image")));
            this.cmd_editRule.Name = "cmd_editRule";
            this.cmd_editRule.Size = new System.Drawing.Size(194, 30);
            this.cmd_editRule.Text = "Regeln bearbeiten...";
            this.cmd_editRule.Click += new System.EventHandler(this.cmd_editRule_Click);
            // 
            // menuItem_functions
            // 
            this.menuItem_functions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmd_createNewFunction,
            this.cmd_editFunction});
            this.menuItem_functions.Image = ((System.Drawing.Image)(resources.GetObject("menuItem_functions.Image")));
            this.menuItem_functions.Name = "menuItem_functions";
            this.menuItem_functions.Size = new System.Drawing.Size(106, 28);
            this.menuItem_functions.Text = "Funktionen";
            // 
            // cmd_createNewFunction
            // 
            this.cmd_createNewFunction.Image = ((System.Drawing.Image)(resources.GetObject("cmd_createNewFunction.Image")));
            this.cmd_createNewFunction.Name = "cmd_createNewFunction";
            this.cmd_createNewFunction.Size = new System.Drawing.Size(218, 30);
            this.cmd_createNewFunction.Text = "Neu...";
            this.cmd_createNewFunction.Click += new System.EventHandler(this.cmd_createNewFunction_Click);
            // 
            // cmd_editFunction
            // 
            this.cmd_editFunction.Image = ((System.Drawing.Image)(resources.GetObject("cmd_editFunction.Image")));
            this.cmd_editFunction.Name = "cmd_editFunction";
            this.cmd_editFunction.Size = new System.Drawing.Size(218, 30);
            this.cmd_editFunction.Text = "Funktionen bearbeiten...";
            this.cmd_editFunction.Click += new System.EventHandler(this.cmd_editFunction_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 793);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1585, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 815);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grp_serialPort);
            this.Controls.Add(this.main_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.main_menu;
            this.Name = "Form_Center";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DynTerm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Center_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_serialPort.ResumeLayout(false);
            this.grp_serialPort.PerformLayout();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_openPort;
        private System.Windows.Forms.Button cmd_closePort;
        private System.Windows.Forms.GroupBox grp_serialPort;
        private System.Windows.Forms.Button cmd_addSimSerialAnswer;
        private System.Windows.Forms.Label lbl_simulateSerialInput_A;
        private System.Windows.Forms.TextBox txt_simSerialInput;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_file;
        private System.Windows.Forms.ToolStripMenuItem menuItem_view;
        private System.Windows.Forms.ToolStripMenuItem cmd_showPlayground;
        private System.Windows.Forms.ToolStripMenuItem menuItem_rules;
        private System.Windows.Forms.ToolStripMenuItem cmd_createNewRule;
        private System.Windows.Forms.ToolStripMenuItem cmd_editRule;
        private System.Windows.Forms.ToolStripMenuItem menuItem_functions;
        private System.Windows.Forms.ToolStripMenuItem cmd_createNewFunction;
        private System.Windows.Forms.ToolStripMenuItem cmd_editFunction;
        private System.Windows.Forms.ToolStripMenuItem menuItem_connection;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmd_connect;
        private System.Windows.Forms.ToolStripMenuItem cmd_openConnectionSettings;
        private System.Windows.Forms.ToolStripMenuItem cmd_About;
        private System.Windows.Forms.ToolStripMenuItem cmd_showSerialTraffic;
        private System.Windows.Forms.ToolStripMenuItem cmd_showTraffic;
    }
}

