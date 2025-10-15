using System;
using System.Windows.Forms;

namespace Time_Capsule
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 🏁 Start with the RegisterForm
            Application.Run(new RegisterForm());
        }
    }
}
