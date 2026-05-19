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
    public partial class Valid_Test : Form
    {
        public Valid_Test()
        {
            InitializeComponent();
        }
        private void Txt_Name_Validating(object sender, CancelEventArgs e)
        {
            if(Txt_Name.Text.Length == 0)
            {
                Lbl_Massage.Text = "이름을 입력하세요";
                e.Cancel = true;
            }
        }

        private void Txt_Name_Validated(object sender, EventArgs e)
        {
            Lbl_Massage.Text = "";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            Close();
        }

        private void Txt_Email_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_Email.Text.Length == 0)
            {
                Lbl_Massage.Text = "이메일을 입력하세요";
                e.Cancel = true;
            }
            else if (Txt_Email.Text.IndexOf("@") == -1)
            {
                Lbl_Massage.Text = "이메일 입력 형식을 지키세요";
                e.Cancel = true;
            }
            
        }

        private void Txt_Email_Validated(object sender, EventArgs e)
        {
            Lbl_Massage.Text = "";
        }

        private void Txt_Num_Validating(object sender, CancelEventArgs e)
        {
            bool result=Int32.TryParse(Txt_Num.Text, out int value);
            
            if (Txt_Num.Text.Length == 0)
            {
                Lbl_Massage.Text = "전화번호를 입력하세요";
                e.Cancel = true;
            }else if (!result)
            {
                Lbl_Massage.Text = "숫자를 입력하세요";
                e.Cancel = true;
            }
        }
    }
}
