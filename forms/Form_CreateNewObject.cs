using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term
{
    public partial class Form_CreateNewObject : Form
    {
        public Form_CreateNewObject(Form_Center mainFM)
        {
            this.mainFM = mainFM;
            InitializeComponent();
        }

        #region Locales
        Form_Center mainFM;

        int buttonAction = 0;
        bool changingTabIndexFromCombo = false;
        #endregion

        private ControlObject GetTargetObjectForButton()
        {
            if(rad_addItemToCombo.Checked)
            {
                foreach(ControlObject c in mainFM.AllObjects)
                {
                    if(c.rootObject.Name== cob_insertIntoCombo.Text)
                    {
                        return c;
                    }
                }
            }
            else if(rad_displayObjectOnClick.Checked)
            {
                foreach (ControlObject c in mainFM.AllObjects)
                {
                    if (c.rootObject.Name == cob_hideObject.Text)
                    {
                        return c;
                    }
                }
            }

            return null;
        }

        private ControlObject GetSourceObjectForButton()
        {
            if(rad_addItemToCombo.Checked)
            {
                foreach (ControlObject c in mainFM.AllObjects)
                {
                    if (c.rootObject.Name == cob_objectToInsertIntoCombo.Text)
                    {
                        return c;
                    }
                }
            }
            else if(rad_displayObjectOnClick.Checked)
            {
                foreach (ControlObject c in mainFM.AllObjects)
                {
                    if (c.rootObject.Name == cob_hideObject.Text)
                    {
                        return c;
                    }
                }
            }
            else if(rad_sendSerialOnClick.Checked)
            {
                foreach (ControlObject c in mainFM.AllObjects)
                {
                    if (c.rootObject.Name == cob_sendSerialSource.Text)
                    {
                        return c;
                    }
                }
            }

            return null;
        }      

        private void Form_CreateNewObject_FormClosing(object sender, FormClosingEventArgs e)
        {
    
        }

        private void rad_buttonAction_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton senderButton = sender as RadioButton;

            buttonAction = Convert.ToInt32(senderButton.Tag);

            cob_sendSerialAction.Enabled =
                txt_hardSetSerialAnswerSendOnButton.Enabled =
                cob_sendSerialSource.Enabled = rad_sendSerialOnClick.Checked;

            cob_hideObject.Enabled = rad_displayObjectOnClick.Checked;

            cob_insertIntoCombo.Enabled =
                cob_objectToInsertIntoCombo.Enabled = rad_addItemToCombo.Checked;
        }

        private void rad_labelUsage_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_serialPortLabel.Checked)
            {
                txt_content.Text = "#Verbindung";
                txt_content.Enabled = false;
            }
            else
            {
                txt_content.Text = "";
                txt_content.Enabled = true;
            }
        }

        private void pan_Color_Click(object sender, EventArgs e)
        {
            Panel senderPanel = sender as Panel;

            ColorDialog cd = new ColorDialog()
            {
                Color = senderPanel.BackColor
            };

            cd.ShowDialog();

            senderPanel.BackColor = cd.Color;

        }

        private void ClickEventForNewButton(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;
            ControlObject parentObject = new ControlObject();

            // Get parent object.
            foreach(ControlObject c in mainFM.AllObjects)
            {
                if(c.rootObject.Name==senderButton.Name)
                {
                    parentObject = c;
                }
            }

            switch((Int32)senderButton.Tag)
            {
                case (Int32)ButtonActionIndex.SendSerial:
                    {
                        string text=""; 
                        // Select where the serial message shall come from.
                        switch(parentObject.local_buttonAction.messageSourceIndex)
                        {
                            case (Int32)SendOnClickMessageSourceIndex.HardSetMessage:
                                {
                                    text = parentObject.local_buttonAction.serialMessageToSend;
                                    break;
                                }
                            case (Int32)SendOnClickMessageSourceIndex.FromComboBox:
                            case (Int32)SendOnClickMessageSourceIndex.FromTextBox:
                                {
                                    text = parentObject.local_buttonAction.sourceObject.rootObject.Text;

                                    break;
                                }                         
                        }

                        Serial_functions.SendCommand(text);
                        break;
                    }
                case (Int32)ButtonActionIndex.OpenClosePort:
                    {
                        Serial_functions.OpenClosePort();
                        break;
                    }
                case (Int32)ButtonActionIndex.ShowHideObject:
                    {
                        bool current = parentObject.local_buttonAction.targetObject.rootObject.Visible;

                        parentObject.local_buttonAction.targetObject.rootObject.Visible = !current;

                        break;
                    }
            }
        }      

        #region Button
        // Display preview element.
        private void cmd_preview_Click(object sender, EventArgs e)
        {
            Props.previewIndex = (PreviewObjectIndex)cob_objectType.SelectedIndex;
            Props.previewMode = true;

            Point objectLocation = new Point(10,10);
            try
            {
                switch (Props.previewIndex)
                {
                    case PreviewObjectIndex.Label:
                        {
                            SubFormManager.form_playground.lbl_preview.Text = txt_content.Text;
                            SubFormManager.form_playground.lbl_preview.Visible = true;
                            SubFormManager.form_playground.lbl_preview.Location = objectLocation;
                            break;
                        }
                    case PreviewObjectIndex.Textbox:
                        {
                            SubFormManager.form_playground.txt_preview.Visible = true;
                            SubFormManager.form_playground.txt_preview.Location = objectLocation;
                            break;
                        }
                    case PreviewObjectIndex.Button:
                        {
                            SubFormManager.form_playground.cmd_preview.Text = txt_content.Text;
                            SubFormManager.form_playground.cmd_preview.Visible = true;
                            SubFormManager.form_playground.cmd_preview.Location = objectLocation;
                            break;
                        }
                    case PreviewObjectIndex.Combo:
                        {
                            SubFormManager.form_playground.cob_preview.Visible = true;
                            SubFormManager.form_playground.cob_preview.Location = objectLocation;
                            break;
                        }
                }
            }
            catch
            {
                // Nothing.
            }
        }

        // Create new object.
        private void cmd_createObject_Click(object sender, EventArgs e)
        {
            #region Locales.
            dynamic newRootObject = null;

            Color
                textColor = pan_textColor.BackColor,
                backColor = pan_backColor.BackColor;

            string
                objectName = txt_objectName.Text,
                objectContent = txt_content.Text;

            bool
                textBoxShallBeReadOnly = chb_textBoxIsReadOnly.Checked;

            int
                newObjectIndex = cob_objectType.SelectedIndex,
                parentFunctionIndex = cob_chooseFunction.SelectedIndex;
            #endregion

            ControlObject newObject = new ControlObject()
            {
                objectIndex = newObjectIndex,
                rootObject = newRootObject,
                commonBackColor = backColor,
                commonFontColor = textColor
            };

            switch (newObjectIndex)
            {
                case (Int32)PreviewObjectIndex.Label:
                    {
                        Label newLabel = new Label()
                        {
                            Name = "lbl_" + objectName,
                            Text = objectContent,
                            Location = SubFormManager.form_playground.lbl_preview.Location,
                            Width = SubFormManager.form_playground.lbl_preview.Width,
                            Height = SubFormManager.form_playground.lbl_preview.Height,
                            BackColor = backColor,
                            ForeColor = textColor
                        };

                        newObject.parentFunction = mainFM.AllFunctions[parentFunctionIndex];
                        newRootObject = newLabel;
                        newObject.rootObject = newRootObject;

                        break;
                    }
                case (Int32)PreviewObjectIndex.Textbox:
                    {
                        TextBox newTextBox = new TextBox()
                        {
                            Name = "txt_" + objectName,
                            Text = objectContent,
                            Location = SubFormManager.form_playground.txt_preview.Location,
                            Width = SubFormManager.form_playground.txt_preview.Width,
                            Height = SubFormManager.form_playground.txt_preview.Height,
                            BackColor = backColor,
                            ForeColor = textColor
                        };

                        newRootObject = newTextBox;
                        newObject.rootObject = newRootObject;

                        break;
                    }
                case (Int32)PreviewObjectIndex.Combo:
                    {
                        ComboBox newCombo = new ComboBox()
                        {
                            Name = "cob_" + objectName,
                            Text = objectContent,
                            Location = SubFormManager.form_playground.cob_preview.Location,
                            Width = SubFormManager.form_playground.cob_preview.Width,
                            Height = SubFormManager.form_playground.cob_preview.Height,
                            BackColor = backColor,
                            ForeColor = textColor,
                        };

                        newRootObject = newCombo;
                        newObject.rootObject = newRootObject;

                        break;
                    }
                case (Int32)PreviewObjectIndex.Button:
                    {
                        Button newButton = new Button()
                        {
                            Name = "cmd_" + objectName,
                            Text = objectContent,
                            Location = SubFormManager.form_playground.cmd_preview.Location,
                            Width = SubFormManager.form_playground.cmd_preview.Width,
                            Height = SubFormManager.form_playground.cmd_preview.Height,
                            BackColor = backColor,
                            ForeColor = textColor,
                        };

                        newButton.Tag = this.buttonAction;
                        newButton.Click += new EventHandler(ClickEventForNewButton);

                        ButtonAction localButton = new ButtonAction()
                        {
                            actionIndex = this.buttonAction,
                            messageSourceIndex = cob_sendSerialSource.SelectedIndex,
                            mouseKeyIndex = MouseClickIndex.SingleClick,

                            sourceObject = GetSourceObjectForButton(),
                            targetObject = GetTargetObjectForButton(),
                        };

                        newRootObject = newButton;
                        newObject.local_buttonAction = localButton;
                        newObject.rootObject = newRootObject;

                        break;
                    }
                case (Int32)PreviewObjectIndex.Invalid:
                    {
                        // Object is invalid and will not be created.
                        break;
                    }
            }

            mainFM.AllObjects.Add(newObject);
            SubFormManager.form_playground.Controls.Add(newRootObject);
            mainFM.AllFunctions[parentFunctionIndex].targetObjects.Add(newRootObject);

            // Hide preview items on the playground.
            SubFormManager.form_playground.lbl_preview.Visible =
                SubFormManager.form_playground.cmd_preview.Visible =
                SubFormManager.form_playground.txt_preview.Visible = false;

            // Restore objects on the form.
            txt_content.Text =
                txt_objectName.Text = "";
            cob_chooseFunction.SelectedIndex =
                cob_objectType.SelectedIndex = -1;
        }
        #endregion

        #region ComboBoxes
        // Update the items of the comboBox to select the parentFunction.
        private void cob_chooseFunction_DropDown(object sender, EventArgs e)
        {
            ComboBox senderBox = sender as ComboBox;

            senderBox.Items.Clear();
            foreach (Function f in mainFM.AllFunctions)
            {
                senderBox.Items.Add(f.name);
            }
        }

        // Select which object shall be hidden at click.
        private void cob_chooseObjectToHide_DropDown(object sender, EventArgs e)
        {
            cob_hideObject.Items.Clear();
            foreach (ControlObject c in mainFM.AllObjects)
            {
                cob_hideObject.Items.Add(c.rootObject.Name);
            }
        }

        // Select the kind of new object to create.
        private void cob_objectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cob_objectType.SelectedIndex;
            changingTabIndexFromCombo = true;
            tabC_object.SelectedIndex = index;
            changingTabIndexFromCombo = false;
        }

        // Select where the content to send comes from.
        private void cob_sendSerialChooseKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderBox = sender as ComboBox;

            switch (senderBox.SelectedIndex)
            {
                case (Int32)SendOnClickMessageSourceIndex.HardSetMessage:
                    {
                        cob_sendSerialSource.Visible = false;
                        txt_hardSetSerialAnswerSendOnButton.Visible = true;
                        break;
                    }
                case (Int32)SendOnClickMessageSourceIndex.FromComboBox:
                    {
                        txt_hardSetSerialAnswerSendOnButton.Visible = false;
                        cob_sendSerialSource.Visible = true;
                        cob_sendSerialSource.Items.Clear();

                        foreach (ControlObject c in mainFM.AllObjects)
                        {
                            if (c.objectIndex == (Int32)PreviewObjectIndex.Combo)
                            {
                                cob_sendSerialSource.Items.Add(c.rootObject.Name);
                            }
                        }
                        break;
                    }
                case (Int32)SendOnClickMessageSourceIndex.FromTextBox:
                    {
                        txt_hardSetSerialAnswerSendOnButton.Visible = false;
                        cob_sendSerialSource.Visible = true;
                        cob_sendSerialSource.Items.Clear();

                        foreach (ControlObject c in mainFM.AllObjects)
                        {
                            if (c.objectIndex == (Int32)PreviewObjectIndex.Textbox)
                            {
                                cob_sendSerialSource.Items.Add(c.rootObject.Name);
                            }
                        }
                        break;
                    }
            }
        }
        #endregion

        private void tabC_object_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(changingTabIndexFromCombo==false)
            {
                cob_objectType.SelectedIndex = tabC_object.SelectedIndex;
            }
        }
    }
}
