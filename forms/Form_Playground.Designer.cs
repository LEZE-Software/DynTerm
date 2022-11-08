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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Playground));
            this.infoStrip_playground = new System.Windows.Forms.StatusStrip();
            this.pan_preview = new System.Windows.Forms.Panel();
            this.title_workbench = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cob_serialPort = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmd_saveSettings = new System.Windows.Forms.Button();
            this.context_panel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmd_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sperrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_preview.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.context_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoStrip_playground
            // 
            this.infoStrip_playground.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.infoStrip_playground.Location = new System.Drawing.Point(0, 362);
            this.infoStrip_playground.Name = "infoStrip_playground";
            this.infoStrip_playground.Size = new System.Drawing.Size(575, 22);
            this.infoStrip_playground.TabIndex = 7;
            this.infoStrip_playground.Text = "statusStrip1";
            // 
            // pan_preview
            // 
            this.pan_preview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pan_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_preview.ContextMenuStrip = this.context_panel;
            this.pan_preview.Controls.Add(this.cob_serialPort);
            this.pan_preview.Controls.Add(this.label1);
            this.pan_preview.Controls.Add(this.title_workbench);
            this.pan_preview.Location = new System.Drawing.Point(12, 12);
            this.pan_preview.Name = "pan_preview";
            this.pan_preview.Size = new System.Drawing.Size(160, 90);
            this.pan_preview.TabIndex = 8;
            // 
            // title_workbench
            // 
            this.title_workbench.AutoSize = true;
            this.title_workbench.BackColor = System.Drawing.SystemColors.ControlLight;
            this.title_workbench.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_workbench.ForeColor = System.Drawing.Color.Crimson;
            this.title_workbench.Location = new System.Drawing.Point(5, 5);
            this.title_workbench.Name = "title_workbench";
            this.title_workbench.Size = new System.Drawing.Size(93, 19);
            this.title_workbench.TabIndex = 1;
            this.title_workbench.Text = "Beispielsfeld";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 901;
            this.label1.Text = "Bezeichner";
            // 
            // cob_serialPort
            // 
            this.cob_serialPort.BackColor = System.Drawing.Color.White;
            this.cob_serialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_serialPort.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_serialPort.FormattingEnabled = true;
            this.cob_serialPort.Location = new System.Drawing.Point(15, 52);
            this.cob_serialPort.Name = "cob_serialPort";
            this.cob_serialPort.Size = new System.Drawing.Size(130, 23);
            this.cob_serialPort.TabIndex = 904;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ContextMenuStrip = this.context_panel;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 90);
            this.panel1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 23);
            this.comboBox1.TabIndex = 904;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 901;
            this.label2.Text = "Bezeichner 10/35";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Beispielsfeld";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 23);
            this.comboBox2.TabIndex = 905;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(170, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 906;
            this.label4.Text = "Bezeichner 170/35";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ContextMenuStrip = this.context_panel;
            this.panel2.Controls.Add(this.cmd_saveSettings);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 90);
            this.panel2.TabIndex = 907;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(170, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 906;
            this.label5.Text = "Bezeichner 170/35";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 901;
            this.label6.Text = "Bezeichner 10/35";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Beispielsfeld";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 23);
            this.textBox1.TabIndex = 908;
            this.textBox1.Text = "Textbox 15 / 52";
            this.textBox1.Visible = false;
            // 
            // cmd_saveSettings
            // 
            this.cmd_saveSettings.BackColor = System.Drawing.SystemColors.Window;
            this.cmd_saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_saveSettings.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.cmd_saveSettings.Image = ((System.Drawing.Image)(resources.GetObject("cmd_saveSettings.Image")));
            this.cmd_saveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_saveSettings.Location = new System.Drawing.Point(175, 52);
            this.cmd_saveSettings.Name = "cmd_saveSettings";
            this.cmd_saveSettings.Size = new System.Drawing.Size(130, 23);
            this.cmd_saveSettings.TabIndex = 908;
            this.cmd_saveSettings.Text = "Button 175 / 52";
            this.cmd_saveSettings.UseVisualStyleBackColor = false;
            // 
            // context_panel
            // 
            this.context_panel.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.context_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmd_delete,
            this.bearbeitenToolStripMenuItem,
            this.deaktivierenToolStripMenuItem,
            this.sperrenToolStripMenuItem});
            this.context_panel.Name = "context_panel";
            this.context_panel.Size = new System.Drawing.Size(148, 124);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("cmd_delete.Image")));
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(147, 30);
            this.cmd_delete.Text = "Entfernen";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bearbeitenToolStripMenuItem.Image")));
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten...";
            // 
            // deaktivierenToolStripMenuItem
            // 
            this.deaktivierenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deaktivierenToolStripMenuItem.Image")));
            this.deaktivierenToolStripMenuItem.Name = "deaktivierenToolStripMenuItem";
            this.deaktivierenToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.deaktivierenToolStripMenuItem.Text = "Deaktivieren";
            // 
            // sperrenToolStripMenuItem
            // 
            this.sperrenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sperrenToolStripMenuItem.Image")));
            this.sperrenToolStripMenuItem.Name = "sperrenToolStripMenuItem";
            this.sperrenToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.sperrenToolStripMenuItem.Text = "Sperren";
            // 
            // Form_Playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(575, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_preview);
            this.Controls.Add(this.infoStrip_playground);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form_Playground";
            this.ShowIcon = false;
            this.Text = "Arbeitsfläche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Playground_FormClosing);
            this.Load += new System.EventHandler(this.Form_Playground_Load);
            this.Click += new System.EventHandler(this.Form_Playground_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Playground_MouseMove);
            this.pan_preview.ResumeLayout(false);
            this.pan_preview.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.context_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip infoStrip_playground;
        private System.Windows.Forms.Panel pan_preview;
        private System.Windows.Forms.Label title_workbench;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cob_serialPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmd_saveSettings;
        private System.Windows.Forms.ContextMenuStrip context_panel;
        private System.Windows.Forms.ToolStripMenuItem cmd_delete;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sperrenToolStripMenuItem;
    }
}