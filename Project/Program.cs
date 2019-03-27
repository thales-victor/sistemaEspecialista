using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        static Manager mgr;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mgr = new Manager();

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            Application.Run(new frmMain(mgr));
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            mgr.SaveAllData();
            MessageBox.Show("SAVED");
        }
    }
}
