namespace term
{
    partial class Form_PanelWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PanelWizard));
            this.pan_workbench = new System.Windows.Forms.Panel();
            this.cob_ActionElement = new System.Windows.Forms.ComboBox();
            this.cob_ClickAction = new System.Windows.Forms.ComboBox();
            this.lbl_ClickAciton = new System.Windows.Forms.Label();
            this.cob_PanelType = new System.Windows.Forms.ComboBox();
            this.cob_ParentFunction = new System.Windows.Forms.ComboBox();
            this.txt_SubTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.cmd_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_list = new System.Windows.Forms.Label();
            this.lbl_saveSettings = new System.Windows.Forms.Label();
            this.lbl_ActionElement = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.title_workbench = new System.Windows.Forms.Label();
            this.pan_workbench.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_workbench
            // 
            this.pan_workbench.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pan_workbench.Controls.Add(this.cob_ActionElement);
            this.pan_workbench.Controls.Add(this.cob_ClickAction);
            this.pan_workbench.Controls.Add(this.lbl_ClickAciton);
            this.pan_workbench.Controls.Add(this.cob_PanelType);
            this.pan_workbench.Controls.Add(this.cob_ParentFunction);
            this.pan_workbench.Controls.Add(this.txt_SubTitle);
            this.pan_workbench.Controls.Add(this.label2);
            this.pan_workbench.Controls.Add(this.txt_Title);
            this.pan_workbench.Controls.Add(this.cmd_save);
            this.pan_workbench.Controls.Add(this.label1);
            this.pan_workbench.Controls.Add(this.lbl_list);
            this.pan_workbench.Controls.Add(this.lbl_saveSettings);
            this.pan_workbench.Controls.Add(this.lbl_ActionElement);
            this.pan_workbench.Controls.Add(this.label4);
            this.pan_workbench.Controls.Add(this.title_workbench);
            this.pan_workbench.Location = new System.Drawing.Point(12, 12);
            this.pan_workbench.Name = "pan_workbench";
            this.pan_workbench.Size = new System.Drawing.Size(343, 330);
            this.pan_workbench.TabIndex = 10;
            // 
            // cob_ActionElement
            // 
            this.cob_ActionElement.BackColor = System.Drawing.Color.White;
            this.cob_ActionElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_ActionElement.Enabled = false;
            this.cob_ActionElement.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_ActionElement.FormattingEnabled = true;
            this.cob_ActionElement.Location = new System.Drawing.Point(200, 228);
            this.cob_ActionElement.Name = "cob_ActionElement";
            this.cob_ActionElement.Size = new System.Drawing.Size(130, 23);
            this.cob_ActionElement.TabIndex = 920;
            // 
            // cob_ClickAction
            // 
            this.cob_ClickAction.BackColor = System.Drawing.Color.White;
            this.cob_ClickAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_ClickAction.Enabled = false;
            this.cob_ClickAction.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_ClickAction.FormattingEnabled = true;
            this.cob_ClickAction.Items.AddRange(new object[] {
            "Sende Zeichenkette"});
            this.cob_ClickAction.Location = new System.Drawing.Point(15, 228);
            this.cob_ClickAction.Name = "cob_ClickAction";
            this.cob_ClickAction.Size = new System.Drawing.Size(130, 23);
            this.cob_ClickAction.TabIndex = 919;
            // 
            // lbl_ClickAciton
            // 
            this.lbl_ClickAciton.AutoSize = true;
            this.lbl_ClickAciton.Enabled = false;
            this.lbl_ClickAciton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_ClickAciton.Location = new System.Drawing.Point(10, 212);
            this.lbl_ClickAciton.Name = "lbl_ClickAciton";
            this.lbl_ClickAciton.Size = new System.Drawing.Size(71, 16);
            this.lbl_ClickAciton.TabIndex = 918;
            this.lbl_ClickAciton.Text = "Beim Klick...";
            // 
            // cob_PanelType
            // 
            this.cob_PanelType.BackColor = System.Drawing.Color.White;
            this.cob_PanelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_PanelType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_PanelType.FormattingEnabled = true;
            this.cob_PanelType.Items.AddRange(new object[] {
            "Anzeigefeld",
            "Eingabefeld",
            "Auswahlfeld",
            "Button-Feld"});
            this.cob_PanelType.Location = new System.Drawing.Point(15, 171);
            this.cob_PanelType.Name = "cob_PanelType";
            this.cob_PanelType.Size = new System.Drawing.Size(130, 23);
            this.cob_PanelType.TabIndex = 917;
            this.cob_PanelType.SelectedIndexChanged += new System.EventHandler(this.cob_PanelType_SelectedIndexChanged);
            // 
            // cob_ParentFunction
            // 
            this.cob_ParentFunction.BackColor = System.Drawing.Color.White;
            this.cob_ParentFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_ParentFunction.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_ParentFunction.FormattingEnabled = true;
            this.cob_ParentFunction.Location = new System.Drawing.Point(15, 53);
            this.cob_ParentFunction.Name = "cob_ParentFunction";
            this.cob_ParentFunction.Size = new System.Drawing.Size(130, 23);
            this.cob_ParentFunction.TabIndex = 916;
            // 
            // txt_SubTitle
            // 
            this.txt_SubTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubTitle.Location = new System.Drawing.Point(200, 112);
            this.txt_SubTitle.Name = "txt_SubTitle";
            this.txt_SubTitle.Size = new System.Drawing.Size(130, 23);
            this.txt_SubTitle.TabIndex = 915;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(195, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 909;
            this.label2.Text = "Bezeichner";
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(15, 112);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(130, 23);
            this.txt_Title.TabIndex = 908;
            // 
            // cmd_save
            // 
            this.cmd_save.BackColor = System.Drawing.SystemColors.Window;
            this.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_save.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.cmd_save.Image = ((System.Drawing.Image)(resources.GetObject("cmd_save.Image")));
            this.cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_save.Location = new System.Drawing.Point(15, 288);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(314, 30);
            this.cmd_save.TabIndex = 7;
            this.cmd_save.Text = "OK!";
            this.cmd_save.UseVisualStyleBackColor = false;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 900;
            this.label1.Text = "Zugehörige Funktion";
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_list.Location = new System.Drawing.Point(10, 95);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(30, 16);
            this.lbl_list.TabIndex = 15;
            this.lbl_list.Text = "Titel";
            // 
            // lbl_saveSettings
            // 
            this.lbl_saveSettings.AutoSize = true;
            this.lbl_saveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saveSettings.Location = new System.Drawing.Point(10, 270);
            this.lbl_saveSettings.Name = "lbl_saveSettings";
            this.lbl_saveSettings.Size = new System.Drawing.Size(80, 15);
            this.lbl_saveSettings.TabIndex = 14;
            this.lbl_saveSettings.Text = "Übernehmen";
            // 
            // lbl_ActionElement
            // 
            this.lbl_ActionElement.AutoSize = true;
            this.lbl_ActionElement.Enabled = false;
            this.lbl_ActionElement.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_ActionElement.Location = new System.Drawing.Point(195, 212);
            this.lbl_ActionElement.Name = "lbl_ActionElement";
            this.lbl_ActionElement.Size = new System.Drawing.Size(82, 16);
            this.lbl_ActionElement.TabIndex = 5;
            this.lbl_ActionElement.Text = "Aus Element...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(10, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Panel-Typ";
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
            this.title_workbench.Text = "Panel konfigurieren";
            // 
            // Form_PanelWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 346);
            this.Controls.Add(this.pan_workbench);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_PanelWizard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Paneleditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_PanelWizard_FormClosing);
            this.Load += new System.EventHandler(this.Form_PanelWizard_Load);
            this.pan_workbench.ResumeLayout(false);
            this.pan_workbench.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_workbench;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.Label lbl_saveSettings;
        private System.Windows.Forms.Label lbl_ActionElement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label title_workbench;
        private System.Windows.Forms.TextBox txt_SubTitle;
        private System.Windows.Forms.ComboBox cob_ParentFunction;
        private System.Windows.Forms.ComboBox cob_PanelType;
        private System.Windows.Forms.ComboBox cob_ActionElement;
        private System.Windows.Forms.ComboBox cob_ClickAction;
        private System.Windows.Forms.Label lbl_ClickAciton;
    }
}