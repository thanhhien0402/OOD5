
using System;
using System.Windows.Forms;

namespace NguyenThiThanhHien_1150080092_lab2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // chạy Form1
        }
    }
}
