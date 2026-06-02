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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExecuteQuery
{
    public partial class ExecuteReader : Form
    {
        public ExecuteReader()
        {
            InitializeComponent();
        }

        String StrConn = @"Server=localhost;database=kh;uid=sa;pwd=std001;";

        public void select()
        {
            SqlConnection conn = new SqlConnection(StrConn);

            try
            {

                conn.Open();
                SqlCommand com = new SqlCommand("proc_Exam", conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = com.ExecuteReader();

                listBox1.Items.Clear();

                string rec;

                while (reader.Read())
                {
                    rec = String.Format("{0} {1} {2} {3} {4} {5} {6}",
                    reader["부서"],
                    reader["성명"],
                    reader["학력"],
                    reader["영어"],
                    reader["수학"],
                    reader["전형구분"],
                    reader["수험번호"]);
                    listBox1.Items.Add(rec);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB연결 실패");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select();
        }
    }
}
