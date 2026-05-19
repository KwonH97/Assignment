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
    public partial class Key_Form : Form
    {
        public Key_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_Mag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("마우스 왼쪽 버튼이 클릭");
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("마우스 오른쪽 버튼이 클릭");
            }
        }

        private void Txt_Memo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lbl_Mag.Text = Char.GetUnicodeCategory(e.KeyChar).ToString();
        }

        private void Txt_Memo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F1 && e.Shift) == true)
            {
                MessageBox.Show("텍스트 박스에서 F1 Key와 Shift Key가 눌러졌습니다.");
            }
        }

        private void Key_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F1 && e.Shift) == true)
            {
                MessageBox.Show("폼에서 F1 Key와 Shift Key를 인식했습니다.");
            }
        }
    }
}
