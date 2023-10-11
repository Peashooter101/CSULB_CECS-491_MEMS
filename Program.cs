using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace MEMS
{
    static class Program
    {
        private static DatabaseContext _dbContext;
        public static MongoClient client = new MongoClient(Environment.GetEnvironmentVariable("MONGO_DB_URI"));
        
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
           // Application.Run(new MaintenanceReminderWindow());
           
           
           // Application.Run(new MaintenanceLogWindow());
           Application.Run(new ListMachinesWindow());
        }
    }
}