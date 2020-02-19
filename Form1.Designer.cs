namespace Game
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
            this.cmd_openPort = new System.Windows.Forms.Button();
            this.cmd_closePort = new System.Windows.Forms.Button();
            this.grp_serialPort = new System.Windows.Forms.GroupBox();
            this.cmd_addSimSerialAnswer = new System.Windows.Forms.Button();
            this.lbl_simulateSerialInput_A = new System.Windows.Forms.Label();
            this.txt_simSerialInput = new System.Windows.Forms.TextBox();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_forms = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_openPlayground = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmd_createNewObject = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_rules = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_createNewRule = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_editRule = new System.Windows.Forms.ToolStripMenuItem();
            this.cob_chooseRuleToEdit = new System.Windows.Forms.ToolStripComboBox();
            this.cmd_editRule = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_deleteRule = new System.Windows.Forms.ToolStripMenuItem();
            this.cob_chooseRuleToDelete = new System.Windows.Forms.ToolStripComboBox();
            this.cmd_deleteRule = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_functions = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_newFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_newFunctionName = new System.Windows.Forms.ToolStripTextBox();
            this.cmd_createNewFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_renameFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.cob_chooseFunctionToRename = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_renameFunction = new System.Windows.Forms.ToolStripTextBox();
            this.cmd_renameFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_deleteFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.cob_deleteFunction = new System.Windows.Forms.ToolStripComboBox();
            this.cmd_deleteFunction = new System.Windows.Forms.ToolStripMenuItem();
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
            this.grp_serialPort.Location = new System.Drawing.Point(12, 547);
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
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_forms,
            this.menu_rules,
            this.menu_functions});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1585, 24);
            this.main_menu.TabIndex = 12;
            this.main_menu.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(46, 20);
            this.menu_file.Text = "Datei";
            // 
            // menu_forms
            // 
            this.menu_forms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmd_openPlayground,
            this.toolStripSeparator2,
            this.cmd_createNewObject});
            this.menu_forms.Name = "menu_forms";
            this.menu_forms.Size = new System.Drawing.Size(57, 20);
            this.menu_forms.Text = "Fenster";
            // 
            // cmd_openPlayground
            // 
            this.cmd_openPlayground.Name = "cmd_openPlayground";
            this.cmd_openPlayground.Size = new System.Drawing.Size(192, 22);
            this.cmd_openPlayground.Text = "Arbeitsfläche öffnen";
            this.cmd_openPlayground.Visible = false;
            this.cmd_openPlayground.Click += new System.EventHandler(this.cmd_openPlayground_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // cmd_createNewObject
            // 
            this.cmd_createNewObject.Name = "cmd_createNewObject";
            this.cmd_createNewObject.Size = new System.Drawing.Size(192, 22);
            this.cmd_createNewObject.Text = "Neues Objekt erstellen";
            this.cmd_createNewObject.Click += new System.EventHandler(this.cmd_createNewObject_Click);
            // 
            // menu_rules
            // 
            this.menu_rules.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_createNewRule,
            this.menu_editRule,
            this.menu_deleteRule});
            this.menu_rules.Name = "menu_rules";
            this.menu_rules.Size = new System.Drawing.Size(55, 20);
            this.menu_rules.Text = "Regeln";
            // 
            // menu_createNewRule
            // 
            this.menu_createNewRule.Name = "menu_createNewRule";
            this.menu_createNewRule.Size = new System.Drawing.Size(181, 22);
            this.menu_createNewRule.Text = "Neue Regel erstellen";
            this.menu_createNewRule.Click += new System.EventHandler(this.menu_createNewRule_Click);
            // 
            // menu_editRule
            // 
            this.menu_editRule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cob_chooseRuleToEdit,
            this.cmd_editRule});
            this.menu_editRule.Name = "menu_editRule";
            this.menu_editRule.Size = new System.Drawing.Size(181, 22);
            this.menu_editRule.Text = "Regel bearbeiten";
            // 
            // cob_chooseRuleToEdit
            // 
            this.cob_chooseRuleToEdit.Name = "cob_chooseRuleToEdit";
            this.cob_chooseRuleToEdit.Size = new System.Drawing.Size(121, 23);
            // 
            // cmd_editRule
            // 
            this.cmd_editRule.Name = "cmd_editRule";
            this.cmd_editRule.Size = new System.Drawing.Size(181, 22);
            this.cmd_editRule.Text = "Regel bearbeiten";
            // 
            // menu_deleteRule
            // 
            this.menu_deleteRule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cob_chooseRuleToDelete,
            this.cmd_deleteRule});
            this.menu_deleteRule.Name = "menu_deleteRule";
            this.menu_deleteRule.Size = new System.Drawing.Size(181, 22);
            this.menu_deleteRule.Text = "Regel löschen";
            // 
            // cob_chooseRuleToDelete
            // 
            this.cob_chooseRuleToDelete.Name = "cob_chooseRuleToDelete";
            this.cob_chooseRuleToDelete.Size = new System.Drawing.Size(121, 23);
            // 
            // cmd_deleteRule
            // 
            this.cmd_deleteRule.Name = "cmd_deleteRule";
            this.cmd_deleteRule.Size = new System.Drawing.Size(218, 22);
            this.cmd_deleteRule.Text = "Ausgewählte Regel löschen";
            // 
            // menu_functions
            // 
            this.menu_functions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_newFunction,
            this.menu_renameFunction,
            this.menu_deleteFunction});
            this.menu_functions.Name = "menu_functions";
            this.menu_functions.Size = new System.Drawing.Size(79, 20);
            this.menu_functions.Text = "Funktionen";
            // 
            // menu_newFunction
            // 
            this.menu_newFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_newFunctionName,
            this.cmd_createNewFunction});
            this.menu_newFunction.Name = "menu_newFunction";
            this.menu_newFunction.Size = new System.Drawing.Size(199, 22);
            this.menu_newFunction.Text = "Neue Funktion erstellen";
            // 
            // txt_newFunctionName
            // 
            this.txt_newFunctionName.BackColor = System.Drawing.Color.OldLace;
            this.txt_newFunctionName.Name = "txt_newFunctionName";
            this.txt_newFunctionName.Size = new System.Drawing.Size(100, 23);
            // 
            // cmd_createNewFunction
            // 
            this.cmd_createNewFunction.Name = "cmd_createNewFunction";
            this.cmd_createNewFunction.Size = new System.Drawing.Size(160, 22);
            this.cmd_createNewFunction.Text = "Erstellen";
            this.cmd_createNewFunction.Click += new System.EventHandler(this.cmd_createFunction_Click);
            // 
            // menu_renameFunction
            // 
            this.menu_renameFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cob_chooseFunctionToRename,
            this.toolStripSeparator1,
            this.txt_renameFunction,
            this.cmd_renameFunction});
            this.menu_renameFunction.Name = "menu_renameFunction";
            this.menu_renameFunction.Size = new System.Drawing.Size(199, 22);
            this.menu_renameFunction.Text = "Funktion umbenennen";
            // 
            // cob_chooseFunctionToRename
            // 
            this.cob_chooseFunctionToRename.Name = "cob_chooseFunctionToRename";
            this.cob_chooseFunctionToRename.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // txt_renameFunction
            // 
            this.txt_renameFunction.Name = "txt_renameFunction";
            this.txt_renameFunction.Size = new System.Drawing.Size(100, 23);
            // 
            // cmd_renameFunction
            // 
            this.cmd_renameFunction.Name = "cmd_renameFunction";
            this.cmd_renameFunction.Size = new System.Drawing.Size(181, 22);
            this.cmd_renameFunction.Text = "Umbenennen";
            // 
            // menu_deleteFunction
            // 
            this.menu_deleteFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cob_deleteFunction,
            this.cmd_deleteFunction});
            this.menu_deleteFunction.Name = "menu_deleteFunction";
            this.menu_deleteFunction.Size = new System.Drawing.Size(199, 22);
            this.menu_deleteFunction.Text = "Funktion löschen";
            // 
            // cob_deleteFunction
            // 
            this.cob_deleteFunction.Name = "cob_deleteFunction";
            this.cob_deleteFunction.Size = new System.Drawing.Size(121, 23);
            // 
            // cmd_deleteFunction
            // 
            this.cmd_deleteFunction.Name = "cmd_deleteFunction";
            this.cmd_deleteFunction.Size = new System.Drawing.Size(181, 22);
            this.cmd_deleteFunction.Text = "Löschen";
            // 
            // Form_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 815);
            this.Controls.Add(this.grp_serialPort);
            this.Controls.Add(this.main_menu);
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
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_forms;
        private System.Windows.Forms.ToolStripMenuItem cmd_openPlayground;
        private System.Windows.Forms.ToolStripMenuItem menu_rules;
        private System.Windows.Forms.ToolStripMenuItem menu_createNewRule;
        private System.Windows.Forms.ToolStripMenuItem menu_editRule;
        private System.Windows.Forms.ToolStripComboBox cob_chooseRuleToEdit;
        private System.Windows.Forms.ToolStripMenuItem menu_deleteRule;
        private System.Windows.Forms.ToolStripComboBox cob_chooseRuleToDelete;
        private System.Windows.Forms.ToolStripMenuItem cmd_deleteRule;
        private System.Windows.Forms.ToolStripMenuItem menu_functions;
        private System.Windows.Forms.ToolStripMenuItem menu_newFunction;
        private System.Windows.Forms.ToolStripTextBox txt_newFunctionName;
        private System.Windows.Forms.ToolStripMenuItem cmd_createNewFunction;
        private System.Windows.Forms.ToolStripMenuItem menu_renameFunction;
        private System.Windows.Forms.ToolStripComboBox cob_chooseFunctionToRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txt_renameFunction;
        private System.Windows.Forms.ToolStripMenuItem cmd_renameFunction;
        private System.Windows.Forms.ToolStripMenuItem menu_deleteFunction;
        private System.Windows.Forms.ToolStripComboBox cob_deleteFunction;
        private System.Windows.Forms.ToolStripMenuItem cmd_deleteFunction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmd_createNewObject;
        private System.Windows.Forms.ToolStripMenuItem cmd_editRule;
    }
}

