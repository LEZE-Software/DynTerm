namespace term
{
    partial class Form_CreateNewObject
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
            this.lbl_content = new System.Windows.Forms.Label();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.cmd_createObject = new System.Windows.Forms.Button();
            this.cob_chooseFunction = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_objectName = new System.Windows.Forms.TextBox();
            this.cob_objectType = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.grp_sizePosition = new System.Windows.Forms.GroupBox();
            this.pan_backColor = new System.Windows.Forms.Panel();
            this.cmd_preview = new System.Windows.Forms.Button();
            this.lbl_backColor = new System.Windows.Forms.Label();
            this.pan_textColor = new System.Windows.Forms.Panel();
            this.lbl_txtColor = new System.Windows.Forms.Label();
            this.grp_generals = new System.Windows.Forms.GroupBox();
            this.lbl_function = new System.Windows.Forms.Label();
            this.cob_hideObject = new System.Windows.Forms.ComboBox();
            this.tabC_object = new System.Windows.Forms.TabControl();
            this.page_label = new System.Windows.Forms.TabPage();
            this.grp_lblDisplayOptions = new System.Windows.Forms.GroupBox();
            this.rad_serialPortLabel = new System.Windows.Forms.RadioButton();
            this.rad_lblIndivContent = new System.Windows.Forms.RadioButton();
            this.page_Button = new System.Windows.Forms.TabPage();
            this.grp_chooseButtonAction = new System.Windows.Forms.GroupBox();
            this.txt_hardSetSerialAnswerSendOnButton = new System.Windows.Forms.TextBox();
            this.cob_sendSerialAction = new System.Windows.Forms.ComboBox();
            this.cob_sendSerialSource = new System.Windows.Forms.ComboBox();
            this.lbl_sendSerialFromSource = new System.Windows.Forms.Label();
            this.cob_objectToInsertIntoCombo = new System.Windows.Forms.ComboBox();
            this.lbl_addToComboSource = new System.Windows.Forms.Label();
            this.cob_insertIntoCombo = new System.Windows.Forms.ComboBox();
            this.rad_addItemToCombo = new System.Windows.Forms.RadioButton();
            this.rad_sendSerialOnClick = new System.Windows.Forms.RadioButton();
            this.rad_displayObjectOnClick = new System.Windows.Forms.RadioButton();
            this.rad_openPortOnClick = new System.Windows.Forms.RadioButton();
            this.page_comboBox = new System.Windows.Forms.TabPage();
            this.page_textBox = new System.Windows.Forms.TabPage();
            this.chb_textBoxIsReadOnly = new System.Windows.Forms.CheckBox();
            this.grp_sizePosition.SuspendLayout();
            this.grp_generals.SuspendLayout();
            this.tabC_object.SuspendLayout();
            this.page_label.SuspendLayout();
            this.grp_lblDisplayOptions.SuspendLayout();
            this.page_Button.SuspendLayout();
            this.grp_chooseButtonAction.SuspendLayout();
            this.page_textBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_content.Location = new System.Drawing.Point(9, 79);
            this.lbl_content.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(49, 14);
            this.lbl_content.TabIndex = 23;
            this.lbl_content.Tag = "";
            this.lbl_content.Text = "Inhalt:";
            // 
            // txt_content
            // 
            this.txt_content.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_content.Location = new System.Drawing.Point(146, 76);
            this.txt_content.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(141, 22);
            this.txt_content.TabIndex = 22;
            // 
            // cmd_createObject
            // 
            this.cmd_createObject.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_createObject.Location = new System.Drawing.Point(453, 524);
            this.cmd_createObject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_createObject.Name = "cmd_createObject";
            this.cmd_createObject.Size = new System.Drawing.Size(177, 25);
            this.cmd_createObject.TabIndex = 14;
            this.cmd_createObject.Text = "Objekt erstellen";
            this.cmd_createObject.UseVisualStyleBackColor = true;
            this.cmd_createObject.Click += new System.EventHandler(this.cmd_createObject_Click);
            // 
            // cob_chooseFunction
            // 
            this.cob_chooseFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_chooseFunction.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_chooseFunction.FormattingEnabled = true;
            this.cob_chooseFunction.Location = new System.Drawing.Point(146, 104);
            this.cob_chooseFunction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_chooseFunction.Name = "cob_chooseFunction";
            this.cob_chooseFunction.Size = new System.Drawing.Size(141, 22);
            this.cob_chooseFunction.TabIndex = 17;
            this.cob_chooseFunction.DropDown += new System.EventHandler(this.cob_chooseFunction_DropDown);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(9, 51);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(81, 14);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Tag = "";
            this.lbl_name.Text = "Bezeichner:";
            // 
            // txt_objectName
            // 
            this.txt_objectName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_objectName.Location = new System.Drawing.Point(146, 48);
            this.txt_objectName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_objectName.Name = "txt_objectName";
            this.txt_objectName.Size = new System.Drawing.Size(141, 22);
            this.txt_objectName.TabIndex = 15;
            // 
            // cob_objectType
            // 
            this.cob_objectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_objectType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_objectType.FormattingEnabled = true;
            this.cob_objectType.Items.AddRange(new object[] {
            "Label",
            "Button",
            "ComboBox",
            "Textbox"});
            this.cob_objectType.Location = new System.Drawing.Point(146, 20);
            this.cob_objectType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_objectType.Name = "cob_objectType";
            this.cob_objectType.Size = new System.Drawing.Size(141, 22);
            this.cob_objectType.TabIndex = 11;
            this.cob_objectType.SelectedIndexChanged += new System.EventHandler(this.cob_objectType_SelectedIndexChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(9, 23);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(74, 14);
            this.lbl_type.TabIndex = 1;
            this.lbl_type.Tag = "";
            this.lbl_type.Text = "Objekttyp:";
            // 
            // grp_sizePosition
            // 
            this.grp_sizePosition.Controls.Add(this.pan_backColor);
            this.grp_sizePosition.Controls.Add(this.cmd_preview);
            this.grp_sizePosition.Controls.Add(this.lbl_backColor);
            this.grp_sizePosition.Controls.Add(this.pan_textColor);
            this.grp_sizePosition.Controls.Add(this.lbl_txtColor);
            this.grp_sizePosition.Location = new System.Drawing.Point(343, 12);
            this.grp_sizePosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_sizePosition.Name = "grp_sizePosition";
            this.grp_sizePosition.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_sizePosition.Size = new System.Drawing.Size(295, 137);
            this.grp_sizePosition.TabIndex = 30;
            this.grp_sizePosition.TabStop = false;
            this.grp_sizePosition.Text = "Ansicht-Optionen";
            // 
            // pan_backColor
            // 
            this.pan_backColor.BackColor = System.Drawing.SystemColors.Control;
            this.pan_backColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_backColor.ForeColor = System.Drawing.SystemColors.Window;
            this.pan_backColor.Location = new System.Drawing.Point(84, 48);
            this.pan_backColor.Name = "pan_backColor";
            this.pan_backColor.Size = new System.Drawing.Size(52, 22);
            this.pan_backColor.TabIndex = 3;
            this.pan_backColor.Click += new System.EventHandler(this.pan_Color_Click);
            // 
            // cmd_preview
            // 
            this.cmd_preview.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_preview.Location = new System.Drawing.Point(148, 104);
            this.cmd_preview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_preview.Name = "cmd_preview";
            this.cmd_preview.Size = new System.Drawing.Size(142, 27);
            this.cmd_preview.TabIndex = 32;
            this.cmd_preview.Text = "Anzeigen";
            this.cmd_preview.UseVisualStyleBackColor = true;
            this.cmd_preview.Click += new System.EventHandler(this.cmd_preview_Click);
            // 
            // lbl_backColor
            // 
            this.lbl_backColor.AutoSize = true;
            this.lbl_backColor.Location = new System.Drawing.Point(7, 51);
            this.lbl_backColor.Name = "lbl_backColor";
            this.lbl_backColor.Size = new System.Drawing.Size(66, 14);
            this.lbl_backColor.TabIndex = 2;
            this.lbl_backColor.Text = "Füllfarbe:";
            // 
            // pan_textColor
            // 
            this.pan_textColor.BackColor = System.Drawing.Color.Black;
            this.pan_textColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_textColor.Location = new System.Drawing.Point(84, 20);
            this.pan_textColor.Name = "pan_textColor";
            this.pan_textColor.Size = new System.Drawing.Size(52, 22);
            this.pan_textColor.TabIndex = 1;
            this.pan_textColor.Click += new System.EventHandler(this.pan_Color_Click);
            // 
            // lbl_txtColor
            // 
            this.lbl_txtColor.AutoSize = true;
            this.lbl_txtColor.Location = new System.Drawing.Point(7, 23);
            this.lbl_txtColor.Name = "lbl_txtColor";
            this.lbl_txtColor.Size = new System.Drawing.Size(71, 14);
            this.lbl_txtColor.TabIndex = 0;
            this.lbl_txtColor.Text = "Textfarbe:";
            // 
            // grp_generals
            // 
            this.grp_generals.Controls.Add(this.lbl_function);
            this.grp_generals.Controls.Add(this.lbl_type);
            this.grp_generals.Controls.Add(this.lbl_name);
            this.grp_generals.Controls.Add(this.txt_objectName);
            this.grp_generals.Controls.Add(this.cob_chooseFunction);
            this.grp_generals.Controls.Add(this.txt_content);
            this.grp_generals.Controls.Add(this.cob_objectType);
            this.grp_generals.Controls.Add(this.lbl_content);
            this.grp_generals.Location = new System.Drawing.Point(12, 12);
            this.grp_generals.Name = "grp_generals";
            this.grp_generals.Size = new System.Drawing.Size(324, 137);
            this.grp_generals.TabIndex = 31;
            this.grp_generals.TabStop = false;
            this.grp_generals.Text = "Objektinformationen";
            // 
            // lbl_function
            // 
            this.lbl_function.AutoSize = true;
            this.lbl_function.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_function.Location = new System.Drawing.Point(9, 107);
            this.lbl_function.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_function.Name = "lbl_function";
            this.lbl_function.Size = new System.Drawing.Size(66, 14);
            this.lbl_function.TabIndex = 24;
            this.lbl_function.Tag = "";
            this.lbl_function.Text = "Funktion:";
            // 
            // cob_hideObject
            // 
            this.cob_hideObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_hideObject.Enabled = false;
            this.cob_hideObject.FormattingEnabled = true;
            this.cob_hideObject.Location = new System.Drawing.Point(215, 78);
            this.cob_hideObject.Name = "cob_hideObject";
            this.cob_hideObject.Size = new System.Drawing.Size(142, 22);
            this.cob_hideObject.TabIndex = 5;
            this.cob_hideObject.DropDown += new System.EventHandler(this.cob_chooseObjectToHide_DropDown);
            // 
            // tabC_object
            // 
            this.tabC_object.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabC_object.Controls.Add(this.page_label);
            this.tabC_object.Controls.Add(this.page_Button);
            this.tabC_object.Controls.Add(this.page_comboBox);
            this.tabC_object.Controls.Add(this.page_textBox);
            this.tabC_object.Location = new System.Drawing.Point(12, 212);
            this.tabC_object.Name = "tabC_object";
            this.tabC_object.SelectedIndex = 0;
            this.tabC_object.Size = new System.Drawing.Size(622, 306);
            this.tabC_object.TabIndex = 34;
            this.tabC_object.SelectedIndexChanged += new System.EventHandler(this.tabC_object_SelectedIndexChanged);
            // 
            // page_label
            // 
            this.page_label.BackColor = System.Drawing.SystemColors.Control;
            this.page_label.Controls.Add(this.grp_lblDisplayOptions);
            this.page_label.Location = new System.Drawing.Point(4, 26);
            this.page_label.Name = "page_label";
            this.page_label.Padding = new System.Windows.Forms.Padding(3);
            this.page_label.Size = new System.Drawing.Size(614, 276);
            this.page_label.TabIndex = 0;
            this.page_label.Text = "Label";
            // 
            // grp_lblDisplayOptions
            // 
            this.grp_lblDisplayOptions.Controls.Add(this.rad_serialPortLabel);
            this.grp_lblDisplayOptions.Controls.Add(this.rad_lblIndivContent);
            this.grp_lblDisplayOptions.Location = new System.Drawing.Point(6, 6);
            this.grp_lblDisplayOptions.Name = "grp_lblDisplayOptions";
            this.grp_lblDisplayOptions.Size = new System.Drawing.Size(602, 77);
            this.grp_lblDisplayOptions.TabIndex = 28;
            this.grp_lblDisplayOptions.TabStop = false;
            this.grp_lblDisplayOptions.Text = "Anzeige-Optionen";
            // 
            // rad_serialPortLabel
            // 
            this.rad_serialPortLabel.AutoSize = true;
            this.rad_serialPortLabel.Location = new System.Drawing.Point(6, 21);
            this.rad_serialPortLabel.Name = "rad_serialPortLabel";
            this.rad_serialPortLabel.Size = new System.Drawing.Size(159, 18);
            this.rad_serialPortLabel.TabIndex = 0;
            this.rad_serialPortLabel.Text = "Port-Status anzeigen";
            this.rad_serialPortLabel.UseVisualStyleBackColor = true;
            this.rad_serialPortLabel.CheckedChanged += new System.EventHandler(this.rad_labelUsage_CheckedChanged);
            // 
            // rad_lblIndivContent
            // 
            this.rad_lblIndivContent.AutoSize = true;
            this.rad_lblIndivContent.Checked = true;
            this.rad_lblIndivContent.Location = new System.Drawing.Point(6, 50);
            this.rad_lblIndivContent.Name = "rad_lblIndivContent";
            this.rad_lblIndivContent.Size = new System.Drawing.Size(179, 18);
            this.rad_lblIndivContent.TabIndex = 1;
            this.rad_lblIndivContent.TabStop = true;
            this.rad_lblIndivContent.Text = "Individuelle Beschriftung";
            this.rad_lblIndivContent.UseVisualStyleBackColor = true;
            // 
            // page_Button
            // 
            this.page_Button.BackColor = System.Drawing.SystemColors.Control;
            this.page_Button.Controls.Add(this.grp_chooseButtonAction);
            this.page_Button.Location = new System.Drawing.Point(4, 26);
            this.page_Button.Name = "page_Button";
            this.page_Button.Padding = new System.Windows.Forms.Padding(3);
            this.page_Button.Size = new System.Drawing.Size(614, 276);
            this.page_Button.TabIndex = 1;
            this.page_Button.Text = "Button";
            // 
            // grp_chooseButtonAction
            // 
            this.grp_chooseButtonAction.BackColor = System.Drawing.SystemColors.Control;
            this.grp_chooseButtonAction.Controls.Add(this.txt_hardSetSerialAnswerSendOnButton);
            this.grp_chooseButtonAction.Controls.Add(this.cob_sendSerialAction);
            this.grp_chooseButtonAction.Controls.Add(this.cob_sendSerialSource);
            this.grp_chooseButtonAction.Controls.Add(this.lbl_sendSerialFromSource);
            this.grp_chooseButtonAction.Controls.Add(this.cob_objectToInsertIntoCombo);
            this.grp_chooseButtonAction.Controls.Add(this.lbl_addToComboSource);
            this.grp_chooseButtonAction.Controls.Add(this.cob_insertIntoCombo);
            this.grp_chooseButtonAction.Controls.Add(this.rad_addItemToCombo);
            this.grp_chooseButtonAction.Controls.Add(this.rad_sendSerialOnClick);
            this.grp_chooseButtonAction.Controls.Add(this.rad_displayObjectOnClick);
            this.grp_chooseButtonAction.Controls.Add(this.cob_hideObject);
            this.grp_chooseButtonAction.Controls.Add(this.rad_openPortOnClick);
            this.grp_chooseButtonAction.Location = new System.Drawing.Point(6, 6);
            this.grp_chooseButtonAction.Name = "grp_chooseButtonAction";
            this.grp_chooseButtonAction.Size = new System.Drawing.Size(602, 137);
            this.grp_chooseButtonAction.TabIndex = 26;
            this.grp_chooseButtonAction.TabStop = false;
            this.grp_chooseButtonAction.Text = "Aktion bei Klick";
            // 
            // txt_hardSetSerialAnswerSendOnButton
            // 
            this.txt_hardSetSerialAnswerSendOnButton.Enabled = false;
            this.txt_hardSetSerialAnswerSendOnButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hardSetSerialAnswerSendOnButton.Location = new System.Drawing.Point(448, 49);
            this.txt_hardSetSerialAnswerSendOnButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_hardSetSerialAnswerSendOnButton.Name = "txt_hardSetSerialAnswerSendOnButton";
            this.txt_hardSetSerialAnswerSendOnButton.Size = new System.Drawing.Size(142, 22);
            this.txt_hardSetSerialAnswerSendOnButton.TabIndex = 25;
            // 
            // cob_sendSerialAction
            // 
            this.cob_sendSerialAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_sendSerialAction.Enabled = false;
            this.cob_sendSerialAction.FormattingEnabled = true;
            this.cob_sendSerialAction.Items.AddRange(new object[] {
            "Indiv. Eingabe",
            "Item aus ComboBox",
            "Textbox-Inhalt"});
            this.cob_sendSerialAction.Location = new System.Drawing.Point(215, 49);
            this.cob_sendSerialAction.Name = "cob_sendSerialAction";
            this.cob_sendSerialAction.Size = new System.Drawing.Size(142, 22);
            this.cob_sendSerialAction.TabIndex = 32;
            this.cob_sendSerialAction.SelectedIndexChanged += new System.EventHandler(this.cob_sendSerialChooseKind_SelectedIndexChanged);
            // 
            // cob_sendSerialSource
            // 
            this.cob_sendSerialSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_sendSerialSource.FormattingEnabled = true;
            this.cob_sendSerialSource.Location = new System.Drawing.Point(448, 49);
            this.cob_sendSerialSource.Name = "cob_sendSerialSource";
            this.cob_sendSerialSource.Size = new System.Drawing.Size(142, 22);
            this.cob_sendSerialSource.TabIndex = 31;
            // 
            // lbl_sendSerialFromSource
            // 
            this.lbl_sendSerialFromSource.AutoSize = true;
            this.lbl_sendSerialFromSource.Location = new System.Drawing.Point(363, 52);
            this.lbl_sendSerialFromSource.Name = "lbl_sendSerialFromSource";
            this.lbl_sendSerialFromSource.Size = new System.Drawing.Size(79, 14);
            this.lbl_sendSerialFromSource.TabIndex = 30;
            this.lbl_sendSerialFromSource.Text = "aus Quelle:";
            // 
            // cob_objectToInsertIntoCombo
            // 
            this.cob_objectToInsertIntoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_objectToInsertIntoCombo.Enabled = false;
            this.cob_objectToInsertIntoCombo.FormattingEnabled = true;
            this.cob_objectToInsertIntoCombo.Location = new System.Drawing.Point(448, 107);
            this.cob_objectToInsertIntoCombo.Name = "cob_objectToInsertIntoCombo";
            this.cob_objectToInsertIntoCombo.Size = new System.Drawing.Size(142, 22);
            this.cob_objectToInsertIntoCombo.TabIndex = 29;
            // 
            // lbl_addToComboSource
            // 
            this.lbl_addToComboSource.AutoSize = true;
            this.lbl_addToComboSource.Location = new System.Drawing.Point(363, 110);
            this.lbl_addToComboSource.Name = "lbl_addToComboSource";
            this.lbl_addToComboSource.Size = new System.Drawing.Size(79, 14);
            this.lbl_addToComboSource.TabIndex = 28;
            this.lbl_addToComboSource.Text = "aus Quelle:";
            // 
            // cob_insertIntoCombo
            // 
            this.cob_insertIntoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_insertIntoCombo.Enabled = false;
            this.cob_insertIntoCombo.FormattingEnabled = true;
            this.cob_insertIntoCombo.Location = new System.Drawing.Point(215, 107);
            this.cob_insertIntoCombo.Name = "cob_insertIntoCombo";
            this.cob_insertIntoCombo.Size = new System.Drawing.Size(142, 22);
            this.cob_insertIntoCombo.TabIndex = 27;
            // 
            // rad_addItemToCombo
            // 
            this.rad_addItemToCombo.AutoSize = true;
            this.rad_addItemToCombo.Location = new System.Drawing.Point(6, 108);
            this.rad_addItemToCombo.Name = "rad_addItemToCombo";
            this.rad_addItemToCombo.Size = new System.Drawing.Size(165, 18);
            this.rad_addItemToCombo.TabIndex = 26;
            this.rad_addItemToCombo.Tag = "3";
            this.rad_addItemToCombo.Text = "Füge in ComboBox ein";
            this.rad_addItemToCombo.UseVisualStyleBackColor = true;
            this.rad_addItemToCombo.CheckedChanged += new System.EventHandler(this.rad_buttonAction_CheckedChanged);
            // 
            // rad_sendSerialOnClick
            // 
            this.rad_sendSerialOnClick.AutoSize = true;
            this.rad_sendSerialOnClick.Location = new System.Drawing.Point(6, 50);
            this.rad_sendSerialOnClick.Name = "rad_sendSerialOnClick";
            this.rad_sendSerialOnClick.Size = new System.Drawing.Size(111, 18);
            this.rad_sendSerialOnClick.TabIndex = 2;
            this.rad_sendSerialOnClick.Tag = "1";
            this.rad_sendSerialOnClick.Text = "Serial senden";
            this.rad_sendSerialOnClick.UseVisualStyleBackColor = true;
            this.rad_sendSerialOnClick.CheckedChanged += new System.EventHandler(this.rad_buttonAction_CheckedChanged);
            // 
            // rad_displayObjectOnClick
            // 
            this.rad_displayObjectOnClick.AutoSize = true;
            this.rad_displayObjectOnClick.Location = new System.Drawing.Point(6, 79);
            this.rad_displayObjectOnClick.Name = "rad_displayObjectOnClick";
            this.rad_displayObjectOnClick.Size = new System.Drawing.Size(203, 18);
            this.rad_displayObjectOnClick.TabIndex = 1;
            this.rad_displayObjectOnClick.Tag = "2";
            this.rad_displayObjectOnClick.Text = "Objekt anzeigen/verstecken";
            this.rad_displayObjectOnClick.UseVisualStyleBackColor = true;
            this.rad_displayObjectOnClick.CheckedChanged += new System.EventHandler(this.rad_buttonAction_CheckedChanged);
            // 
            // rad_openPortOnClick
            // 
            this.rad_openPortOnClick.AutoSize = true;
            this.rad_openPortOnClick.Checked = true;
            this.rad_openPortOnClick.Location = new System.Drawing.Point(6, 21);
            this.rad_openPortOnClick.Name = "rad_openPortOnClick";
            this.rad_openPortOnClick.Size = new System.Drawing.Size(158, 18);
            this.rad_openPortOnClick.TabIndex = 0;
            this.rad_openPortOnClick.TabStop = true;
            this.rad_openPortOnClick.Tag = "0";
            this.rad_openPortOnClick.Text = "Port öffnen/schließen";
            this.rad_openPortOnClick.UseVisualStyleBackColor = true;
            this.rad_openPortOnClick.CheckedChanged += new System.EventHandler(this.rad_buttonAction_CheckedChanged);
            // 
            // page_comboBox
            // 
            this.page_comboBox.BackColor = System.Drawing.SystemColors.Control;
            this.page_comboBox.Location = new System.Drawing.Point(4, 26);
            this.page_comboBox.Name = "page_comboBox";
            this.page_comboBox.Padding = new System.Windows.Forms.Padding(3);
            this.page_comboBox.Size = new System.Drawing.Size(614, 276);
            this.page_comboBox.TabIndex = 2;
            this.page_comboBox.Text = "ComboBox";
            // 
            // page_textBox
            // 
            this.page_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.page_textBox.Controls.Add(this.chb_textBoxIsReadOnly);
            this.page_textBox.Location = new System.Drawing.Point(4, 26);
            this.page_textBox.Name = "page_textBox";
            this.page_textBox.Padding = new System.Windows.Forms.Padding(3);
            this.page_textBox.Size = new System.Drawing.Size(614, 276);
            this.page_textBox.TabIndex = 3;
            this.page_textBox.Text = "Textbox";
            // 
            // chb_textBoxIsReadOnly
            // 
            this.chb_textBoxIsReadOnly.AutoSize = true;
            this.chb_textBoxIsReadOnly.Location = new System.Drawing.Point(9, 9);
            this.chb_textBoxIsReadOnly.Name = "chb_textBoxIsReadOnly";
            this.chb_textBoxIsReadOnly.Size = new System.Drawing.Size(193, 18);
            this.chb_textBoxIsReadOnly.TabIndex = 1;
            this.chb_textBoxIsReadOnly.Text = "Keine Bearbeitung möglich";
            this.chb_textBoxIsReadOnly.UseVisualStyleBackColor = true;
            // 
            // Form_CreateNewObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 561);
            this.Controls.Add(this.tabC_object);
            this.Controls.Add(this.grp_generals);
            this.Controls.Add(this.grp_sizePosition);
            this.Controls.Add(this.cmd_createObject);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_CreateNewObject";
            this.Text = "Neues Objekt erstellen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CreateNewObject_FormClosing);
            this.grp_sizePosition.ResumeLayout(false);
            this.grp_sizePosition.PerformLayout();
            this.grp_generals.ResumeLayout(false);
            this.grp_generals.PerformLayout();
            this.tabC_object.ResumeLayout(false);
            this.page_label.ResumeLayout(false);
            this.grp_lblDisplayOptions.ResumeLayout(false);
            this.grp_lblDisplayOptions.PerformLayout();
            this.page_Button.ResumeLayout(false);
            this.grp_chooseButtonAction.ResumeLayout(false);
            this.grp_chooseButtonAction.PerformLayout();
            this.page_textBox.ResumeLayout(false);
            this.page_textBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.Button cmd_createObject;
        private System.Windows.Forms.ComboBox cob_chooseFunction;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_objectName;
        private System.Windows.Forms.ComboBox cob_objectType;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.GroupBox grp_sizePosition;
        private System.Windows.Forms.GroupBox grp_generals;
        private System.Windows.Forms.Label lbl_function;
        private System.Windows.Forms.Button cmd_preview;
        private System.Windows.Forms.Panel pan_textColor;
        private System.Windows.Forms.Label lbl_txtColor;
        private System.Windows.Forms.ComboBox cob_hideObject;
        private System.Windows.Forms.Panel pan_backColor;
        private System.Windows.Forms.Label lbl_backColor;
        private System.Windows.Forms.TabControl tabC_object;
        private System.Windows.Forms.TabPage page_label;
        private System.Windows.Forms.TabPage page_Button;
        private System.Windows.Forms.GroupBox grp_chooseButtonAction;
        private System.Windows.Forms.ComboBox cob_objectToInsertIntoCombo;
        private System.Windows.Forms.Label lbl_addToComboSource;
        private System.Windows.Forms.ComboBox cob_insertIntoCombo;
        private System.Windows.Forms.RadioButton rad_addItemToCombo;
        private System.Windows.Forms.RadioButton rad_sendSerialOnClick;
        private System.Windows.Forms.RadioButton rad_displayObjectOnClick;
        private System.Windows.Forms.RadioButton rad_openPortOnClick;
        private System.Windows.Forms.TabPage page_comboBox;
        private System.Windows.Forms.TabPage page_textBox;
        private System.Windows.Forms.CheckBox chb_textBoxIsReadOnly;
        private System.Windows.Forms.ComboBox cob_sendSerialAction;
        private System.Windows.Forms.ComboBox cob_sendSerialSource;
        private System.Windows.Forms.Label lbl_sendSerialFromSource;
        private System.Windows.Forms.TextBox txt_hardSetSerialAnswerSendOnButton;
        private System.Windows.Forms.RadioButton rad_lblIndivContent;
        private System.Windows.Forms.RadioButton rad_serialPortLabel;
        private System.Windows.Forms.GroupBox grp_lblDisplayOptions;
    }
}