using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Txt_ID.Text.Length > 0 && Txt_Pass.Text.Length > 0)
            {
                MessageBox.Show(Txt_ID.Text + "님 반갑습니다.");
            }
            else if(Txt_ID.Text.Length == 0)
            {
                MessageBox.Show("아이디를 입력해 주세요.","확인i",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (Txt_Pass.Text.Length == 0)
            {
                MessageBox.Show("비번을 입력해 주세요.", "확인p", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Lbl_Pass_Click(object sender, EventArgs e)
        {

        }

        private void Log_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void Btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close(); // 해당 창만 닫기
            //Application.Exit(); // 모든프로그램 끄기
        }

        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("종료할까요","확인f",MessageBoxButtons.YesNo/*,MessageBoxIcon.Question*/) == DialogResult.Yes)
            {
                e.Cancel = false;
                //e.Cancel = true;
            }
            else
            {
                e.Cancel = true;
                //e.Cancel = false;
            }

        }
    }
}
