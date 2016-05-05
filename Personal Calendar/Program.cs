using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personal_Calendar.Migrations;

namespace Personal_Calendar
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new Configuration();
            var migrator = new System.Data.Entity.Migrations.DbMigrator(config);
            if (migrator.GetPendingMigrations().Any())
            {
                migrator.Update();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
