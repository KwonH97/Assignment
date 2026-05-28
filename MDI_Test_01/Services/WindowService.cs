using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI_Test_01.Services
{
    internal class WindowService
    {
        public void Newform(Form parent, ToolStripStatusLabel txtLabel, string title)
        {
            NewForm_Test nf = new NewForm_Test(txtLabel);
            nf.MdiParent = parent;
            nf.BringToFront();
            nf.Text = title;
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
                nf.MdiParent = parent;
                nf.BringToFront();
                nf.Show();
                txtLabel.Text = "불러오기 완료";
            }
            else
            {
                txtLabel.Text = "열기 취소";
            }
        }
        public void AllClose(Form parent)
        {
            foreach (Form form in parent.MdiChildren.ToList())
            {
                form.Close();
            }
        }

        public void Save(Form parent)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "텍스트문서(*.txt)|*.txt|모든 파일(*.*)|*.*";
            save.OverwritePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                string File_Name = save.FileName;

                StreamWriter stw = new StreamWriter(File_Name, false, Encoding.UTF8);

                stw.Write(Txt_Memo.Txt);
                stw.Flush();
                stw.Close();
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
