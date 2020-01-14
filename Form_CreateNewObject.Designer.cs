namespace Game
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
            this.lbl_width = new System.Windows.Forms.Label();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.lbl_content = new System.Windows.Forms.Label();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.lbl_xPos = new System.Windows.Forms.Label();
            this.lbl_yPos = new System.Windows.Forms.Label();
            this.txt_xPos = new System.Windows.Forms.TextBox();
            this.cmd_createObject = new System.Windows.Forms.Button();
            this.cob_chooseFunction = new System.Windows.Forms.ComboBox();
            this.txt_yPos = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_objectName = new System.Windows.Forms.TextBox();
            this.cob_objectType = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.rad_function = new System.Windows.Forms.RadioButton();
            this.rad_display = new System.Windows.Forms.RadioButton();
            this.grp_objectKind = new System.Windows.Forms.GroupBox();
            this.grp_sizePosition = new System.Windows.Forms.GroupBox();
            this.cmd_preview = new System.Windows.Forms.Button();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.lbl_height = new System.Windows.Forms.Label();
            this.grp_generals = new System.Windows.Forms.GroupBox();
            this.lbl_function = new System.Windows.Forms.Label();
            this.grp_objectKind.SuspendLayout();
            this.grp_sizePosition.SuspendLayout();
            this.grp_generals.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_width.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.Location = new System.Drawing.Point(8, 56);
            this.lbl_width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(44, 14);
            this.lbl_width.TabIndex = 26;
            this.lbl_width.Text = "Breite";
            // 
            // txt_width
            // 
            this.txt_width.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_width.Location = new System.Drawing.Point(92, 53);
            this.txt_width.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(52, 22);
            this.txt_width.TabIndex = 25;
            this.txt_width.Text = "35";
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
            // lbl_xPos
            // 
            this.lbl_xPos.AutoSize = true;
            this.lbl_xPos.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_xPos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xPos.Location = new System.Drawing.Point(8, 24);
            this.lbl_xPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_xPos.Name = "lbl_xPos";
            this.lbl_xPos.Size = new System.Drawing.Size(70, 14);
            this.lbl_xPos.TabIndex = 21;
            this.lbl_xPos.Text = "X-Position";
            // 
            // lbl_yPos
            // 
            this.lbl_yPos.AutoSize = true;
            this.lbl_yPos.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_yPos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yPos.Location = new System.Drawing.Point(159, 24);
            this.lbl_yPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_yPos.Name = "lbl_yPos";
            this.lbl_yPos.Size = new System.Drawing.Size(68, 14);
            this.lbl_yPos.TabIndex = 20;
            this.lbl_yPos.Text = "Y-Position";
            // 
            // txt_xPos
            // 
            this.txt_xPos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xPos.Location = new System.Drawing.Point(92, 21);
            this.txt_xPos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_xPos.Name = "txt_xPos";
            this.txt_xPos.Size = new System.Drawing.Size(52, 22);
            this.txt_xPos.TabIndex = 19;
            this.txt_xPos.Text = "10";
            // 
            // cmd_createObject
            // 
            this.cmd_createObject.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_createObject.Location = new System.Drawing.Point(158, 340);
            this.cmd_createObject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_createObject.Name = "cmd_createObject";
            this.cmd_createObject.Size = new System.Drawing.Size(177, 25);
            this.cmd_createObject.TabIndex = 14;
            this.cmd_createObject.Text = "Erstellen";
            this.cmd_createObject.UseVisualStyleBackColor = true;
            this.cmd_createObject.Click += new System.EventHandler(this.cmd_createObject_Click);
            // 
            // cob_chooseFunction
            // 
            this.cob_chooseFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_chooseFunction.Enabled = false;
            this.cob_chooseFunction.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_chooseFunction.FormattingEnabled = true;
            this.cob_chooseFunction.Location = new System.Drawing.Point(146, 104);
            this.cob_chooseFunction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cob_chooseFunction.Name = "cob_chooseFunction";
            this.cob_chooseFunction.Size = new System.Drawing.Size(141, 22);
            this.cob_chooseFunction.TabIndex = 17;
            this.cob_chooseFunction.DropDown += new System.EventHandler(this.cob_chooseFunction_DropDown);
            // 
            // txt_yPos
            // 
            this.txt_yPos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yPos.Location = new System.Drawing.Point(235, 21);
            this.txt_yPos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_yPos.Name = "txt_yPos";
            this.txt_yPos.Size = new System.Drawing.Size(52, 22);
            this.txt_yPos.TabIndex = 18;
            this.txt_yPos.Text = "10";
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
            // rad_function
            // 
            this.rad_function.AutoSize = true;
            this.rad_function.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_function.Location = new System.Drawing.Point(149, 20);
            this.rad_function.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rad_function.Name = "rad_function";
            this.rad_function.Size = new System.Drawing.Size(160, 18);
            this.rad_function.TabIndex = 27;
            this.rad_function.TabStop = true;
            this.rad_function.Text = "Funktionales Element";
            this.rad_function.UseVisualStyleBackColor = true;
            this.rad_function.CheckedChanged += new System.EventHandler(this.rad_usage_CheckedChanged);
            // 
            // rad_display
            // 
            this.rad_display.AutoSize = true;
            this.rad_display.Checked = true;
            this.rad_display.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_display.Location = new System.Drawing.Point(8, 20);
            this.rad_display.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rad_display.Name = "rad_display";
            this.rad_display.Size = new System.Drawing.Size(103, 18);
            this.rad_display.TabIndex = 28;
            this.rad_display.TabStop = true;
            this.rad_display.Text = "Beschriftung";
            this.rad_display.UseVisualStyleBackColor = true;
            this.rad_display.CheckedChanged += new System.EventHandler(this.rad_usage_CheckedChanged);
            // 
            // grp_objectKind
            // 
            this.grp_objectKind.Controls.Add(this.rad_display);
            this.grp_objectKind.Controls.Add(this.rad_function);
            this.grp_objectKind.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_objectKind.Location = new System.Drawing.Point(13, 12);
            this.grp_objectKind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_objectKind.Name = "grp_objectKind";
            this.grp_objectKind.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_objectKind.Size = new System.Drawing.Size(322, 51);
            this.grp_objectKind.TabIndex = 29;
            this.grp_objectKind.TabStop = false;
            this.grp_objectKind.Text = "Funktion des Objekts";
            // 
            // grp_sizePosition
            // 
            this.grp_sizePosition.Controls.Add(this.cmd_preview);
            this.grp_sizePosition.Controls.Add(this.txt_height);
            this.grp_sizePosition.Controls.Add(this.lbl_height);
            this.grp_sizePosition.Controls.Add(this.lbl_xPos);
            this.grp_sizePosition.Controls.Add(this.txt_xPos);
            this.grp_sizePosition.Controls.Add(this.lbl_width);
            this.grp_sizePosition.Controls.Add(this.txt_yPos);
            this.grp_sizePosition.Controls.Add(this.txt_width);
            this.grp_sizePosition.Controls.Add(this.lbl_yPos);
            this.grp_sizePosition.Location = new System.Drawing.Point(14, 212);
            this.grp_sizePosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_sizePosition.Name = "grp_sizePosition";
            this.grp_sizePosition.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_sizePosition.Size = new System.Drawing.Size(322, 122);
            this.grp_sizePosition.TabIndex = 30;
            this.grp_sizePosition.TabStop = false;
            this.grp_sizePosition.Text = "Größe und Position";
            // 
            // cmd_preview
            // 
            this.cmd_preview.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_preview.Location = new System.Drawing.Point(145, 91);
            this.cmd_preview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_preview.Name = "cmd_preview";
            this.cmd_preview.Size = new System.Drawing.Size(142, 25);
            this.cmd_preview.TabIndex = 32;
            this.cmd_preview.Text = "Anzeigen";
            this.cmd_preview.UseVisualStyleBackColor = true;
            this.cmd_preview.Click += new System.EventHandler(this.cmd_preview_Click);
            // 
            // txt_height
            // 
            this.txt_height.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_height.Location = new System.Drawing.Point(235, 53);
            this.txt_height.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(52, 22);
            this.txt_height.TabIndex = 28;
            this.txt_height.Text = "10";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_height.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(159, 56);
            this.lbl_height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(40, 14);
            this.lbl_height.TabIndex = 27;
            this.lbl_height.Text = "Höhe";
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
            this.grp_generals.Location = new System.Drawing.Point(13, 69);
            this.grp_generals.Name = "grp_generals";
            this.grp_generals.Size = new System.Drawing.Size(323, 137);
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
            // Form_CreateNewObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 376);
            this.Controls.Add(this.grp_generals);
            this.Controls.Add(this.grp_sizePosition);
            this.Controls.Add(this.grp_objectKind);
            this.Controls.Add(this.cmd_createObject);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_CreateNewObject";
            this.Text = "Neues Objekt erstellen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CreateNewObject_FormClosing);
            this.Load += new System.EventHandler(this.Form_CreateNewObject_Load);
            this.grp_objectKind.ResumeLayout(false);
            this.grp_objectKind.PerformLayout();
            this.grp_sizePosition.ResumeLayout(false);
            this.grp_sizePosition.PerformLayout();
            this.grp_generals.ResumeLayout(false);
            this.grp_generals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.Label lbl_xPos;
        private System.Windows.Forms.Label lbl_yPos;
        private System.Windows.Forms.TextBox txt_xPos;
        private System.Windows.Forms.Button cmd_createObject;
        private System.Windows.Forms.ComboBox cob_chooseFunction;
        private System.Windows.Forms.TextBox txt_yPos;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_objectName;
        private System.Windows.Forms.ComboBox cob_objectType;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.RadioButton rad_function;
        private System.Windows.Forms.RadioButton rad_display;
        private System.Windows.Forms.GroupBox grp_objectKind;
        private System.Windows.Forms.GroupBox grp_sizePosition;
        private System.Windows.Forms.GroupBox grp_generals;
        private System.Windows.Forms.Label lbl_function;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Button cmd_preview;
    }
}