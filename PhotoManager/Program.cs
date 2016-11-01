using DevExpress.XtraSplashScreen;
using PhotoManager.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseAlways<PmContext>());
            using (var pmContext = new PmContext())
            {
                pmContext.Database.Initialize(force: true);
            }
            SplashScreenManager.ShowForm(typeof(SplashScreen1));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            SplashScreenManager.CloseForm();
        }
    }
}
