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
    public partial class Tab_Test : Form
    {
        public Tab_Test()
        {
            InitializeComponent();
        }

        private void Tab_Test_Load(object sender, EventArgs e)
        {
            for(int i = 7; i < 128; i++)
            {
                Cmb_Size.Items.Add(i);
            }
            Cmb_Size.Text = Cmb_Size.Items[5].ToString();

            foreach (FontFamily fontname in FontFamily.Families)
            {
                Cmb_Font.Items.Add(fontname.Name);
            }
            Cmb_Font.Text = Cmb_Font.Items[0].ToString();

            Cmb_Style.Items.Add(FontStyle.Bold);
            Cmb_Style.Items.Add(FontStyle.Italic);
            Cmb_Style.Items.Add(FontStyle.Underline);
            Cmb_Style.Items.Add(FontStyle.Strikeout);

            Cmb_Style.Text = Cmb_Style.Items[0].ToString();

            Cmb_Color.Items.Add(Color.Red.Name);
            Cmb_Color.Items.Add(Color.Blue.Name);
            Cmb_Color.Items.Add(Color.Orange.Name);
            Cmb_Color.Items.Add(Color.Black.Name);

            Cmb_Color.Text= Cmb_Color.Items[0].ToString();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            String Font_Name = Cmb_Font.SelectedItem.ToString();
            int Font_Size = Int32.Parse(Cmb_Size.SelectedItem.ToString());
            FontStyle Font_Style = (FontStyle)Cmb_Style.SelectedItem;

            Lbl_Text.Font = new Font(Font_Name, Font_Size, Font_Style);
            Lbl_Text.ForeColor = Color.FromName(Cmb_Color.Text);

        }

        private void Btn_Radio_Ok_Click(object sender, EventArgs e)
        {
            String Order = "";

            foreach (RadioButton rb in Gb_Food.Controls)
            {
                if(rb.Checked == true)
                {
                    Order = rb.Text;
                }
            }

            foreach (RadioButton rb in Gb_App.Controls)
            {
                if (rb.Checked == true)
                {
                    Order += ", " + rb.Text;
                }
            }

            if (MessageBox.Show("주문하신 메뉴와 음료수는 " + Order + "입니다. 주문하시겠습니까?", "확인",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                MessageBox.Show("주문이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("주문이 취소되었습니다.");
            }
        }

        private void Btn_Chk_Ok_Click(object sender, EventArgs e)
        {
            string Order = "";

            foreach (CheckBox cb in GB_Part.Controls)
            {
                if(cb.Checked == true)
                {
                    Order += ", " + cb.Text;
                }
            }
            if (MessageBox.Show("주문하신 부품은 " + Order + "입니다. 주문하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("주문이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("주문이 취소되었습니다.");
            }
        }

    }
}
