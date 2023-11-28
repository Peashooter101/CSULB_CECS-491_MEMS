using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEMS.Windows;
using MongoDB.Driver;

namespace MEMS
{
    static class Program
    {
        //private static DatabaseContext _dbContext;
        //public static MongoClient client = new MongoClient(Environment.GetEnvironmentVariable("MONGO_DB_URI"));
        //public static string memsDbName = "mems_test";
        public static UserRole.User currentUser;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // DatabaseInitializer.GetInstance().CheckDatabase("sample_mems");
            // DatabaseInitializer.GetInstance().CheckCollection("sample_mems", "blah");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AccountCreationWindow());
            
            // Application.Run(new NewMaintenanceWindow());
           

           // Application.Run(new ListMachinesWindow());
           //Application.Run(new MaintenanceReminderWindow());

           //Application.Run(new MaintenanceLogWindow());
           //Application.Run(new ListMachinesWindow());
           Application.Run(new MainMenuWindow());
           
           
           //mongodb+srv://seancollins362:3RfZG5Fs4qPg863n@cluster0.1j1jtdz.mongodb.net/
           //Environment.SetEnvironmentVariable("MEMS_CONNECTION_STRING", null, EnvironmentVariableTarget.User);
           // if (Environment.GetEnvironmentVariable("MEMS_CONNECTION_STRING", EnvironmentVariableTarget.User) != null)
           // {
           //     Application.Run(new LoginWindow());
           // }
           // else
           // {
           //     Application.Run(new DatabaseConnectionWindow()); 
           // }
           
        }
    }
}