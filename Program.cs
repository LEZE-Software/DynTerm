using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread thread1 = new Thread(StateMachine);
            thread1.Start();

            Serial_Manager.Initialize();
            RuleManager.Initialize();
            SubFormManager.Initialize();

            Application.Run(new Form_Center());
        }

        static void StateMachine()
        {
            while (true)
            {
            }
        }
    }
}
