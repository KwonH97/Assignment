using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Test01
{
    public partial class Dlg_Test : Form
    {
        public Dlg_Test()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Font_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Txt_Memo.Font =  fontDialog1.Font;
            }
        }

        private void Btn_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Txt_Memo.ForeColor = colorDialog1.Color;
            }
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트문서(*.txt)|*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = @"C:\Users\admin\Desktop\AI종목추천 프로젝트";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string File_Name = openFileDialog1.FileName;

                StreamReader str = new StreamReader(File_Name, Encoding.UTF8);

                Txt_Memo.Text = str.ReadToEnd();

                str.Close();
                
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트문서(*.txt)|*.txt|모든 파일(*.*)|*.*";
            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string File_Name = saveFileDialog1.FileName;

                StreamWriter stw = new StreamWriter(File_Name, false, Encoding.UTF8);

                stw.Write(Txt_Memo.Text);
                stw.Flush();
                stw.Close();

            }
        }
    }
}
