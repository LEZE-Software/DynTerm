namespace term
{
    partial class Form_NewEditFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NewEditFunction));
            this.pan_workbench = new System.Windows.Forms.Panel();
            this.cmd_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_list = new System.Windows.Forms.Label();
            this.lbl_saveSettings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_activate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.title_workbench = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_saveName = new System.Windows.Forms.Button();
            this.list_show = new System.Windows.Forms.ListBox();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.chb_activate = new System.Windows.Forms.CheckBox();
            this.images_activate = new System.Windows.Forms.ImageList(this.components);
            this.pan_workbench.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_workbench
            // 
            this.pan_workbench.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pan_workbench.Controls.Add(this.chb_activate);
            this.pan_workbench.Controls.Add(this.cmd_delete);
            this.pan_workbench.Controls.Add(this.list_show);
            this.pan_workbench.Controls.Add(this.cmd_saveName);
            this.pan_workbench.Controls.Add(this.label2);
            this.pan_workbench.Controls.Add(this.txt_name);
            this.pan_workbench.Controls.Add(this.cmd_save);
            this.pan_workbench.Controls.Add(this.label1);
            this.pan_workbench.Controls.Add(this.lbl_list);
            this.pan_workbench.Controls.Add(this.lbl_saveSettings);
            this.pan_workbench.Controls.Add(this.txt_comment);
            this.pan_workbench.Controls.Add(this.label6);
            this.pan_workbench.Controls.Add(this.lbl_activate);
            this.pan_workbench.Controls.Add(this.label4);
            this.pan_workbench.Controls.Add(this.title_workbench);
            this.pan_workbench.Location = new System.Drawing.Point(9, 9);
            this.pan_workbench.Name = "pan_workbench";
            this.pan_workbench.Size = new System.Drawing.Size(343, 330);
            this.pan_workbench.TabIndex = 9;
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
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 900;
            this.label1.Text = "Bezeichner";
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_list.Location = new System.Drawing.Point(10, 95);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(135, 16);
            this.lbl_list.TabIndex = 15;
            this.lbl_list.Text = "Vorhandene Funktionen";
            // 
            // lbl_saveSettings
            // 
            this.lbl_saveSettings.AutoSize = true;
            this.lbl_saveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saveSettings.Location = new System.Drawing.Point(10, 270);
            this.lbl_saveSettings.Name = "lbl_saveSettings";
            this.lbl_saveSettings.Size = new System.Drawing.Size(139, 15);
            this.lbl_saveSettings.TabIndex = 14;
            this.lbl_saveSettings.Text = "Einstellungen speichern";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(197, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Löschen";
            // 
            // lbl_activate
            // 
            this.lbl_activate.AutoSize = true;
            this.lbl_activate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.lbl_activate.Location = new System.Drawing.Point(197, 212);
            this.lbl_activate.Name = "lbl_activate";
            this.lbl_activate.Size = new System.Drawing.Size(61, 16);
            this.lbl_activate.TabIndex = 5;
            this.lbl_activate.Text = "Aktivieren";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(197, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kommentar";
            // 
            // title_workbench
            // 
            this.title_workbench.AutoSize = true;
            this.title_workbench.BackColor = System.Drawing.SystemColors.ControlLight;
            this.title_workbench.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_workbench.ForeColor = System.Drawing.Color.Crimson;
            this.title_workbench.Location = new System.Drawing.Point(5, 5);
            this.title_workbench.Name = "title_workbench";
            this.title_workbench.Size = new System.Drawing.Size(159, 19);
            this.title_workbench.TabIndex = 0;
            this.title_workbench.Text = "Funktionen bearbeiten";
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(15, 53);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(129, 23);
            this.txt_name.TabIndex = 908;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(197, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 909;
            this.label2.Text = "Übernehmen";
            // 
            // cmd_saveName
            // 
            this.cmd_saveName.BackColor = System.Drawing.SystemColors.Window;
            this.cmd_saveName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_saveName.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.cmd_saveName.Image = ((System.Drawing.Image)(resources.GetObject("cmd_saveName.Image")));
            this.cmd_saveName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_saveName.Location = new System.Drawing.Point(200, 53);
            this.cmd_saveName.Name = "cmd_saveName";
            this.cmd_saveName.Size = new System.Drawing.Size(129, 23);
            this.cmd_saveName.TabIndex = 910;
            this.cmd_saveName.Text = "OK!";
            this.cmd_saveName.UseVisualStyleBackColor = false;
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
            // txt_comment
            // 
            this.txt_comment.Enabled = false;
            this.txt_comment.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comment.Location = new System.Drawing.Point(200, 112);
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(129, 23);
            this.txt_comment.TabIndex = 2;
            this.txt_comment.Text = "< leer >";
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
            this.chb_activate.Text = "Aktivieren";
            this.chb_activate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_activate.UseVisualStyleBackColor = false;
            this.chb_activate.CheckedChanged += new System.EventHandler(this.chb_activate_CheckedChanged);
            // 
            // images_activate
            // 
            this.images_activate.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images_activate.ImageStream")));
            this.images_activate.TransparentColor = System.Drawing.Color.Transparent;
            this.images_activate.Images.SetKeyName(0, "dialog-ok.png");
            this.images_activate.Images.SetKeyName(1, "dialog-ok-apply.png");
            // 
            // Form_NewEditFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 346);
            this.Controls.Add(this.pan_workbench);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_NewEditFunction";
            this.ShowIcon = false;
            this.Text = "Funktionen";
            this.Load += new System.EventHandler(this.Form_NewEditFunction_Load);
            this.pan_workbench.ResumeLayout(false);
            this.pan_workbench.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_workbench;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.Label lbl_saveSettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_activate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label title_workbench;
        private System.Windows.Forms.ListBox list_show;
        private System.Windows.Forms.Button cmd_saveName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.CheckBox chb_activate;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.ImageList images_activate;
    }
}