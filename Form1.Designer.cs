namespace Game
{
    partial class Form1
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
            this.pan_field1 = new System.Windows.Forms.Panel();
            this.lbl_newObjectFunction = new System.Windows.Forms.Label();
            this.lbl_newObjectType_A = new System.Windows.Forms.Label();
            this.lbl_newFunctionName_A = new System.Windows.Forms.Label();
            this.txt_newRuleKeyword = new System.Windows.Forms.TextBox();
            this.lbl_keyword = new System.Windows.Forms.Label();
            this.txt_newRuleDisplayText = new System.Windows.Forms.TextBox();
            this.lbl_displayText = new System.Windows.Forms.Label();
            this.cob_newRuleChooseFunction = new System.Windows.Forms.ComboBox();
            this.cmd_addNewFunction = new System.Windows.Forms.Button();
            this.cmd_openPort = new System.Windows.Forms.Button();
            this.cmd_closePort = new System.Windows.Forms.Button();
            this.grp_serialPort = new System.Windows.Forms.GroupBox();
            this.cmd_addSimSerialAnswer = new System.Windows.Forms.Button();
            this.lbl_simulateSerialInput_A = new System.Windows.Forms.Label();
            this.txt_simSerialInput = new System.Windows.Forms.TextBox();
            this.pan_workspace = new System.Windows.Forms.Panel();
            this.lbl_preview = new System.Windows.Forms.Label();
            this.cob_newObjectType = new System.Windows.Forms.ComboBox();
            this.grp_editFunctions = new System.Windows.Forms.GroupBox();
            this.cmd_createFunction = new System.Windows.Forms.Button();
            this.txt_newFunctionName = new System.Windows.Forms.TextBox();
            this.grp_createVisObject = new System.Windows.Forms.GroupBox();
            this.lbl_newObjectContent_A = new System.Windows.Forms.Label();
            this.txt_newObjectContent = new System.Windows.Forms.TextBox();
            this.lbl_newObject_posX_A = new System.Windows.Forms.Label();
            this.lbl_newObject_yPos_A = new System.Windows.Forms.Label();
            this.txt_newObject_xPos = new System.Windows.Forms.TextBox();
            this.txt_newObject_yPos = new System.Windows.Forms.TextBox();
            this.cob_newObjectFunction = new System.Windows.Forms.ComboBox();
            this.lbl_newObjectName_A = new System.Windows.Forms.Label();
            this.txt_newObjectName = new System.Windows.Forms.TextBox();
            this.cmd_createNewObject = new System.Windows.Forms.Button();
            this.grp_createRules = new System.Windows.Forms.GroupBox();
            this.cmd_newRuleDisplayKeyword = new System.Windows.Forms.Button();
            this.lbl_newRuleChooseDisplayOperation_A = new System.Windows.Forms.Label();
            this.lbl_newRuleChooseOperation_A = new System.Windows.Forms.Label();
            this.cob_newRule_chooseOperation = new System.Windows.Forms.ComboBox();
            this.lbl_newRuleChooseObejct_A = new System.Windows.Forms.Label();
            this.cob_newRuleChooseObject = new System.Windows.Forms.ComboBox();
            this.lbl_newRuleChooseFunction_A = new System.Windows.Forms.Label();
            this.chb_newObjectDisplayObject = new System.Windows.Forms.CheckBox();
            this.grp_serialPort.SuspendLayout();
            this.pan_workspace.SuspendLayout();
            this.grp_editFunctions.SuspendLayout();
            this.grp_createVisObject.SuspendLayout();
            this.grp_createRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_field1
            // 
            this.pan_field1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pan_field1.Location = new System.Drawing.Point(12, 12);
            this.pan_field1.Name = "pan_field1";
            this.pan_field1.Size = new System.Drawing.Size(218, 218);
            this.pan_field1.TabIndex = 0;
            this.pan_field1.MouseHover += new System.EventHandler(this.pan_field_MouseOver);
            // 
            // lbl_newObjectFunction
            // 
            this.lbl_newObjectFunction.AutoSize = true;
            this.lbl_newObjectFunction.Location = new System.Drawing.Point(6, 75);
            this.lbl_newObjectFunction.Name = "lbl_newObjectFunction";
            this.lbl_newObjectFunction.Size = new System.Drawing.Size(51, 13);
            this.lbl_newObjectFunction.TabIndex = 2;
            this.lbl_newObjectFunction.Tag = "";
            this.lbl_newObjectFunction.Text = "Funktion:";
            // 
            // lbl_newObjectType_A
            // 
            this.lbl_newObjectType_A.AutoSize = true;
            this.lbl_newObjectType_A.Location = new System.Drawing.Point(6, 22);
            this.lbl_newObjectType_A.Name = "lbl_newObjectType_A";
            this.lbl_newObjectType_A.Size = new System.Drawing.Size(55, 13);
            this.lbl_newObjectType_A.TabIndex = 1;
            this.lbl_newObjectType_A.Tag = "";
            this.lbl_newObjectType_A.Text = "Objekttyp:";
            // 
            // lbl_newFunctionName_A
            // 
            this.lbl_newFunctionName_A.AutoSize = true;
            this.lbl_newFunctionName_A.Location = new System.Drawing.Point(6, 16);
            this.lbl_newFunctionName_A.Name = "lbl_newFunctionName_A";
            this.lbl_newFunctionName_A.Size = new System.Drawing.Size(130, 13);
            this.lbl_newFunctionName_A.TabIndex = 0;
            this.lbl_newFunctionName_A.Tag = "func1";
            this.lbl_newFunctionName_A.Text = "Name der neuen Funktion";
            // 
            // txt_newRuleKeyword
            // 
            this.txt_newRuleKeyword.Location = new System.Drawing.Point(9, 32);
            this.txt_newRuleKeyword.Name = "txt_newRuleKeyword";
            this.txt_newRuleKeyword.Size = new System.Drawing.Size(100, 20);
            this.txt_newRuleKeyword.TabIndex = 1;
            // 
            // lbl_keyword
            // 
            this.lbl_keyword.AutoSize = true;
            this.lbl_keyword.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_keyword.Location = new System.Drawing.Point(6, 16);
            this.lbl_keyword.Name = "lbl_keyword";
            this.lbl_keyword.Size = new System.Drawing.Size(51, 13);
            this.lbl_keyword.TabIndex = 2;
            this.lbl_keyword.Text = "Keyword.";
            // 
            // txt_newRuleDisplayText
            // 
            this.txt_newRuleDisplayText.Location = new System.Drawing.Point(146, 32);
            this.txt_newRuleDisplayText.Name = "txt_newRuleDisplayText";
            this.txt_newRuleDisplayText.Size = new System.Drawing.Size(100, 20);
            this.txt_newRuleDisplayText.TabIndex = 3;
            // 
            // lbl_displayText
            // 
            this.lbl_displayText.AutoSize = true;
            this.lbl_displayText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_displayText.Location = new System.Drawing.Point(143, 16);
            this.lbl_displayText.Name = "lbl_displayText";
            this.lbl_displayText.Size = new System.Drawing.Size(65, 13);
            this.lbl_displayText.TabIndex = 4;
            this.lbl_displayText.Text = "Anzeigetext:";
            // 
            // cob_newRuleChooseFunction
            // 
            this.cob_newRuleChooseFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_newRuleChooseFunction.FormattingEnabled = true;
            this.cob_newRuleChooseFunction.Location = new System.Drawing.Point(6, 73);
            this.cob_newRuleChooseFunction.Name = "cob_newRuleChooseFunction";
            this.cob_newRuleChooseFunction.Size = new System.Drawing.Size(103, 21);
            this.cob_newRuleChooseFunction.TabIndex = 5;
            this.cob_newRuleChooseFunction.DropDown += new System.EventHandler(this.cob_chooseFunction_DropDown);
            this.cob_newRuleChooseFunction.SelectedIndexChanged += new System.EventHandler(this.cob_newRuleChooseFunction_SelectedIndexChanged);
            // 
            // cmd_addNewFunction
            // 
            this.cmd_addNewFunction.Location = new System.Drawing.Point(143, 164);
            this.cmd_addNewFunction.Name = "cmd_addNewFunction";
            this.cmd_addNewFunction.Size = new System.Drawing.Size(100, 23);
            this.cmd_addNewFunction.TabIndex = 6;
            this.cmd_addNewFunction.Text = "Hinzufügen";
            this.cmd_addNewFunction.UseVisualStyleBackColor = true;
            this.cmd_addNewFunction.Click += new System.EventHandler(this.cmd_addNewRule_Click);
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
            this.cmd_closePort.Location = new System.Drawing.Point(137, 19);
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
            this.grp_serialPort.Location = new System.Drawing.Point(12, 245);
            this.grp_serialPort.Name = "grp_serialPort";
            this.grp_serialPort.Size = new System.Drawing.Size(218, 132);
            this.grp_serialPort.TabIndex = 9;
            this.grp_serialPort.TabStop = false;
            this.grp_serialPort.Text = "Serielle Schnittstelle";
            // 
            // cmd_addSimSerialAnswer
            // 
            this.cmd_addSimSerialAnswer.Location = new System.Drawing.Point(137, 99);
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
            this.txt_simSerialInput.Size = new System.Drawing.Size(206, 20);
            this.txt_simSerialInput.TabIndex = 10;
            // 
            // pan_workspace
            // 
            this.pan_workspace.Controls.Add(this.lbl_preview);
            this.pan_workspace.Location = new System.Drawing.Point(236, 12);
            this.pan_workspace.Name = "pan_workspace";
            this.pan_workspace.Size = new System.Drawing.Size(257, 218);
            this.pan_workspace.TabIndex = 10;
            // 
            // lbl_preview
            // 
            this.lbl_preview.AutoSize = true;
            this.lbl_preview.Location = new System.Drawing.Point(6, 16);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(52, 13);
            this.lbl_preview.TabIndex = 0;
            this.lbl_preview.Text = "Vorschau";
            this.lbl_preview.Visible = false;
            // 
            // cob_newObjectType
            // 
            this.cob_newObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_newObjectType.FormattingEnabled = true;
            this.cob_newObjectType.Items.AddRange(new object[] {
            "Label"});
            this.cob_newObjectType.Location = new System.Drawing.Point(70, 19);
            this.cob_newObjectType.Name = "cob_newObjectType";
            this.cob_newObjectType.Size = new System.Drawing.Size(124, 21);
            this.cob_newObjectType.TabIndex = 11;
            // 
            // grp_editFunctions
            // 
            this.grp_editFunctions.Controls.Add(this.cmd_createFunction);
            this.grp_editFunctions.Controls.Add(this.txt_newFunctionName);
            this.grp_editFunctions.Controls.Add(this.lbl_newFunctionName_A);
            this.grp_editFunctions.Location = new System.Drawing.Point(499, 12);
            this.grp_editFunctions.Name = "grp_editFunctions";
            this.grp_editFunctions.Size = new System.Drawing.Size(200, 100);
            this.grp_editFunctions.TabIndex = 12;
            this.grp_editFunctions.TabStop = false;
            this.grp_editFunctions.Text = "Funktionen";
            // 
            // cmd_createFunction
            // 
            this.cmd_createFunction.Location = new System.Drawing.Point(119, 71);
            this.cmd_createFunction.Name = "cmd_createFunction";
            this.cmd_createFunction.Size = new System.Drawing.Size(75, 23);
            this.cmd_createFunction.TabIndex = 1;
            this.cmd_createFunction.Text = "Erstellen";
            this.cmd_createFunction.UseVisualStyleBackColor = true;
            this.cmd_createFunction.Click += new System.EventHandler(this.cmd_createFunction_Click);
            // 
            // txt_newFunctionName
            // 
            this.txt_newFunctionName.Location = new System.Drawing.Point(9, 32);
            this.txt_newFunctionName.Name = "txt_newFunctionName";
            this.txt_newFunctionName.Size = new System.Drawing.Size(127, 20);
            this.txt_newFunctionName.TabIndex = 0;
            // 
            // grp_createVisObject
            // 
            this.grp_createVisObject.Controls.Add(this.chb_newObjectDisplayObject);
            this.grp_createVisObject.Controls.Add(this.lbl_newObjectContent_A);
            this.grp_createVisObject.Controls.Add(this.txt_newObjectContent);
            this.grp_createVisObject.Controls.Add(this.lbl_newObject_posX_A);
            this.grp_createVisObject.Controls.Add(this.lbl_newObject_yPos_A);
            this.grp_createVisObject.Controls.Add(this.txt_newObject_xPos);
            this.grp_createVisObject.Controls.Add(this.txt_newObject_yPos);
            this.grp_createVisObject.Controls.Add(this.cob_newObjectFunction);
            this.grp_createVisObject.Controls.Add(this.lbl_newObjectName_A);
            this.grp_createVisObject.Controls.Add(this.txt_newObjectName);
            this.grp_createVisObject.Controls.Add(this.lbl_newObjectFunction);
            this.grp_createVisObject.Controls.Add(this.cmd_createNewObject);
            this.grp_createVisObject.Controls.Add(this.cob_newObjectType);
            this.grp_createVisObject.Controls.Add(this.lbl_newObjectType_A);
            this.grp_createVisObject.Location = new System.Drawing.Point(499, 118);
            this.grp_createVisObject.Name = "grp_createVisObject";
            this.grp_createVisObject.Size = new System.Drawing.Size(200, 220);
            this.grp_createVisObject.TabIndex = 13;
            this.grp_createVisObject.TabStop = false;
            this.grp_createVisObject.Text = "Objekte erstellen";
            this.grp_createVisObject.Enter += new System.EventHandler(this.grp_createVisObject_Enter);
            // 
            // lbl_newObjectContent_A
            // 
            this.lbl_newObjectContent_A.AutoSize = true;
            this.lbl_newObjectContent_A.Location = new System.Drawing.Point(6, 102);
            this.lbl_newObjectContent_A.Name = "lbl_newObjectContent_A";
            this.lbl_newObjectContent_A.Size = new System.Drawing.Size(36, 13);
            this.lbl_newObjectContent_A.TabIndex = 23;
            this.lbl_newObjectContent_A.Tag = "";
            this.lbl_newObjectContent_A.Text = "Inhalt:";
            // 
            // txt_newObjectContent
            // 
            this.txt_newObjectContent.Location = new System.Drawing.Point(70, 99);
            this.txt_newObjectContent.Name = "txt_newObjectContent";
            this.txt_newObjectContent.Size = new System.Drawing.Size(124, 20);
            this.txt_newObjectContent.TabIndex = 22;
            // 
            // lbl_newObject_posX_A
            // 
            this.lbl_newObject_posX_A.AutoSize = true;
            this.lbl_newObject_posX_A.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_newObject_posX_A.Location = new System.Drawing.Point(7, 128);
            this.lbl_newObject_posX_A.Name = "lbl_newObject_posX_A";
            this.lbl_newObject_posX_A.Size = new System.Drawing.Size(54, 13);
            this.lbl_newObject_posX_A.TabIndex = 21;
            this.lbl_newObject_posX_A.Text = "X-Position";
            // 
            // lbl_newObject_yPos_A
            // 
            this.lbl_newObject_yPos_A.AutoSize = true;
            this.lbl_newObject_yPos_A.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_newObject_yPos_A.Location = new System.Drawing.Point(7, 154);
            this.lbl_newObject_yPos_A.Name = "lbl_newObject_yPos_A";
            this.lbl_newObject_yPos_A.Size = new System.Drawing.Size(54, 13);
            this.lbl_newObject_yPos_A.TabIndex = 20;
            this.lbl_newObject_yPos_A.Text = "Y-Position";
            // 
            // txt_newObject_xPos
            // 
            this.txt_newObject_xPos.Location = new System.Drawing.Point(70, 125);
            this.txt_newObject_xPos.Name = "txt_newObject_xPos";
            this.txt_newObject_xPos.Size = new System.Drawing.Size(40, 20);
            this.txt_newObject_xPos.TabIndex = 19;
            this.txt_newObject_xPos.Text = "10";
            this.txt_newObject_xPos.TextChanged += new System.EventHandler(this.txt_newObject_yPos_TextChanged);
            // 
            // txt_newObject_yPos
            // 
            this.txt_newObject_yPos.Location = new System.Drawing.Point(70, 151);
            this.txt_newObject_yPos.Name = "txt_newObject_yPos";
            this.txt_newObject_yPos.Size = new System.Drawing.Size(40, 20);
            this.txt_newObject_yPos.TabIndex = 18;
            this.txt_newObject_yPos.Text = "10";
            this.txt_newObject_yPos.TextChanged += new System.EventHandler(this.txt_newObject_yPos_TextChanged);
            // 
            // cob_newObjectFunction
            // 
            this.cob_newObjectFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_newObjectFunction.FormattingEnabled = true;
            this.cob_newObjectFunction.Location = new System.Drawing.Point(70, 72);
            this.cob_newObjectFunction.Name = "cob_newObjectFunction";
            this.cob_newObjectFunction.Size = new System.Drawing.Size(124, 21);
            this.cob_newObjectFunction.TabIndex = 17;
            this.cob_newObjectFunction.DropDown += new System.EventHandler(this.cob_chooseFunction_DropDown);
            // 
            // lbl_newObjectName_A
            // 
            this.lbl_newObjectName_A.AutoSize = true;
            this.lbl_newObjectName_A.Location = new System.Drawing.Point(6, 49);
            this.lbl_newObjectName_A.Name = "lbl_newObjectName_A";
            this.lbl_newObjectName_A.Size = new System.Drawing.Size(60, 13);
            this.lbl_newObjectName_A.TabIndex = 16;
            this.lbl_newObjectName_A.Tag = "";
            this.lbl_newObjectName_A.Text = "Bezeichner";
            // 
            // txt_newObjectName
            // 
            this.txt_newObjectName.Location = new System.Drawing.Point(70, 46);
            this.txt_newObjectName.Name = "txt_newObjectName";
            this.txt_newObjectName.Size = new System.Drawing.Size(124, 20);
            this.txt_newObjectName.TabIndex = 15;
            // 
            // cmd_createNewObject
            // 
            this.cmd_createNewObject.Location = new System.Drawing.Point(119, 148);
            this.cmd_createNewObject.Name = "cmd_createNewObject";
            this.cmd_createNewObject.Size = new System.Drawing.Size(75, 23);
            this.cmd_createNewObject.TabIndex = 14;
            this.cmd_createNewObject.Text = "Erstellen";
            this.cmd_createNewObject.UseVisualStyleBackColor = true;
            this.cmd_createNewObject.Click += new System.EventHandler(this.cmd_createNewObject_Click);
            // 
            // grp_createRules
            // 
            this.grp_createRules.Controls.Add(this.cmd_newRuleDisplayKeyword);
            this.grp_createRules.Controls.Add(this.lbl_newRuleChooseDisplayOperation_A);
            this.grp_createRules.Controls.Add(this.lbl_newRuleChooseOperation_A);
            this.grp_createRules.Controls.Add(this.cob_newRule_chooseOperation);
            this.grp_createRules.Controls.Add(this.lbl_newRuleChooseObejct_A);
            this.grp_createRules.Controls.Add(this.cob_newRuleChooseObject);
            this.grp_createRules.Controls.Add(this.cmd_addNewFunction);
            this.grp_createRules.Controls.Add(this.lbl_newRuleChooseFunction_A);
            this.grp_createRules.Controls.Add(this.lbl_keyword);
            this.grp_createRules.Controls.Add(this.txt_newRuleKeyword);
            this.grp_createRules.Controls.Add(this.txt_newRuleDisplayText);
            this.grp_createRules.Controls.Add(this.lbl_displayText);
            this.grp_createRules.Controls.Add(this.cob_newRuleChooseFunction);
            this.grp_createRules.Location = new System.Drawing.Point(236, 245);
            this.grp_createRules.Name = "grp_createRules";
            this.grp_createRules.Size = new System.Drawing.Size(257, 193);
            this.grp_createRules.TabIndex = 14;
            this.grp_createRules.TabStop = false;
            this.grp_createRules.Text = " ";
            // 
            // cmd_newRuleDisplayKeyword
            // 
            this.cmd_newRuleDisplayKeyword.Location = new System.Drawing.Point(143, 121);
            this.cmd_newRuleDisplayKeyword.Name = "cmd_newRuleDisplayKeyword";
            this.cmd_newRuleDisplayKeyword.Size = new System.Drawing.Size(103, 21);
            this.cmd_newRuleDisplayKeyword.TabIndex = 14;
            this.cmd_newRuleDisplayKeyword.Text = "Anzeigetext";
            this.cmd_newRuleDisplayKeyword.UseVisualStyleBackColor = true;
            this.cmd_newRuleDisplayKeyword.Click += new System.EventHandler(this.cmd_newRuleDisplayKeyword_Click);
            // 
            // lbl_newRuleChooseDisplayOperation_A
            // 
            this.lbl_newRuleChooseDisplayOperation_A.AutoSize = true;
            this.lbl_newRuleChooseDisplayOperation_A.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_newRuleChooseDisplayOperation_A.Location = new System.Drawing.Point(143, 105);
            this.lbl_newRuleChooseDisplayOperation_A.Name = "lbl_newRuleChooseDisplayOperation_A";
            this.lbl_newRuleChooseDisplayOperation_A.Size = new System.Drawing.Size(76, 13);
            this.lbl_newRuleChooseDisplayOperation_A.TabIndex = 13;
            this.lbl_newRuleChooseDisplayOperation_A.Text = "Angezeigt wird";
            // 
            // lbl_newRuleChooseOperation_A
            // 
            this.lbl_newRuleChooseOperation_A.AutoSize = true;
            this.lbl_newRuleChooseOperation_A.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_newRuleChooseOperation_A.Location = new System.Drawing.Point(6, 105);
            this.lbl_newRuleChooseOperation_A.Name = "lbl_newRuleChooseOperation_A";
            this.lbl_newRuleChooseOperation_A.Size = new System.Drawing.Size(53, 13);
            this.lbl_newRuleChooseOperation_A.TabIndex = 11;
            this.lbl_newRuleChooseOperation_A.Text = "Operation";
            // 
            // cob_newRule_chooseOperation
            // 
            this.cob_newRule_chooseOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_newRule_chooseOperation.FormattingEnabled = true;
            this.cob_newRule_chooseOperation.Items.AddRange(new object[] {
            "Enthält Key",
            "Enthält Key nicht",
            "Entspricht Key"});
            this.cob_newRule_chooseOperation.Location = new System.Drawing.Point(6, 121);
            this.cob_newRule_chooseOperation.Name = "cob_newRule_chooseOperation";
            this.cob_newRule_chooseOperation.Size = new System.Drawing.Size(103, 21);
            this.cob_newRule_chooseOperation.TabIndex = 10;
            // 
            // lbl_newRuleChooseObejct_A
            // 
            this.lbl_newRuleChooseObejct_A.AutoSize = true;
            this.lbl_newRuleChooseObejct_A.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_newRuleChooseObejct_A.Location = new System.Drawing.Point(140, 57);
            this.lbl_newRuleChooseObejct_A.Name = "lbl_newRuleChooseObejct_A";
            this.lbl_newRuleChooseObejct_A.Size = new System.Drawing.Size(53, 13);
            this.lbl_newRuleChooseObejct_A.TabIndex = 9;
            this.lbl_newRuleChooseObejct_A.Text = "Zielobjekt";
            // 
            // cob_newRuleChooseObject
            // 
            this.cob_newRuleChooseObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_newRuleChooseObject.FormattingEnabled = true;
            this.cob_newRuleChooseObject.Location = new System.Drawing.Point(143, 72);
            this.cob_newRuleChooseObject.Name = "cob_newRuleChooseObject";
            this.cob_newRuleChooseObject.Size = new System.Drawing.Size(103, 21);
            this.cob_newRuleChooseObject.TabIndex = 8;
            // 
            // lbl_newRuleChooseFunction_A
            // 
            this.lbl_newRuleChooseFunction_A.AutoSize = true;
            this.lbl_newRuleChooseFunction_A.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_newRuleChooseFunction_A.Location = new System.Drawing.Point(6, 57);
            this.lbl_newRuleChooseFunction_A.Name = "lbl_newRuleChooseFunction_A";
            this.lbl_newRuleChooseFunction_A.Size = new System.Drawing.Size(48, 13);
            this.lbl_newRuleChooseFunction_A.TabIndex = 7;
            this.lbl_newRuleChooseFunction_A.Text = "Funktion";
            // 
            // chb_newObjectDisplayObject
            // 
            this.chb_newObjectDisplayObject.AutoSize = true;
            this.chb_newObjectDisplayObject.Location = new System.Drawing.Point(9, 180);
            this.chb_newObjectDisplayObject.Name = "chb_newObjectDisplayObject";
            this.chb_newObjectDisplayObject.Size = new System.Drawing.Size(93, 17);
            this.chb_newObjectDisplayObject.TabIndex = 24;
            this.chb_newObjectDisplayObject.Text = "Anzeigeobjekt";
            this.chb_newObjectDisplayObject.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_createRules);
            this.Controls.Add(this.grp_createVisObject);
            this.Controls.Add(this.grp_editFunctions);
            this.Controls.Add(this.pan_workspace);
            this.Controls.Add(this.grp_serialPort);
            this.Controls.Add(this.pan_field1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_serialPort.ResumeLayout(false);
            this.grp_serialPort.PerformLayout();
            this.pan_workspace.ResumeLayout(false);
            this.pan_workspace.PerformLayout();
            this.grp_editFunctions.ResumeLayout(false);
            this.grp_editFunctions.PerformLayout();
            this.grp_createVisObject.ResumeLayout(false);
            this.grp_createVisObject.PerformLayout();
            this.grp_createRules.ResumeLayout(false);
            this.grp_createRules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_field1;
        private System.Windows.Forms.Label lbl_newObjectFunction;
        private System.Windows.Forms.Label lbl_newObjectType_A;
        private System.Windows.Forms.Label lbl_newFunctionName_A;
        private System.Windows.Forms.TextBox txt_newRuleKeyword;
        private System.Windows.Forms.Label lbl_keyword;
        private System.Windows.Forms.TextBox txt_newRuleDisplayText;
        private System.Windows.Forms.Label lbl_displayText;
        private System.Windows.Forms.ComboBox cob_newRuleChooseFunction;
        private System.Windows.Forms.Button cmd_addNewFunction;
        private System.Windows.Forms.Button cmd_openPort;
        private System.Windows.Forms.Button cmd_closePort;
        private System.Windows.Forms.GroupBox grp_serialPort;
        private System.Windows.Forms.Button cmd_addSimSerialAnswer;
        private System.Windows.Forms.Label lbl_simulateSerialInput_A;
        private System.Windows.Forms.TextBox txt_simSerialInput;
        private System.Windows.Forms.Panel pan_workspace;
        private System.Windows.Forms.ComboBox cob_newObjectType;
        private System.Windows.Forms.GroupBox grp_editFunctions;
        private System.Windows.Forms.TextBox txt_newFunctionName;
        private System.Windows.Forms.Button cmd_createFunction;
        private System.Windows.Forms.GroupBox grp_createVisObject;
        private System.Windows.Forms.ComboBox cob_newObjectFunction;
        private System.Windows.Forms.Label lbl_newObjectName_A;
        private System.Windows.Forms.TextBox txt_newObjectName;
        private System.Windows.Forms.Button cmd_createNewObject;
        private System.Windows.Forms.GroupBox grp_createRules;
        private System.Windows.Forms.Label lbl_newRuleChooseFunction_A;
        private System.Windows.Forms.Label lbl_newRuleChooseObejct_A;
        private System.Windows.Forms.ComboBox cob_newRuleChooseObject;
        private System.Windows.Forms.Label lbl_preview;
        private System.Windows.Forms.Label lbl_newObject_posX_A;
        private System.Windows.Forms.Label lbl_newObject_yPos_A;
        private System.Windows.Forms.TextBox txt_newObject_xPos;
        private System.Windows.Forms.TextBox txt_newObject_yPos;
        private System.Windows.Forms.Label lbl_newRuleChooseDisplayOperation_A;
        private System.Windows.Forms.Label lbl_newRuleChooseOperation_A;
        private System.Windows.Forms.ComboBox cob_newRule_chooseOperation;
        private System.Windows.Forms.Button cmd_newRuleDisplayKeyword;
        private System.Windows.Forms.Label lbl_newObjectContent_A;
        private System.Windows.Forms.TextBox txt_newObjectContent;
        private System.Windows.Forms.CheckBox chb_newObjectDisplayObject;
    }
}

