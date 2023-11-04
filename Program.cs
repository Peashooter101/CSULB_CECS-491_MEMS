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
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // DatabaseInitializer.GetInstance().CheckDatabase("sample_mems");
            // DatabaseInitializer.GetInstance().CheckCollection("sample_mems", "blah");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
           Application.Run(new MainMenuWindow());
        }
    }
}