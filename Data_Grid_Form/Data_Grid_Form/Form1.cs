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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strconn = @"server=localhost;database=kh;uid=sa;pwd=std001;";

        public void exam_emp_select()
        {
            SqlConnection conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_emp_read", conn);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();

                listView1.Items.Clear();

                while(reader.Read()){
                    ListViewItem item = new ListViewItem(reader["수험번호"].ToString());
                    item.SubItems.Add(reader["부서"].ToString());
                    item.SubItems.Add(reader["성명"].ToString());
                    item.SubItems.Add(reader["주민등록번호"].ToString());
                    item.SubItems.Add(reader["우편번호"].ToString());
                    item.SubItems.Add(reader["주소"].ToString());

                    listView1.Items.Add(item);
                }
                reader.Close();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                Combo_Box_Department.Text = item.SubItems[1].Text;
                Txt_Box_Name.Text = item.SubItems[2].Text;
            }
        }
        private void Btn_DataLoad_Click(object sender, EventArgs e)
        {
            exam_emp_select();
        }

        public void exam_select()
        {
            SqlConnection conn = new SqlConnection(strconn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_exam_name", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@department", Combo_Box_Department.Text);
                com.Parameters.AddWithValue("@name", Txt_Box_Name.Text);
                SqlDataReader reader = com.ExecuteReader();

                dataGridView1.Rows.Clear();
                
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["성명"].ToString(),
                        reader["학력"].ToString(),
                        reader["영어"].ToString(),
                        reader["수학"].ToString(),
                        reader["전형구분"].ToString(),
                        reader["부서"].ToString(),
                        reader["수험번호"].ToString()
                        );
                }
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

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            exam_select();
            dataGridView1.Visible = true;
        }
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        public void delete()
        {
            SqlConnection conn = new SqlConnection(strconn);

            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("proc_exam_delete", conn);
                com.CommandType = CommandType.StoredProcedure;

                int id = Int32.Parse((string)dataGridView1.CurrentRow.Cells[6].Value);

                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();

                MessageBox.Show("삭제완료");
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
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.Txt_Name.Text = (string)dataGridView1.CurrentRow.Cells[0].Value;
            form3.Txt_Edu.Text = (string)dataGridView1.CurrentRow.Cells[1].Value;
            form3.Txt_Eng.Text = (string)dataGridView1.CurrentRow.Cells[2].Value;
            form3.Txt_Math.Text = (string)dataGridView1.CurrentRow.Cells[3].Value;
            form3.Cbb_Sc.Text = (string)dataGridView1.CurrentRow.Cells[4].Value;
            form3.Cbb_Department.Text = (string)dataGridView1.CurrentRow.Cells[5].Value;
            form3.Txt_Id.Text = (string)dataGridView1.CurrentRow.Cells[6].Value;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            delete();
            exam_select();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
