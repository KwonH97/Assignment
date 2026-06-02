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

namespace ExecuteQuery
{
    public partial class ExecuteScalar : Form
    {
        public ExecuteScalar()
        {
            InitializeComponent();
        }
        String StrConn = @"Server=localhost;database=kh;uid=sa;pwd=std001;";
        public void scalar()
        {
            SqlConnection conn = new SqlConnection(StrConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_Name_Exam", conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@Num", SqlDbType.Int);
                p1.Value = Int32.Parse(textBox1.Text);
                com.Parameters.Add(p1);

                string name = com.ExecuteScalar().ToString();

                MessageBox.Show(name);
                textBox2.Text = name;
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
            scalar();
        }
    }
}
