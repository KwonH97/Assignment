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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_Modal_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.Text = "모달 대화상자";
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("입력하신 이름은 " + dlg.Txt_Name.Text + "입니다.");
            }
            
        }

        private void Btn_Modeless_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.Text = "모들리스 대화상자";

            dlg.Show();
        }
    }
}
