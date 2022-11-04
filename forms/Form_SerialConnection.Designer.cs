namespace term
{
    partial class Form_SerialConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SerialConnection));
            this.pan_workbench = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cob_lineEnd = new System.Windows.Forms.ComboBox();
            this.cob_baudrate = new System.Windows.Forms.ComboBox();
            this.cob_serialPort = new System.Windows.Forms.ComboBox();
            this.cmd_saveSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_refresh = new System.Windows.Forms.Button();
            this.lbl_baudrate = new System.Windows.Forms.Label();
            this.lbl_saveSettings = new System.Windows.Forms.Label();
            this.cob_category = new System.Windows.Forms.ComboBox();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.txt_idx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_lineEnd = new System.Windows.Forms.Label();
            this.title_workbench = new System.Windows.Forms.Label();
            this.pan_workbench.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_workbench
            // 
            this.pan_workbench.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pan_workbench.Controls.Add(this.textBox1);
            this.pan_workbench.Controls.Add(this.cob_lineEnd);
            this.pan_workbench.Controls.Add(this.cob_baudrate);
            this.pan_workbench.Controls.Add(this.cob_serialPort);
            this.pan_workbench.Controls.Add(this.cmd_saveSettings);
            this.pan_workbench.Controls.Add(this.label1);
            this.pan_workbench.Controls.Add(this.cmd_refresh);
            this.pan_workbench.Controls.Add(this.lbl_baudrate);
            this.pan_workbench.Controls.Add(this.lbl_saveSettings);
            this.pan_workbench.Controls.Add(this.cob_category);
            this.pan_workbench.Controls.Add(this.txt_comment);
            this.pan_workbench.Controls.Add(this.txt_idx);
            this.pan_workbench.Controls.Add(this.label6);
            this.pan_workbench.Controls.Add(this.label5);
            this.pan_workbench.Controls.Add(this.label4);
            this.pan_workbench.Controls.Add(this.label3);
            this.pan_workbench.Controls.Add(this.lbl_lineEnd);
            this.pan_workbench.Controls.Add(this.title_workbench);
            this.pan_workbench.Location = new System.Drawing.Point(9, 9);
            this.pan_workbench.Name = "pan_workbench";
            this.pan_workbench.Size = new System.Drawing.Size(343, 330);
            this.pan_workbench.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(200, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 23);
            this.textBox1.TabIndex = 906;
            this.textBox1.Text = "N/A";
            // 
            // cob_lineEnd
            // 
            this.cob_lineEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_lineEnd.Font = new System.Drawing.Font("Consolas", 10F);
            this.cob_lineEnd.FormattingEnabled = true;
            this.cob_lineEnd.Items.AddRange(new object[] {
            "<Kein>",
            "<CR>",
            "<LF>",
            "<CR/LF>"});
            this.cob_lineEnd.Location = new System.Drawing.Point(15, 171);
            this.cob_lineEnd.Name = "cob_lineEnd";
            this.cob_lineEnd.Size = new System.Drawing.Size(129, 23);
            this.cob_lineEnd.TabIndex = 905;
            // 
            // cob_baudrate
            // 
            this.cob_baudrate.BackColor = System.Drawing.Color.White;
            this.cob_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_baudrate.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_baudrate.FormattingEnabled = true;
            this.cob_baudrate.Location = new System.Drawing.Point(15, 112);
            this.cob_baudrate.Name = "cob_baudrate";
            this.cob_baudrate.Size = new System.Drawing.Size(128, 23);
            this.cob_baudrate.TabIndex = 904;
            // 
            // cob_serialPort
            // 
            this.cob_serialPort.BackColor = System.Drawing.Color.White;
            this.cob_serialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_serialPort.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_serialPort.FormattingEnabled = true;
            this.cob_serialPort.Location = new System.Drawing.Point(15, 53);
            this.cob_serialPort.Name = "cob_serialPort";
            this.cob_serialPort.Size = new System.Drawing.Size(128, 23);
            this.cob_serialPort.TabIndex = 903;
            // 
            // cmd_saveSettings
            // 
            this.cmd_saveSettings.BackColor = System.Drawing.SystemColors.Window;
            this.cmd_saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_saveSettings.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.cmd_saveSettings.Image = ((System.Drawing.Image)(resources.GetObject("cmd_saveSettings.Image")));
            this.cmd_saveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_saveSettings.Location = new System.Drawing.Point(15, 288);
            this.cmd_saveSettings.Name = "cmd_saveSettings";
            this.cmd_saveSettings.Size = new System.Drawing.Size(314, 30);
            this.cmd_saveSettings.TabIndex = 7;
            this.cmd_saveSettings.Text = "OK!";
            this.cmd_saveSettings.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 900;
            this.label1.Text = "Port";
            // 
            // cmd_refresh
            // 
            this.cmd_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_refresh.Image = ((System.Drawing.Image)(resources.GetObject("cmd_refresh.Image")));
            this.cmd_refresh.Location = new System.Drawing.Point(148, 53);
            this.cmd_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_refresh.Name = "cmd_refresh";
            this.cmd_refresh.Size = new System.Drawing.Size(23, 23);
            this.cmd_refresh.TabIndex = 17;
            this.cmd_refresh.UseVisualStyleBackColor = true;
            // 
            // lbl_baudrate
            // 
            this.lbl_baudrate.AutoSize = true;
            this.lbl_baudrate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_baudrate.Location = new System.Drawing.Point(10, 95);
            this.lbl_baudrate.Name = "lbl_baudrate";
            this.lbl_baudrate.Size = new System.Drawing.Size(55, 16);
            this.lbl_baudrate.TabIndex = 15;
            this.lbl_baudrate.Text = "Baudrate";
            // 
            // lbl_saveSettings
            // 
            this.lbl_saveSettings.AutoSize = true;
            this.lbl_saveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saveSettings.Location = new System.Drawing.Point(11, 270);
            this.lbl_saveSettings.Name = "lbl_saveSettings";
            this.lbl_saveSettings.Size = new System.Drawing.Size(139, 15);
            this.lbl_saveSettings.TabIndex = 14;
            this.lbl_saveSettings.Text = "Einstellungen speichern";
            // 
            // cob_category
            // 
            this.cob_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cob_category.Enabled = false;
            this.cob_category.Font = new System.Drawing.Font("Consolas", 10F);
            this.cob_category.FormattingEnabled = true;
            this.cob_category.Location = new System.Drawing.Point(200, 171);
            this.cob_category.Name = "cob_category";
            this.cob_category.Size = new System.Drawing.Size(129, 23);
            this.cob_category.TabIndex = 4;
            this.cob_category.Text = "N/A";
            // 
            // txt_comment
            // 
            this.txt_comment.Enabled = false;
            this.txt_comment.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comment.Location = new System.Drawing.Point(200, 112);
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(129, 23);
            this.txt_comment.TabIndex = 2;
            this.txt_comment.Text = "N/A";
            // 
            // txt_idx
            // 
            this.txt_idx.Enabled = false;
            this.txt_idx.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idx.Location = new System.Drawing.Point(15, 229);
            this.txt_idx.Name = "txt_idx";
            this.txt_idx.Size = new System.Drawing.Size(129, 23);
            this.txt_idx.TabIndex = 5;
            this.txt_idx.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(197, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "TBA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(197, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "TBA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(197, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "TBA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(10, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "TBA";
            // 
            // lbl_lineEnd
            // 
            this.lbl_lineEnd.AutoSize = true;
            this.lbl_lineEnd.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_lineEnd.Location = new System.Drawing.Point(10, 153);
            this.lbl_lineEnd.Name = "lbl_lineEnd";
            this.lbl_lineEnd.Size = new System.Drawing.Size(137, 16);
            this.lbl_lineEnd.TabIndex = 2;
            this.lbl_lineEnd.Text = "Zeilenende beim Senden";
            // 
            // title_workbench
            // 
            this.title_workbench.AutoSize = true;
            this.title_workbench.BackColor = System.Drawing.SystemColors.ControlLight;
            this.title_workbench.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_workbench.ForeColor = System.Drawing.Color.Crimson;
            this.title_workbench.Location = new System.Drawing.Point(5, 5);
            this.title_workbench.Name = "title_workbench";
            this.title_workbench.Size = new System.Drawing.Size(141, 19);
            this.title_workbench.TabIndex = 0;
            this.title_workbench.Text = "Serielle Verbindung";
            // 
            // Form_SerialConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 346);
            this.Controls.Add(this.pan_workbench);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_SerialConnection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Verbindungseinstellungen";
            this.Load += new System.EventHandler(this.Form_SerialConnection_Load);
            this.pan_workbench.ResumeLayout(false);
            this.pan_workbench.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pan_workbench;
        private System.Windows.Forms.Button cmd_saveSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_refresh;
        private System.Windows.Forms.Label lbl_baudrate;
        private System.Windows.Forms.Label lbl_saveSettings;
        private System.Windows.Forms.ComboBox cob_category;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.TextBox txt_idx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_lineEnd;
        private System.Windows.Forms.Label title_workbench;
        private System.Windows.Forms.ComboBox cob_serialPort;
        private System.Windows.Forms.ComboBox cob_baudrate;
        private System.Windows.Forms.ComboBox cob_lineEnd;
        private System.Windows.Forms.TextBox textBox1;
    }
}