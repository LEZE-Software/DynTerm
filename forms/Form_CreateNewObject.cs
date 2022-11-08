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

        private void Form_CreateNewObject_FormClosing(object sender, FormClosingEventArgs e)
        {
    
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
    }
}
