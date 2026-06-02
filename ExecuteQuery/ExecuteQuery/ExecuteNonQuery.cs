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
    public partial class ExecuteNonQuery : Form
    {
        public ExecuteNonQuery()
        {
            InitializeComponent();
        }

        String StrConn = @"Server=localhost;database=kh;uid=sa;pwd=std001;";

        public void NonQuery_CreateTable()
        {
            SqlConnection conn = new SqlConnection(StrConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_Create_Table", conn);
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@result", SqlDbType.Int);
                p1.Direction = ParameterDirection.Output;
                com.Parameters.Add(p1);
                com.ExecuteNonQuery();

                int result = Convert.ToInt32(com.Parameters["@result"].Value);

                if (result == 1)
                {
                    MessageBox.Show(
                        "테이블 생성 완료");
                }
                else
                {
                    MessageBox.Show(
                        "이미 존재하는 테이블입니다.");
                }
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

        private void Create_Table_Click(object sender, EventArgs e)
        {
            NonQuery_CreateTable();
        }
        
        public void NonQuery_DropTable()
        {
            SqlConnection conn = new SqlConnection(StrConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_Drop_Table", conn);
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@result", SqlDbType.Int);
                p1.Direction = ParameterDirection.Output;
                com.Parameters.Add(p1);
                com.ExecuteNonQuery();

                int result = Convert.ToInt32(com.Parameters["@result"].Value);

                if (result == 1)
                {
                    MessageBox.Show(
                        "테이블 삭제 완료");
                }
                else
                {
                    MessageBox.Show(
                        "이미 삭제한 테이블입니다.");
                }
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

        private void Drop_Table_Click(object sender, EventArgs e)
        {
            NonQuery_DropTable();
        }

        public void Insert_Query()
        {
            SqlConnection conn = new SqlConnection(StrConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_Insert_Row", conn);

                com.CommandType = CommandType.StoredProcedure;

                // 입력 파라미터
                com.Parameters.AddWithValue("@id",Int32.Parse(textBox1.Text));

                com.Parameters.AddWithValue("@name",textBox2.Text);

                // 출력 파라미터
                SqlParameter p1 = new SqlParameter("@result",SqlDbType.Int);
                p1.Direction = ParameterDirection.Output;
                com.Parameters.Add(p1);
                // 실행
                com.ExecuteNonQuery();
                int result = Convert.ToInt32(com.Parameters["@result"].Value);

                if (result == 1)
                {
                    MessageBox.Show(
                        "행 추가 완료");
                }
                else
                {
                    MessageBox.Show(
                        "행 추가 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            Insert_Query();
        }
    }
}
