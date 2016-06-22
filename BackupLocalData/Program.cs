using System;
using System.Windows.Forms;

namespace BackupLocalData
{
    static class Program
    {
        /// <summary>
        /// Simple Backup of local data
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
