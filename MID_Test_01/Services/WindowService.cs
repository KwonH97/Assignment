using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
        public void Newform(Form parent, ToolStripStatusLabel txtLabel)
        {
            NewForm_Test nf = new NewForm_Test(txtLabel);
            nf.TopLevel = false;
            nf.Parent = parent;
            nf.BringToFront();
            nf.StartPosition = FormStartPosition.Manual;
            nf.Location = new Point(0, 48);
            nf.Show();
            txtLabel.Text = "새 문서 생성";
            
        }
        public void Open(Form parent, ToolStripStatusLabel txtLabel)
        {
            OpenFileDialog open = new OpenFileDialog();
            txtLabel.Text = "여는 중";
            open.Filter = "텍스트문서(*.txt)|*.txt|모든 파일(*.*)|*.*";
            open.FilterIndex = 1;
            open.InitialDirectory = @"C:\";

            if (open.ShowDialog() == DialogResult.OK) 
            {
                string fileName = open.FileName;
                string text = File.ReadAllText(fileName, Encoding.UTF8); ;
                NewForm_Test nf = new NewForm_Test(text, txtLabel);
                nf.TopLevel = false;
                nf.Parent = parent;
                nf.BringToFront();
                nf.StartPosition = FormStartPosition.Manual;
                nf.Location = new Point(0, 48);
                nf.Show();
                txtLabel.Text = "불러오기 완료";
            }
        }
        public void AllClose(Form parent)
        {
            foreach (Form form in parent.Controls.OfType<Form>().ToList())
            {
                form.Close();
            }
        }
        public void UpdateTime(ToolStripStatusLabel dateLabel, ToolStripStatusLabel timeLabel)
        {
            DateTime now = DateTime.Now;
            dateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
