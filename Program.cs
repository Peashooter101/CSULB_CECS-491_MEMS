using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AccountCreationWindow());
            //Application.Run(new NewMaintenanceWindow());
           

           //Application.Run(new ListMachinesWindow());
           Application.Run(new MaintenanceReminderWindow());
        }
    }
}