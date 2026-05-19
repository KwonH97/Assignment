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
    public partial class ImageForms : Form
    {
        public ImageForms()
        {
            InitializeComponent();
        }

        private void ImageForms_Load(object sender, EventArgs e)
        {
            Lbl_Message.Text = "준비되었습니다.";
        }

        private void Btn_Undo_Click(object sender, EventArgs e)
        {
            Txt_Memo.Undo();
            Lbl_Message.Text = "실행이 취소되었습니다.";
        }

        private void Btn_Copy_Click(object sender, EventArgs e)
        {
            if(Txt_Memo.SelectionLength > 0)
            {
                Txt_Memo.Copy();
                Lbl_Message.Text = "복사가 되었습니다.";
            }
            else
            {
                MessageBox.Show("영역을 선택하세요");
            }
        }
        private void Btn_Paste_Click(object sender, EventArgs e)
        {
            Txt_Memo.Paste();
        }

        private void Btn_Cut_Click(object sender, EventArgs e)
        {
            if (Txt_Memo.SelectionLength > 0)
            {
                Txt_Memo.Cut();
                Lbl_Message.Text = "선택된 영역이 잘라졌다고...";
            }
            else
            {
                MessageBox.Show("영역을 선택하세요");
            }
        }
    }
}
