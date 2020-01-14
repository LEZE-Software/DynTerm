namespace Game
{
    partial class Form_CreateNewRule
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
            this.chb_sendSerial = new System.Windows.Forms.CheckBox();
            this.cob_negObject = new System.Windows.Forms.ComboBox();
            this.cob_posObject = new System.Windows.Forms.ComboBox();
            this.lbl_negFromObject = new System.Windows.Forms.Label();
            this.lbl_posFromObject = new System.Windows.Forms.Label();
            this.lbl_sendOperation = new System.Windows.Forms.Label();
            this.cob_sendOption = new System.Windows.Forms.ComboBox();
            this.txt_negText = new System.Windows.Forms.TextBox();
            this.lbl_negText = new System.Windows.Forms.Label();
            this.lbl_posText = new System.Windows.Forms.Label();
            this.txt_posText = new System.Windows.Forms.TextBox();
            this.grp_sendSettings = new System.Windows.Forms.GroupBox();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.lbl_keyword = new System.Windows.Forms.Label();
            this.cob_operation = new System.Windows.Forms.ComboBox();
            this.cob_parentFunction = new System.Windows.Forms.ComboBox();
            this.lbl_function = new System.Windows.Forms.Label();
            this.grp_generals = new System.Windows.Forms.GroupBox();
            this.chb_useOutput = new System.Windows.Forms.CheckBox();
            this.txt_displayText2 = new System.Windows.Forms.TextBox();
            this.lbl_targetObject = new System.Windows.Forms.Label();
            this.lbl_displayText2 = new System.Windows.Forms.Label();
            this.lbl_displayObject = new System.Windows.Forms.Label();
            this.cob_displayOperation = new System.Windows.Forms.ComboBox();
            this.cob_targetObject = new System.Windows.Forms.ComboBox();
            this.txt_displayText1 = new System.Windows.Forms.TextBox();
            this.lbl_displayText1 = new System.Windows.Forms.Label();
            this.grp_outputSettings = new System.Windows.Forms.GroupBox();
            this.cmd_createObject = new System.Windows.Forms.Button();
            this.grp_sendSettings.SuspendLayout();
            this.grp_generals.SuspendLayout();
            this.grp_outputSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // chb_sendSerial
            // 
            this.chb_sendSerial.AutoSize = true;
            this.chb_sendSerial.Location = new System.Drawing.Point(13, 335);
            this.chb_sendSerial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chb_sendSerial.Name = "chb_sendSerial";
            this.chb_sendSerial.Size = new System.Drawing.Size(15, 14);
            this.chb_sendSerial.TabIndex = 26;
            this.chb_sendSerial.UseVisualStyleBackColor = true;
            this.chb_sendSerial.CheckedChanged += new System.EventHandler(this.chb_sendSerial_CheckedChanged);
            // 
            // cob_negObject
            // 
            this.cob_negObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_negObject.FormattingEnabled = true;
            this.cob_negObject.Items.AddRange(new object[] {
            "Nichts senden",
            "Positiv / Negativ",
            "Immer senden"});
            this.cob_negObject.Location = new System.Drawing.Point(191, 152);
            this.cob_negObject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_negObject.Name = "cob_negObject";
            this.cob_negObject.Size = new System.Drawing.Size(156, 22);
            this.cob_negObject.TabIndex = 25;
            // 
            // cob_posObject
            // 
            this.cob_posObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_posObject.FormattingEnabled = true;
            this.cob_posObject.Items.AddRange(new object[] {
            "Nichts senden",
            "Positiv / Negativ",
            "Immer senden"});
            this.cob_posObject.Location = new System.Drawing.Point(8, 152);
            this.cob_posObject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_posObject.Name = "cob_posObject";
            this.cob_posObject.Size = new System.Drawing.Size(156, 22);
            this.cob_posObject.TabIndex = 24;
            // 
            // lbl_negFromObject
            // 
            this.lbl_negFromObject.AutoSize = true;
            this.lbl_negFromObject.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_negFromObject.Location = new System.Drawing.Point(188, 135);
            this.lbl_negFromObject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_negFromObject.Name = "lbl_negFromObject";
            this.lbl_negFromObject.Size = new System.Drawing.Size(139, 14);
            this.lbl_negFromObject.TabIndex = 23;
            this.lbl_negFromObject.Text = "Neg. Text von Objekt";
            // 
            // lbl_posFromObject
            // 
            this.lbl_posFromObject.AutoSize = true;
            this.lbl_posFromObject.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_posFromObject.Location = new System.Drawing.Point(8, 135);
            this.lbl_posFromObject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_posFromObject.Name = "lbl_posFromObject";
            this.lbl_posFromObject.Size = new System.Drawing.Size(137, 14);
            this.lbl_posFromObject.TabIndex = 22;
            this.lbl_posFromObject.Text = "Pos. Text von Objekt";
            // 
            // lbl_sendOperation
            // 
            this.lbl_sendOperation.AutoSize = true;
            this.lbl_sendOperation.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_sendOperation.Location = new System.Drawing.Point(8, 20);
            this.lbl_sendOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sendOperation.Name = "lbl_sendOperation";
            this.lbl_sendOperation.Size = new System.Drawing.Size(112, 14);
            this.lbl_sendOperation.TabIndex = 19;
            this.lbl_sendOperation.Text = "Sende-Verhalten";
            // 
            // cob_sendOption
            // 
            this.cob_sendOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_sendOption.FormattingEnabled = true;
            this.cob_sendOption.Items.AddRange(new object[] {
            "Positiv / Negativ",
            "Immer senden"});
            this.cob_sendOption.Location = new System.Drawing.Point(8, 37);
            this.cob_sendOption.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_sendOption.Name = "cob_sendOption";
            this.cob_sendOption.Size = new System.Drawing.Size(133, 22);
            this.cob_sendOption.TabIndex = 19;
            // 
            // txt_negText
            // 
            this.txt_negText.Location = new System.Drawing.Point(191, 92);
            this.txt_negText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_negText.Name = "txt_negText";
            this.txt_negText.Size = new System.Drawing.Size(156, 22);
            this.txt_negText.TabIndex = 21;
            // 
            // lbl_negText
            // 
            this.lbl_negText.AutoSize = true;
            this.lbl_negText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_negText.Location = new System.Drawing.Point(188, 75);
            this.lbl_negText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_negText.Name = "lbl_negText";
            this.lbl_negText.Size = new System.Drawing.Size(117, 14);
            this.lbl_negText.TabIndex = 20;
            this.lbl_negText.Text = "Negative Antwort";
            // 
            // lbl_posText
            // 
            this.lbl_posText.AutoSize = true;
            this.lbl_posText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_posText.Location = new System.Drawing.Point(8, 75);
            this.lbl_posText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_posText.Name = "lbl_posText";
            this.lbl_posText.Size = new System.Drawing.Size(110, 14);
            this.lbl_posText.TabIndex = 19;
            this.lbl_posText.Text = "Positive Antwort";
            // 
            // txt_posText
            // 
            this.txt_posText.Location = new System.Drawing.Point(8, 92);
            this.txt_posText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_posText.Name = "txt_posText";
            this.txt_posText.Size = new System.Drawing.Size(133, 22);
            this.txt_posText.TabIndex = 4;
            // 
            // grp_sendSettings
            // 
            this.grp_sendSettings.Controls.Add(this.cob_negObject);
            this.grp_sendSettings.Controls.Add(this.cob_posObject);
            this.grp_sendSettings.Controls.Add(this.lbl_negFromObject);
            this.grp_sendSettings.Controls.Add(this.lbl_posFromObject);
            this.grp_sendSettings.Controls.Add(this.lbl_sendOperation);
            this.grp_sendSettings.Controls.Add(this.cob_sendOption);
            this.grp_sendSettings.Controls.Add(this.txt_negText);
            this.grp_sendSettings.Controls.Add(this.lbl_negText);
            this.grp_sendSettings.Controls.Add(this.lbl_posText);
            this.grp_sendSettings.Controls.Add(this.txt_posText);
            this.grp_sendSettings.Enabled = false;
            this.grp_sendSettings.Location = new System.Drawing.Point(36, 335);
            this.grp_sendSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_sendSettings.Name = "grp_sendSettings";
            this.grp_sendSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_sendSettings.Size = new System.Drawing.Size(355, 182);
            this.grp_sendSettings.TabIndex = 17;
            this.grp_sendSettings.TabStop = false;
            this.grp_sendSettings.Text = "Sende-Einstellungen";
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(8, 37);
            this.txt_keyword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(156, 22);
            this.txt_keyword.TabIndex = 1;
            // 
            // lbl_operation
            // 
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_operation.Location = new System.Drawing.Point(211, 20);
            this.lbl_operation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(70, 14);
            this.lbl_operation.TabIndex = 11;
            this.lbl_operation.Text = "Operation";
            // 
            // lbl_keyword
            // 
            this.lbl_keyword.AutoSize = true;
            this.lbl_keyword.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_keyword.Location = new System.Drawing.Point(8, 20);
            this.lbl_keyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_keyword.Name = "lbl_keyword";
            this.lbl_keyword.Size = new System.Drawing.Size(94, 14);
            this.lbl_keyword.TabIndex = 2;
            this.lbl_keyword.Text = "Schlüsselwort";
            // 
            // cob_operation
            // 
            this.cob_operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_operation.FormattingEnabled = true;
            this.cob_operation.Items.AddRange(new object[] {
            "Enthält Key",
            "Enthält Key nicht",
            "Entspricht Key",
            "Informationsausgabe"});
            this.cob_operation.Location = new System.Drawing.Point(214, 37);
            this.cob_operation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_operation.Name = "cob_operation";
            this.cob_operation.Size = new System.Drawing.Size(156, 22);
            this.cob_operation.TabIndex = 10;
            this.cob_operation.DropDown += new System.EventHandler(this.cob_operation_SelectedIndexChanged);
            // 
            // cob_parentFunction
            // 
            this.cob_parentFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_parentFunction.FormattingEnabled = true;
            this.cob_parentFunction.Location = new System.Drawing.Point(8, 92);
            this.cob_parentFunction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_parentFunction.Name = "cob_parentFunction";
            this.cob_parentFunction.Size = new System.Drawing.Size(156, 22);
            this.cob_parentFunction.TabIndex = 5;
            this.cob_parentFunction.DropDown += new System.EventHandler(this.cob_chooseFunction_DropDown);
            this.cob_parentFunction.SelectedIndexChanged += new System.EventHandler(this.cob_chooseFunction_SelectedIndexChanged);
            // 
            // lbl_function
            // 
            this.lbl_function.AutoSize = true;
            this.lbl_function.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_function.Location = new System.Drawing.Point(8, 75);
            this.lbl_function.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_function.Name = "lbl_function";
            this.lbl_function.Size = new System.Drawing.Size(61, 14);
            this.lbl_function.TabIndex = 7;
            this.lbl_function.Text = "Funktion";
            // 
            // grp_generals
            // 
            this.grp_generals.Controls.Add(this.txt_keyword);
            this.grp_generals.Controls.Add(this.lbl_operation);
            this.grp_generals.Controls.Add(this.lbl_keyword);
            this.grp_generals.Controls.Add(this.cob_operation);
            this.grp_generals.Controls.Add(this.cob_parentFunction);
            this.grp_generals.Controls.Add(this.lbl_function);
            this.grp_generals.Location = new System.Drawing.Point(13, 12);
            this.grp_generals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_generals.Name = "grp_generals";
            this.grp_generals.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_generals.Size = new System.Drawing.Size(378, 128);
            this.grp_generals.TabIndex = 16;
            this.grp_generals.TabStop = false;
            this.grp_generals.Text = "Allgemeine Einstellungen";
            // 
            // chb_useOutput
            // 
            this.chb_useOutput.AutoSize = true;
            this.chb_useOutput.Location = new System.Drawing.Point(13, 149);
            this.chb_useOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chb_useOutput.Name = "chb_useOutput";
            this.chb_useOutput.Size = new System.Drawing.Size(15, 14);
            this.chb_useOutput.TabIndex = 27;
            this.chb_useOutput.UseVisualStyleBackColor = true;
            this.chb_useOutput.CheckedChanged += new System.EventHandler(this.chb_useOutput_CheckedChanged);
            // 
            // txt_displayText2
            // 
            this.txt_displayText2.Location = new System.Drawing.Point(191, 152);
            this.txt_displayText2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_displayText2.Name = "txt_displayText2";
            this.txt_displayText2.Size = new System.Drawing.Size(156, 22);
            this.txt_displayText2.TabIndex = 15;
            // 
            // lbl_targetObject
            // 
            this.lbl_targetObject.AutoSize = true;
            this.lbl_targetObject.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_targetObject.Location = new System.Drawing.Point(8, 20);
            this.lbl_targetObject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_targetObject.Name = "lbl_targetObject";
            this.lbl_targetObject.Size = new System.Drawing.Size(69, 14);
            this.lbl_targetObject.TabIndex = 9;
            this.lbl_targetObject.Text = "Zielobjekt";
            // 
            // lbl_displayText2
            // 
            this.lbl_displayText2.AutoSize = true;
            this.lbl_displayText2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_displayText2.Location = new System.Drawing.Point(188, 135);
            this.lbl_displayText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_displayText2.Name = "lbl_displayText2";
            this.lbl_displayText2.Size = new System.Drawing.Size(122, 14);
            this.lbl_displayText2.TabIndex = 16;
            this.lbl_displayText2.Text = "Negative Ausgabe";
            // 
            // lbl_displayObject
            // 
            this.lbl_displayObject.AutoSize = true;
            this.lbl_displayObject.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_displayObject.Location = new System.Drawing.Point(8, 75);
            this.lbl_displayObject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_displayObject.Name = "lbl_displayObject";
            this.lbl_displayObject.Size = new System.Drawing.Size(101, 14);
            this.lbl_displayObject.TabIndex = 13;
            this.lbl_displayObject.Text = "Angezeigt wird";
            // 
            // cob_displayOperation
            // 
            this.cob_displayOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_displayOperation.FormattingEnabled = true;
            this.cob_displayOperation.Items.AddRange(new object[] {
            "Keyword",
            "Anzeigetext",
            "Ja / Nein",
            "Ja / Nein individuell",
            "Empfangene Daten"});
            this.cob_displayOperation.Location = new System.Drawing.Point(8, 92);
            this.cob_displayOperation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_displayOperation.Name = "cob_displayOperation";
            this.cob_displayOperation.Size = new System.Drawing.Size(133, 22);
            this.cob_displayOperation.TabIndex = 14;
            this.cob_displayOperation.SelectedIndexChanged += new System.EventHandler(this.cob_displayOperation_SelectedIndexChanged);
            // 
            // cob_targetObject
            // 
            this.cob_targetObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_targetObject.FormattingEnabled = true;
            this.cob_targetObject.Location = new System.Drawing.Point(8, 37);
            this.cob_targetObject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_targetObject.Name = "cob_targetObject";
            this.cob_targetObject.Size = new System.Drawing.Size(133, 22);
            this.cob_targetObject.TabIndex = 8;
            this.cob_targetObject.DropDown += new System.EventHandler(this.cob_displayOperation_SelectedIndexChanged);
            // 
            // txt_displayText1
            // 
            this.txt_displayText1.Location = new System.Drawing.Point(8, 152);
            this.txt_displayText1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_displayText1.Name = "txt_displayText1";
            this.txt_displayText1.Size = new System.Drawing.Size(133, 22);
            this.txt_displayText1.TabIndex = 3;
            // 
            // lbl_displayText1
            // 
            this.lbl_displayText1.AutoSize = true;
            this.lbl_displayText1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_displayText1.Location = new System.Drawing.Point(8, 135);
            this.lbl_displayText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_displayText1.Name = "lbl_displayText1";
            this.lbl_displayText1.Size = new System.Drawing.Size(115, 14);
            this.lbl_displayText1.TabIndex = 4;
            this.lbl_displayText1.Text = "Positive Ausgabe";
            // 
            // grp_outputSettings
            // 
            this.grp_outputSettings.Controls.Add(this.txt_displayText2);
            this.grp_outputSettings.Controls.Add(this.lbl_targetObject);
            this.grp_outputSettings.Controls.Add(this.lbl_displayText2);
            this.grp_outputSettings.Controls.Add(this.lbl_displayObject);
            this.grp_outputSettings.Controls.Add(this.cob_displayOperation);
            this.grp_outputSettings.Controls.Add(this.cob_targetObject);
            this.grp_outputSettings.Controls.Add(this.txt_displayText1);
            this.grp_outputSettings.Controls.Add(this.lbl_displayText1);
            this.grp_outputSettings.Enabled = false;
            this.grp_outputSettings.Location = new System.Drawing.Point(36, 146);
            this.grp_outputSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_outputSettings.Name = "grp_outputSettings";
            this.grp_outputSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_outputSettings.Size = new System.Drawing.Size(355, 183);
            this.grp_outputSettings.TabIndex = 15;
            this.grp_outputSettings.TabStop = false;
            this.grp_outputSettings.Text = "Ausgabe-Einstellungen";
            // 
            // cmd_createObject
            // 
            this.cmd_createObject.Location = new System.Drawing.Point(227, 523);
            this.cmd_createObject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_createObject.Name = "cmd_createObject";
            this.cmd_createObject.Size = new System.Drawing.Size(164, 24);
            this.cmd_createObject.TabIndex = 6;
            this.cmd_createObject.Text = "Hinzufügen";
            this.cmd_createObject.UseVisualStyleBackColor = true;
            this.cmd_createObject.Click += new System.EventHandler(this.cmd_addNewRule_Click);
            // 
            // Form_CreateNewRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 554);
            this.Controls.Add(this.chb_sendSerial);
            this.Controls.Add(this.chb_useOutput);
            this.Controls.Add(this.cmd_createObject);
            this.Controls.Add(this.grp_sendSettings);
            this.Controls.Add(this.grp_outputSettings);
            this.Controls.Add(this.grp_generals);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_CreateNewRule";
            this.Text = "Neue Regel erstellen";
            this.Load += new System.EventHandler(this.Form_CreateNewRule_Load);
            this.grp_sendSettings.ResumeLayout(false);
            this.grp_sendSettings.PerformLayout();
            this.grp_generals.ResumeLayout(false);
            this.grp_generals.PerformLayout();
            this.grp_outputSettings.ResumeLayout(false);
            this.grp_outputSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_sendSerial;
        private System.Windows.Forms.ComboBox cob_negObject;
        private System.Windows.Forms.ComboBox cob_posObject;
        private System.Windows.Forms.Label lbl_negFromObject;
        private System.Windows.Forms.Label lbl_posFromObject;
        private System.Windows.Forms.Label lbl_sendOperation;
        private System.Windows.Forms.ComboBox cob_sendOption;
        private System.Windows.Forms.TextBox txt_negText;
        private System.Windows.Forms.Label lbl_negText;
        private System.Windows.Forms.Label lbl_posText;
        private System.Windows.Forms.TextBox txt_posText;
        private System.Windows.Forms.GroupBox grp_sendSettings;
        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.Label lbl_keyword;
        private System.Windows.Forms.ComboBox cob_operation;
        private System.Windows.Forms.ComboBox cob_parentFunction;
        private System.Windows.Forms.Label lbl_function;
        private System.Windows.Forms.GroupBox grp_generals;
        private System.Windows.Forms.CheckBox chb_useOutput;
        private System.Windows.Forms.TextBox txt_displayText2;
        private System.Windows.Forms.Label lbl_targetObject;
        private System.Windows.Forms.Label lbl_displayText2;
        private System.Windows.Forms.Label lbl_displayObject;
        private System.Windows.Forms.ComboBox cob_displayOperation;
        private System.Windows.Forms.ComboBox cob_targetObject;
        private System.Windows.Forms.TextBox txt_displayText1;
        private System.Windows.Forms.Label lbl_displayText1;
        private System.Windows.Forms.GroupBox grp_outputSettings;
        private System.Windows.Forms.Button cmd_createObject;
    }
}