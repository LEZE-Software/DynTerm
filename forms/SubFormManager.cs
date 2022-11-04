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

        public static void CloseSubForm(SubFormIndex idx)
        {
            switch(idx)
            {
                case SubFormIndex.Traffic:
                    {
                        form_traffic.Close();
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            }

            listOfForms[(int)idx] = false;
        }

        public static void OpenSubForm(SubFormIndex idx, Form_Center main)
        {
            bool usePreform = false;
            bool openDialog = false;

            Form formToOpen = new Form();

            listOfForms[(int)idx] = true;

            switch (idx)
            {
                case SubFormIndex.Playground:
                    {
                        usePreform = true;
                        formToOpen = new Form_Playground(main)
                        {
                            MdiParent = main
                        };
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
                case SubFormIndex.NewRule:
                    {
                        usePreform = true;
                        formToOpen = new Form_CreateNewRule(main)
                        {
                            MdiParent = main
                        };
                        break;
                    }
                case SubFormIndex.NewFunction:
                case SubFormIndex.EditFunction:
                    {
                        bool edit = (idx == SubFormIndex.EditFunction);

                        usePreform = true;
                        formToOpen = new Form_NewEditFunction(edit)
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
            switch(idx)
            {
                case SubFormIndex.Traffic:
                    {
                        return listOfForms[(int)idx];
                    }
            }

            return false;
        }

        public enum SubFormIndex
        {
            Playground,
            NewObject,
            NewRule,
            NewFunction,
            EditFunction,
            Traffic,
            SerialSettings,
            LAST_INDEX
        }
    }
}
