using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MID_Test_01.Services
{
    internal class WindowService
    {
        public void Newform(Form parent)
        {
            NewForm_Test nf = new NewForm_Test();
            nf.TopLevel = false;
            nf.Parent = parent;
            nf.BringToFront();
            nf.StartPosition = FormStartPosition.Manual;
            nf.Location = new Point(0, 48);
            nf.Show();
        }
        public void Open(Form parent)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "텍스트문서(*.txt)|*.txt|모든 파일(*.*)|*.*";
            open.FilterIndex = 1;
            open.InitialDirectory = @"C:\";

            if (open.ShowDialog() == DialogResult.OK) 
            {
                string fileName = open.FileName;
                string text = File.ReadAllText(fileName, Encoding.UTF8); ;
                NewForm_Test nf = new NewForm_Test(text);
                nf.TopLevel = false;
                nf.Parent = parent;
                nf.BringToFront();
                nf.StartPosition = FormStartPosition.Manual;
                nf.Location = new Point(0, 48);
                nf.Show();
            }
        }
    }
}
