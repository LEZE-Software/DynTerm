using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term
{
    public static class SubFormManager
    {
        private static bool[] listOfForms = new bool[(int)SubFormIndex.LAST_INDEX];

        // MDI childs.
        public static Form_SerialTraffic form_traffic;
        public static Form_Playground form_playground;
        public static Form_Settings form_settings;

        /// <summary>
        /// Use this function to reset the check value in the list of forms.
        /// </summary>
        /// <param name="idx"></param>
        public static void ExternCloseSubForm(SubFormIndex idx)
        {
            listOfForms[(int)idx] = false;
        }

        /// <summary>
        /// Use this funciton to close a subform via the main menu.
        /// </summary>
        /// <param name="idx"></param>
        public static void CloseSubForm(SubFormIndex idx)
        {
            switch(idx)
            {
                case SubFormIndex.Traffic:
                    {
                        form_traffic.Close();
                        ExternCloseSubForm(idx);
                        break;
                    }
                case SubFormIndex.Playground:
                    {
                        form_playground.Close();
                        ExternCloseSubForm(idx);
                        break;
                    }
                case SubFormIndex.Settings:
                    {
                        form_settings.Close();
                        ExternCloseSubForm(idx);
                        break;
                    }
                default:
                    {
                        //throw new NotImplementedException();
                        break;
                    }
            }
        }

        public static void OpenSubForm(SubFormIndex idx, Form_Center main, bool openToEdit)
        {
            bool usePreform = false;
            bool openDialog = false;

            Form formToOpen = new Form();

            listOfForms[(int)idx] = true;

            switch (idx)
            {
                case SubFormIndex.Playground:
                    {
                        form_playground = new Form_Playground(main)
                        {
                            MdiParent = main
                        };

                        form_playground.Show();
                        break;
                    }
                case SubFormIndex.Traffic:
                    {
                        form_traffic = new Form_SerialTraffic(main)
                        {
                            MdiParent = main
                        };

                        form_traffic.Show();
                        break;
                    }
                case SubFormIndex.SerialSettings:
                    {
                        usePreform = true;
                        openDialog = true;

                        formToOpen = new Form_SerialConnection();
                        break;
                    }
                case SubFormIndex.RuleEditor:
                    {
                        usePreform = true;
                        formToOpen = new Form_NewEditRule(main, openToEdit)
                        {
                            MdiParent = main
                        };
                        break;
                    }
                case SubFormIndex.FunctionEditor: 
                    {                  
                        usePreform = true;
                        formToOpen = new Form_NewEditFunction(openToEdit)
                        {
                            MdiParent = main
                        };
                        break;
                    }
                case SubFormIndex.Settings:
                    {
                        form_settings = new Form_Settings(main)
                        {
                            MdiParent = main
                        };

                        form_settings.Show();
                        break;
                    }
                case SubFormIndex.PanelEditor:
                    {
                        usePreform = true;
                        formToOpen = new Form_PanelWizard(main, openToEdit)
                        {
                            MdiParent = main
                        };
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            }

            if(usePreform)
            {
                if(openDialog)
                {
                    formToOpen.ShowDialog();
                }
                else
                {
                    formToOpen.Show();
                }
            }
        }

        public static bool IsFormOpen(SubFormIndex idx)
        {
            return listOfForms[(int)idx];
        }

        public enum SubFormIndex
        {
            Playground,
            PanelEditor,
            RuleEditor,
            FunctionEditor,
            Traffic,
            SerialSettings,
            Settings,
            LAST_INDEX
        }
    }
}
