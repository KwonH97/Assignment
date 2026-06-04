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

namespace List_View_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showData();
        }

        String StrConn = @"Server=localhost;database=kh;uid=sa;pwd=std001;";

        public void showData()
        {

            SqlConnection conn = new SqlConnection(StrConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_emp_read", conn);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["수험번호"].ToString());
                    item.SubItems.Add(reader["성명"].ToString());
                    item.SubItems.Add(reader["주소"].ToString());

                    listView1.Items.Add(item);
                }
                reader.Close();
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
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                
                Txt_ID.Text = item.SubItems[0].Text;
                Txt_Name.Text = item.SubItems[1].Text;
                Txt_Addr.Text = item.SubItems[2].Text;
            }
        }
        
        public void insertQuery()
        {
            SqlConnection conn = new SqlConnection(StrConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_emp_insert", conn);
                com.CommandType = CommandType.StoredProcedure;
                //입력파라미터
                com.Parameters.AddWithValue("@id",Int32.Parse(Txt_ID.Text));
                com.Parameters.AddWithValue("@name", Txt_ID.Text);
                com.Parameters.AddWithValue("@addr", Txt_ID.Text);

                //출력파라미터
                SqlParameter p1 = new SqlParameter("@result", SqlDbType.Int);
                p1.Direction = ParameterDirection.Output;
                com.Parameters.Add(p1);
                //실행
                com.ExecuteNonQuery();

                int result = Convert.ToInt32(com.Parameters["@result"].Value);

                if (result == 1)
                {
                    MessageBox.Show("행 추가 완료");
                    Txt_ID.Clear();
                    Txt_Name.Clear();
                    Txt_Addr.Clear();
                }
                else
                {
                    MessageBox.Show("행 추가 실패");
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
        public void update_Query()
        {
            SqlConnection conn = new SqlConnection(StrConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_emp_update", conn);
                com.CommandType = CommandType.StoredProcedure;
                //입력
                com.Parameters.AddWithValue("@id", Int32.Parse(Txt_ID.Text));
                com.Parameters.AddWithValue("@name", Txt_Name.Text);
                com.Parameters.AddWithValue("@addr", Txt_Addr.Text);
                //출력
                SqlParameter p1 = new SqlParameter("@result", SqlDbType.Int);
                p1.Direction = ParameterDirection.Output;
                com.Parameters.Add(p1);
                //실행
                com.ExecuteNonQuery();

                int result = Convert.ToInt32(com.Parameters["@result"].Value);

                if (result == 1)
                {
                    MessageBox.Show("행 업데이트 완료");
                    Txt_ID.Clear();
                    Txt_Name.Clear();
                    Txt_Addr.Clear();
                }
                else
                {
                    MessageBox.Show("행 업데이트 실패");
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
        public void delete_Query()
        {
            SqlConnection conn = new SqlConnection(StrConn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_emp_delete", conn);
                com.CommandType = CommandType.StoredProcedure;
                //입력
                com.Parameters.AddWithValue("@id", Int32.Parse(Txt_ID.Text));
                //출력파라미터
                SqlParameter p1 = new SqlParameter("@result", SqlDbType.Int);
                p1.Direction = ParameterDirection.Output;
                com.Parameters.Add(p1);
                //실행
                com.ExecuteNonQuery();

                int result = Convert.ToInt32(com.Parameters["@result"].Value);

                if (result == 1)
                {
                    MessageBox.Show("행 삭제 완료");
                    Txt_ID.Clear();
                    Txt_Name.Clear();
                    Txt_Addr.Clear();
                }
                else
                {
                    MessageBox.Show("행 삭제 실패");
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

        private void button1_Click(object sender, EventArgs e)
        {
            insertQuery();
            showData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            update_Query();
            showData();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            delete_Query();
            showData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
