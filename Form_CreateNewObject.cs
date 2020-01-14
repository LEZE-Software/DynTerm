using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form_CreateNewObject : Form
    {
        public Form_CreateNewObject(Form_Center mainFM)
        {
            this.mainFM = mainFM;
            InitializeComponent();
        }

        Form_Center mainFM;

        private void Form_CreateNewObject_Load(object sender, EventArgs e)
        {

        }

        private void cmd_preview_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_xPos.Text != "" && txt_width.Text != "" && txt_yPos.Text != "")
                {
                    int
                        x = Convert.ToInt32(txt_xPos.Text),
                        y = Convert.ToInt32(txt_yPos.Text),
                        width = Convert.ToInt32(txt_width.Text);

                    Point newLocation = new Point(x, y);

                    switch (cob_objectType.SelectedIndex)
                    {
                        case (Int32)Props.ObjectIndex.Label:
                            {
                                mainFM.ref_playground.lbl_preview.Width = width;
                                mainFM.ref_playground.lbl_preview.Visible = true;
                                mainFM.ref_playground.lbl_preview.Location = newLocation;
                                break;
                            }
                        case (Int32)Props.ObjectIndex.Textbox:
                            {
                                mainFM.ref_playground.txt_preview.Width = width;
                                mainFM.ref_playground.txt_preview.Visible = true;
                                mainFM.ref_playground.txt_preview.Location = newLocation;
                                break;
                            }
                    }
                }
            }
            catch
            {
                // Nothing.
            }

        }

        private void cmd_createObject_Click(object sender, EventArgs e)
        {
            dynamic newTargetObject = null;
            TextBox newTextBox = null;
            Label newLabel;
            ComboBox newComboBox;
            Button newButton;

            string
                objectName = txt_objectName.Text,
                objectContent = txt_content.Text;

            bool connectToFunction = rad_function.Checked;

            int
                objectCobIndex = cob_objectType.SelectedIndex,
                functionIndex = cob_chooseFunction.SelectedIndex,
                x_pos = Convert.ToInt32(txt_xPos.Text),
                y_pos = Convert.ToInt32(txt_yPos.Text),
                width = Convert.ToInt32(txt_width.Text);

            // Check if the content shall be set or not.
            if (objectContent == "" && connectToFunction)
            {
                if (objectCobIndex == (Int32)Props.ObjectIndex.Label)
                {
                    objectContent = "leer";
                }
            }
            else if (objectContent == "" && !connectToFunction)
            {
                MessageBox.Show("Displayobjekte dürfen nicht leer sein!");
                objectCobIndex = (Int32)Props.ObjectIndex.Invalid;
            }

            Point newLocation = new Point(x_pos, y_pos);

            switch (objectCobIndex)
            {
                case (Int32)Props.ObjectIndex.Label:
                    {
                        newLabel = new Label()
                        {
                            Name = "lbl_" + objectName,
                            Text = objectContent,
                            Location = newLocation,
                            Width = width
                        };

                        newTargetObject = newLabel;
                        break;
                    }
                case (Int32)Props.ObjectIndex.Textbox:
                    {
                        newTextBox = new TextBox()
                        {
                            Name = "txt_" + objectName,
                            Text = objectContent,
                            Location = newLocation,
                            Width = width
                        };

                        newTargetObject = newTextBox;

                        break;
                    }

                case (Int32)Props.ObjectIndex.Invalid:
                    {
                        // Object is invalid and will not be created.
                        break;
                    }
            }

            //newTargetObject.Parent = mainFM.ref_playground;
            mainFM.ref_playground.Controls.Add(newTargetObject);

            if (newTargetObject != null && connectToFunction)
            {
                mainFM.AllFunctions[functionIndex].targetObjects.Add(newTargetObject);
                mainFM.AllFunctions[functionIndex].textboxes.Add(newTextBox);
            }
            else if (newTargetObject == null && !connectToFunction)
            {
                if (objectCobIndex != (Int32)Props.ObjectIndex.Invalid)
                {
                    MessageBox.Show("newTargetObject=null");
                }
            }

            // Hide preview items on the playground.
            mainFM.ref_playground.lbl_preview.Visible =
                mainFM.ref_playground.txt_preview.Visible = false;

            // Restore objects on the form.
            txt_content.Text =
                txt_objectName.Text = "";
            cob_chooseFunction.SelectedIndex =
                cob_objectType.SelectedIndex = -1;
            rad_function.Checked = false;
        }

        private void cob_chooseFunction_DropDown(object sender, EventArgs e)
        {
            ComboBox senderBox = sender as ComboBox;

            senderBox.Items.Clear();
            foreach (Function f in mainFM.AllFunctions)
            {
                senderBox.Items.Add(f.name);
            }
        }

        private void Form_CreateNewObject_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainFM.ref_playground.lbl_preview.Visible =
                mainFM.ref_playground.txt_preview.Visible = false;

            mainFM.ref_newObject = null;         
        }

        private void rad_usage_CheckedChanged(object sender, EventArgs e)
        {
            cob_chooseFunction.Enabled = rad_function.Checked;
        }
    }
}
