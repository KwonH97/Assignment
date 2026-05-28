using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Test01
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new Main());
            //Application.Run(new Dlg_Test());
            //Application.Run(new Valid_Test());
            //Application.Run(new Tab_Test());
            Application.Run(new Key_Form());
            //Application.Run(new ImageForms());
            //Application.Run(new ListForm5());
            //Application.Run(new ThreadTest_01());
        }
    }
}
