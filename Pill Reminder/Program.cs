using System;
using System.Windows.Forms;

namespace Pill_Reminder
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Reminder());
        }
    }
}
