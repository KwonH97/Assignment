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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string strConn = @"Server=localhost;database=kh;uid=sa;pwd=std001;";

        public void update()
        {
            SqlConnection conn = new SqlConnection(strConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_exam_update_row", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@department", Cbb_Department.Text);
                com.Parameters.AddWithValue("@name", Txt_Name.Text);
                com.Parameters.AddWithValue("@education", Txt_Edu.Text);
                com.Parameters.AddWithValue("@english", Int32.Parse(Txt_Eng.Text));
                com.Parameters.AddWithValue("@math", Int32.Parse(Txt_Math.Text));
                com.Parameters.AddWithValue("@sc", Cbb_Sc.Text);
                com.Parameters.AddWithValue("@id", Int32.Parse(Txt_Id.Text));
                com.ExecuteNonQuery();

                MessageBox.Show("수정완료");
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
            update();
            Close();
        }
    }
}
