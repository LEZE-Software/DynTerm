namespace term
{
    partial class Form_NewEditRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NewEditRule));
            this.pan_workbench = new System.Windows.Forms.Panel();
            this.cob_CheckOperation = new System.Windows.Forms.ComboBox();
            this.cob_function = new System.Windows.Forms.ComboBox();
            this.chb_activate = new System.Windows.Forms.CheckBox();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.list_show = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.cmd_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_list = new System.Windows.Forms.Label();
            this.lbl_saveSettings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_activate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.title_workbench = new System.Windows.Forms.Label();
            this.tab_options = new System.Windows.Forms.TabControl();
            this.page_display = new System.Windows.Forms.TabPage();
            this.pan_output = new System.Windows.Forms.Panel();
            this.cob_negativeOutput = new System.Windows.Forms.ComboBox();
            this.cob_positiveOutput = new System.Windows.Forms.ComboBox();
            this.cob_outputElementNeg = new System.Windows.Forms.ComboBox();
            this.lbl_negOutputElement = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cob_outputElementPos = new System.Windows.Forms.ComboBox();
            this.lbl_negOutput_Title = new System.Windows.Forms.Label();
            this.chb_output = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.page_send = new System.Windows.Forms.TabPage();
            this.pan_send = new System.Windows.Forms.Panel();
            this.chb_sendIfNegative = new System.Windows.Forms.CheckBox();
            this.chb_sendIfPositive = new System.Windows.Forms.CheckBox();
            this.txt_sendIfNegative = new System.Windows.Forms.TextBox();
            this.lbl_sendNeg = new System.Windows.Forms.Label();
            this.chb_serialOption = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_sendPos = new System.Windows.Forms.Label();
            this.txt_sendIfPositive = new System.Windows.Forms.TextBox();
            this.images_activate = new System.Windows.Forms.ImageList(this.components);
            this.pan_workbench.SuspendLayout();
            this.tab_options.SuspendLayout();
            this.page_display.SuspendLayout();
            this.pan_output.SuspendLayout();
            this.page_send.SuspendLayout();
            this.pan_send.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_workbench
            // 
            this.pan_workbench.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pan_workbench.Controls.Add(this.cob_CheckOperation);
            this.pan_workbench.Controls.Add(this.cob_function);
            this.pan_workbench.Controls.Add(this.chb_activate);
            this.pan_workbench.Controls.Add(this.cmd_delete);
            this.pan_workbench.Controls.Add(this.list_show);
            this.pan_workbench.Controls.Add(this.label2);
            this.pan_workbench.Controls.Add(this.txt_keyword);
            this.pan_workbench.Controls.Add(this.cmd_save);
            this.pan_workbench.Controls.Add(this.label1);
            this.pan_workbench.Controls.Add(this.lbl_list);
            this.pan_workbench.Controls.Add(this.lbl_saveSettings);
            this.pan_workbench.Controls.Add(this.label6);
            this.pan_workbench.Controls.Add(this.lbl_activate);
            this.pan_workbench.Controls.Add(this.label4);
            this.pan_workbench.Controls.Add(this.title_workbench);
            this.pan_workbench.Location = new System.Drawing.Point(9, 8);
            this.pan_workbench.Name = "pan_workbench";
            this.pan_workbench.Size = new System.Drawing.Size(343, 330);
            this.pan_workbench.TabIndex = 10;
            // 
            // cob_CheckOperation
            // 
            this.cob_CheckOperation.BackColor = System.Drawing.Color.White;
            this.cob_CheckOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_CheckOperation.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_CheckOperation.FormattingEnabled = true;
            this.cob_CheckOperation.Items.AddRange(new object[] {
            "enthält Key",
            "enthält Key nicht",
            "entspricht Key",
            "immer ausführen"});
            this.cob_CheckOperation.Location = new System.Drawing.Point(200, 53);
            this.cob_CheckOperation.Name = "cob_CheckOperation";
            this.cob_CheckOperation.Size = new System.Drawing.Size(129, 23);
            this.cob_CheckOperation.TabIndex = 920;
            this.cob_CheckOperation.SelectedIndexChanged += new System.EventHandler(this.cob_CheckOperation_SelectedIndexChanged);
            // 
            // cob_function
            // 
            this.cob_function.BackColor = System.Drawing.Color.White;
            this.cob_function.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_function.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_function.FormattingEnabled = true;
            this.cob_function.Location = new System.Drawing.Point(200, 112);
            this.cob_function.Name = "cob_function";
            this.cob_function.Size = new System.Drawing.Size(129, 23);
            this.cob_function.TabIndex = 919;
            // 
            // chb_activate
            // 
            this.chb_activate.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_activate.BackColor = System.Drawing.SystemColors.Window;
            this.chb_activate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_activate.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.chb_activate.Image = ((System.Drawing.Image)(resources.GetObject("chb_activate.Image")));
            this.chb_activate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_activate.Location = new System.Drawing.Point(200, 229);
            this.chb_activate.Name = "chb_activate";
            this.chb_activate.Size = new System.Drawing.Size(129, 24);
            this.chb_activate.TabIndex = 914;
            this.chb_activate.Tag = "active";
            this.chb_activate.Text = "Aktivieren";
            this.chb_activate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_activate.UseVisualStyleBackColor = false;
            this.chb_activate.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cmd_delete
            // 
            this.cmd_delete.BackColor = System.Drawing.SystemColors.Window;
            this.cmd_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_delete.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("cmd_delete.Image")));
            this.cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_delete.Location = new System.Drawing.Point(200, 171);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(129, 23);
            this.cmd_delete.TabIndex = 912;
            this.cmd_delete.Text = "OK!";
            this.cmd_delete.UseVisualStyleBackColor = false;
            // 
            // list_show
            // 
            this.list_show.FormattingEnabled = true;
            this.list_show.Location = new System.Drawing.Point(15, 112);
            this.list_show.Name = "list_show";
            this.list_show.Size = new System.Drawing.Size(129, 147);
            this.list_show.TabIndex = 911;
            this.list_show.SelectedIndexChanged += new System.EventHandler(this.list_show_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(195, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 909;
            this.label2.Text = "Funktionsweise";
            // 
            // txt_keyword
            // 
            this.txt_keyword.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_keyword.Location = new System.Drawing.Point(15, 53);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(129, 23);
            this.txt_keyword.TabIndex = 908;
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
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 900;
            this.label1.Text = "Schlüsselwort";
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_list.Location = new System.Drawing.Point(10, 95);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(111, 16);
            this.lbl_list.TabIndex = 15;
            this.lbl_list.Text = "Vorhandene Regeln";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(195, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Löschen";
            // 
            // lbl_activate
            // 
            this.lbl_activate.AutoSize = true;
            this.lbl_activate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_activate.Location = new System.Drawing.Point(195, 212);
            this.lbl_activate.Name = "lbl_activate";
            this.lbl_activate.Size = new System.Drawing.Size(61, 16);
            this.lbl_activate.TabIndex = 5;
            this.lbl_activate.Text = "Aktivieren";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(195, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zugehörige Funktion";
            // 
            // title_workbench
            // 
            this.title_workbench.AutoSize = true;
            this.title_workbench.BackColor = System.Drawing.SystemColors.ControlLight;
            this.title_workbench.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_workbench.ForeColor = System.Drawing.Color.Crimson;
            this.title_workbench.Location = new System.Drawing.Point(5, 5);
            this.title_workbench.Name = "title_workbench";
            this.title_workbench.Size = new System.Drawing.Size(132, 19);
            this.title_workbench.TabIndex = 0;
            this.title_workbench.Text = "Regeln bearbeiten";
            // 
            // tab_options
            // 
            this.tab_options.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tab_options.Controls.Add(this.page_display);
            this.tab_options.Controls.Add(this.page_send);
            this.tab_options.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.tab_options.Location = new System.Drawing.Point(358, 8);
            this.tab_options.Name = "tab_options";
            this.tab_options.SelectedIndex = 0;
            this.tab_options.Size = new System.Drawing.Size(362, 330);
            this.tab_options.TabIndex = 11;
            // 
            // page_display
            // 
            this.page_display.Controls.Add(this.pan_output);
            this.page_display.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.page_display.Location = new System.Drawing.Point(4, 28);
            this.page_display.Name = "page_display";
            this.page_display.Padding = new System.Windows.Forms.Padding(3);
            this.page_display.Size = new System.Drawing.Size(354, 298);
            this.page_display.TabIndex = 0;
            this.page_display.Text = "Ausgabe-Optionen";
            this.page_display.UseVisualStyleBackColor = true;
            // 
            // pan_output
            // 
            this.pan_output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pan_output.Controls.Add(this.cob_negativeOutput);
            this.pan_output.Controls.Add(this.cob_positiveOutput);
            this.pan_output.Controls.Add(this.cob_outputElementNeg);
            this.pan_output.Controls.Add(this.lbl_negOutputElement);
            this.pan_output.Controls.Add(this.label7);
            this.pan_output.Controls.Add(this.cob_outputElementPos);
            this.pan_output.Controls.Add(this.lbl_negOutput_Title);
            this.pan_output.Controls.Add(this.chb_output);
            this.pan_output.Controls.Add(this.label8);
            this.pan_output.Controls.Add(this.label9);
            this.pan_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_output.Location = new System.Drawing.Point(3, 3);
            this.pan_output.Name = "pan_output";
            this.pan_output.Size = new System.Drawing.Size(348, 292);
            this.pan_output.TabIndex = 12;
            // 
            // cob_negativeOutput
            // 
            this.cob_negativeOutput.BackColor = System.Drawing.Color.White;
            this.cob_negativeOutput.Enabled = false;
            this.cob_negativeOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_negativeOutput.FormattingEnabled = true;
            this.cob_negativeOutput.Items.AddRange(new object[] {
            "Keine Ausgabe",
            "Schlüsselwort",
            "Text eingeben..."});
            this.cob_negativeOutput.Location = new System.Drawing.Point(15, 140);
            this.cob_negativeOutput.Name = "cob_negativeOutput";
            this.cob_negativeOutput.Size = new System.Drawing.Size(129, 23);
            this.cob_negativeOutput.TabIndex = 923;
            // 
            // cob_positiveOutput
            // 
            this.cob_positiveOutput.BackColor = System.Drawing.Color.White;
            this.cob_positiveOutput.Enabled = false;
            this.cob_positiveOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_positiveOutput.FormattingEnabled = true;
            this.cob_positiveOutput.Items.AddRange(new object[] {
            "Keine Ausgabe",
            "Schlüsselwort",
            "Text eingeben..."});
            this.cob_positiveOutput.Location = new System.Drawing.Point(15, 81);
            this.cob_positiveOutput.Name = "cob_positiveOutput";
            this.cob_positiveOutput.Size = new System.Drawing.Size(129, 23);
            this.cob_positiveOutput.TabIndex = 922;
            // 
            // cob_outputElementNeg
            // 
            this.cob_outputElementNeg.BackColor = System.Drawing.Color.White;
            this.cob_outputElementNeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_outputElementNeg.Enabled = false;
            this.cob_outputElementNeg.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_outputElementNeg.FormattingEnabled = true;
            this.cob_outputElementNeg.Location = new System.Drawing.Point(200, 140);
            this.cob_outputElementNeg.Name = "cob_outputElementNeg";
            this.cob_outputElementNeg.Size = new System.Drawing.Size(129, 23);
            this.cob_outputElementNeg.TabIndex = 921;
            // 
            // lbl_negOutputElement
            // 
            this.lbl_negOutputElement.AutoSize = true;
            this.lbl_negOutputElement.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_negOutputElement.Location = new System.Drawing.Point(195, 122);
            this.lbl_negOutputElement.Name = "lbl_negOutputElement";
            this.lbl_negOutputElement.Size = new System.Drawing.Size(79, 16);
            this.lbl_negOutputElement.TabIndex = 920;
            this.lbl_negOutputElement.Text = "auf Element...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label7.Location = new System.Drawing.Point(195, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 919;
            this.label7.Text = "auf Element...";
            // 
            // cob_outputElementPos
            // 
            this.cob_outputElementPos.BackColor = System.Drawing.Color.White;
            this.cob_outputElementPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_outputElementPos.Enabled = false;
            this.cob_outputElementPos.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_outputElementPos.FormattingEnabled = true;
            this.cob_outputElementPos.Location = new System.Drawing.Point(200, 81);
            this.cob_outputElementPos.Name = "cob_outputElementPos";
            this.cob_outputElementPos.Size = new System.Drawing.Size(129, 23);
            this.cob_outputElementPos.TabIndex = 918;
            // 
            // lbl_negOutput_Title
            // 
            this.lbl_negOutput_Title.AutoSize = true;
            this.lbl_negOutput_Title.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_negOutput_Title.Location = new System.Drawing.Point(10, 122);
            this.lbl_negOutput_Title.Name = "lbl_negOutput_Title";
            this.lbl_negOutput_Title.Size = new System.Drawing.Size(157, 16);
            this.lbl_negOutput_Title.TabIndex = 915;
            this.lbl_negOutput_Title.Text = "Ausgabe, wenn nicht zutrifft";
            // 
            // chb_output
            // 
            this.chb_output.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_output.BackColor = System.Drawing.SystemColors.Window;
            this.chb_output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_output.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.chb_output.Image = ((System.Drawing.Image)(resources.GetObject("chb_output.Image")));
            this.chb_output.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_output.Location = new System.Drawing.Point(15, 21);
            this.chb_output.Name = "chb_output";
            this.chb_output.Size = new System.Drawing.Size(129, 24);
            this.chb_output.TabIndex = 914;
            this.chb_output.Tag = "output";
            this.chb_output.Text = "Aktivieren";
            this.chb_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_output.UseVisualStyleBackColor = false;
            this.chb_output.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label8.Location = new System.Drawing.Point(10, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 900;
            this.label8.Text = "Aktivieren";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label9.Location = new System.Drawing.Point(10, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ausgabe, wenn zutrifft";
            // 
            // page_send
            // 
            this.page_send.Controls.Add(this.pan_send);
            this.page_send.Location = new System.Drawing.Point(4, 28);
            this.page_send.Name = "page_send";
            this.page_send.Padding = new System.Windows.Forms.Padding(3);
            this.page_send.Size = new System.Drawing.Size(354, 298);
            this.page_send.TabIndex = 1;
            this.page_send.Text = "Sende-Optionen";
            this.page_send.UseVisualStyleBackColor = true;
            // 
            // pan_send
            // 
            this.pan_send.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pan_send.Controls.Add(this.chb_sendIfNegative);
            this.pan_send.Controls.Add(this.chb_sendIfPositive);
            this.pan_send.Controls.Add(this.txt_sendIfNegative);
            this.pan_send.Controls.Add(this.lbl_sendNeg);
            this.pan_send.Controls.Add(this.chb_serialOption);
            this.pan_send.Controls.Add(this.label5);
            this.pan_send.Controls.Add(this.lbl_sendPos);
            this.pan_send.Controls.Add(this.txt_sendIfPositive);
            this.pan_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_send.Location = new System.Drawing.Point(3, 3);
            this.pan_send.Name = "pan_send";
            this.pan_send.Size = new System.Drawing.Size(348, 292);
            this.pan_send.TabIndex = 11;
            // 
            // chb_sendIfNegative
            // 
            this.chb_sendIfNegative.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_sendIfNegative.BackColor = System.Drawing.SystemColors.Window;
            this.chb_sendIfNegative.Enabled = false;
            this.chb_sendIfNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_sendIfNegative.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.chb_sendIfNegative.Image = ((System.Drawing.Image)(resources.GetObject("chb_sendIfNegative.Image")));
            this.chb_sendIfNegative.Location = new System.Drawing.Point(15, 139);
            this.chb_sendIfNegative.Name = "chb_sendIfNegative";
            this.chb_sendIfNegative.Size = new System.Drawing.Size(24, 24);
            this.chb_sendIfNegative.TabIndex = 918;
            this.chb_sendIfNegative.Tag = "send_neg";
            this.chb_sendIfNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_sendIfNegative.UseVisualStyleBackColor = false;
            this.chb_sendIfNegative.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // chb_sendIfPositive
            // 
            this.chb_sendIfPositive.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_sendIfPositive.BackColor = System.Drawing.SystemColors.Window;
            this.chb_sendIfPositive.Enabled = false;
            this.chb_sendIfPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_sendIfPositive.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.chb_sendIfPositive.Image = ((System.Drawing.Image)(resources.GetObject("chb_sendIfPositive.Image")));
            this.chb_sendIfPositive.Location = new System.Drawing.Point(15, 80);
            this.chb_sendIfPositive.Name = "chb_sendIfPositive";
            this.chb_sendIfPositive.Size = new System.Drawing.Size(24, 24);
            this.chb_sendIfPositive.TabIndex = 917;
            this.chb_sendIfPositive.Tag = "send_pos";
            this.chb_sendIfPositive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_sendIfPositive.UseVisualStyleBackColor = false;
            this.chb_sendIfPositive.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // txt_sendIfNegative
            // 
            this.txt_sendIfNegative.Enabled = false;
            this.txt_sendIfNegative.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sendIfNegative.Location = new System.Drawing.Point(45, 140);
            this.txt_sendIfNegative.Name = "txt_sendIfNegative";
            this.txt_sendIfNegative.Size = new System.Drawing.Size(284, 23);
            this.txt_sendIfNegative.TabIndex = 916;
            this.txt_sendIfNegative.Text = "< leer >";
            // 
            // lbl_sendNeg
            // 
            this.lbl_sendNeg.AutoSize = true;
            this.lbl_sendNeg.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_sendNeg.Location = new System.Drawing.Point(10, 122);
            this.lbl_sendNeg.Name = "lbl_sendNeg";
            this.lbl_sendNeg.Size = new System.Drawing.Size(143, 16);
            this.lbl_sendNeg.TabIndex = 915;
            this.lbl_sendNeg.Text = "Sende, wenn nicht zutrifft";
            // 
            // chb_serialOption
            // 
            this.chb_serialOption.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_serialOption.BackColor = System.Drawing.SystemColors.Window;
            this.chb_serialOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_serialOption.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.chb_serialOption.Image = ((System.Drawing.Image)(resources.GetObject("chb_serialOption.Image")));
            this.chb_serialOption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_serialOption.Location = new System.Drawing.Point(15, 21);
            this.chb_serialOption.Name = "chb_serialOption";
            this.chb_serialOption.Size = new System.Drawing.Size(129, 24);
            this.chb_serialOption.TabIndex = 914;
            this.chb_serialOption.Tag = "serial";
            this.chb_serialOption.Text = "Aktivieren";
            this.chb_serialOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_serialOption.UseVisualStyleBackColor = false;
            this.chb_serialOption.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(10, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 900;
            this.label5.Text = "Aktivieren";
            // 
            // lbl_sendPos
            // 
            this.lbl_sendPos.AutoSize = true;
            this.lbl_sendPos.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_sendPos.Location = new System.Drawing.Point(10, 64);
            this.lbl_sendPos.Name = "lbl_sendPos";
            this.lbl_sendPos.Size = new System.Drawing.Size(113, 16);
            this.lbl_sendPos.TabIndex = 15;
            this.lbl_sendPos.Text = "Sende, wenn zutrifft";
            // 
            // txt_sendIfPositive
            // 
            this.txt_sendIfPositive.Enabled = false;
            this.txt_sendIfPositive.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sendIfPositive.Location = new System.Drawing.Point(45, 81);
            this.txt_sendIfPositive.Name = "txt_sendIfPositive";
            this.txt_sendIfPositive.Size = new System.Drawing.Size(284, 23);
            this.txt_sendIfPositive.TabIndex = 2;
            this.txt_sendIfPositive.Text = "< leer >";
            // 
            // images_activate
            // 
            this.images_activate.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images_activate.ImageStream")));
            this.images_activate.TransparentColor = System.Drawing.Color.Transparent;
            this.images_activate.Images.SetKeyName(0, "dialog-ok.png");
            this.images_activate.Images.SetKeyName(1, "dialog-ok-apply.png");
            // 
            // Form_NewEditRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 346);
            this.Controls.Add(this.tab_options);
            this.Controls.Add(this.pan_workbench);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_NewEditRule";
            this.ShowIcon = false;
            this.Text = "Regeln";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_NewEditRule_FormClosing);
            this.Load += new System.EventHandler(this.Form_NewEditRule_Load);
            this.pan_workbench.ResumeLayout(false);
            this.pan_workbench.PerformLayout();
            this.tab_options.ResumeLayout(false);
            this.page_display.ResumeLayout(false);
            this.pan_output.ResumeLayout(false);
            this.pan_output.PerformLayout();
            this.page_send.ResumeLayout(false);
            this.pan_send.ResumeLayout(false);
            this.pan_send.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pan_workbench;
        public System.Windows.Forms.CheckBox chb_activate;
        public System.Windows.Forms.Button cmd_delete;
        public System.Windows.Forms.ListBox list_show;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_keyword;
        public System.Windows.Forms.Button cmd_save;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_list;
        public System.Windows.Forms.Label lbl_saveSettings;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbl_activate;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label title_workbench;
        public System.Windows.Forms.TabControl tab_options;
        public System.Windows.Forms.TabPage page_display;
        public System.Windows.Forms.TabPage page_send;
        public System.Windows.Forms.Panel pan_send;
        public System.Windows.Forms.TextBox txt_sendIfNegative;
        public System.Windows.Forms.Label lbl_sendNeg;
        public System.Windows.Forms.CheckBox chb_serialOption;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_sendPos;
        public System.Windows.Forms.TextBox txt_sendIfPositive;
        public System.Windows.Forms.Panel pan_output;
        public System.Windows.Forms.Label lbl_negOutput_Title;
        public System.Windows.Forms.CheckBox chb_output;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ImageList images_activate;
        public System.Windows.Forms.ComboBox cob_outputElementNeg;
        public System.Windows.Forms.Label lbl_negOutputElement;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cob_outputElementPos;
        public System.Windows.Forms.ComboBox cob_negativeOutput;
        public System.Windows.Forms.ComboBox cob_positiveOutput;
        public System.Windows.Forms.ComboBox cob_function;
        public System.Windows.Forms.CheckBox chb_sendIfNegative;
        public System.Windows.Forms.CheckBox chb_sendIfPositive;
        public System.Windows.Forms.ComboBox cob_CheckOperation;
    }
}