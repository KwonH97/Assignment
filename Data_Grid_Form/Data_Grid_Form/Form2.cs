using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Grid_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string strConn = @"Server=localhost;database=kh;uid=sa;pwd=std001;";

        public void exam_insert()
        {
            SqlConnection conn = new SqlConnection(strConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_exam_insert_row", conn);
                com.CommandType = CommandType.StoredProcedure;
                //입력파라미터
                com.Parameters.AddWithValue("@department", Cbb_Department.Text);
                com.Parameters.AddWithValue("@name", Txt_Name.Text);
                com.Parameters.AddWithValue("@education", Txt_Edu.Text);
                com.Parameters.AddWithValue("@english", Int32.Parse(Txt_Eng.Text));
                com.Parameters.AddWithValue("@math", Int32.Parse(Txt_Math.Text));
                com.Parameters.AddWithValue("@sc", Cbb_Sc.Text);
                com.Parameters.AddWithValue("@id", Int32.Parse(Txt_Id.Text));
                com.ExecuteNonQuery();

                MessageBox.Show("저장완료");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            exam_insert();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Cbb_Department.SelectedIndex = -1;
            Cbb_Sc.SelectedIndex = -1;

            Txt_Name.Clear();
            Txt_Edu.Clear();
            Txt_Eng.Clear();
            Txt_Math.Clear();
            Txt_Id.Clear();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
