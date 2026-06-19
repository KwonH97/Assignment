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

namespace Video
{
    public partial class Custom_Information : Form
    {
        string str = @"server=localhost;database=kh;uid=sa;pwd=std001;";
        public Custom_Information()
        {
            InitializeComponent();
            custom_search();
        }
        
        public void custom_search()
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("proc_customer_read", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = com.ExecuteReader();

                DGV_All_Customer.Rows.Clear();

                DGV_All_Customer.Columns.Add("col1", "코드");
                DGV_All_Customer.Columns.Add("col2", "성명");
                DGV_All_Customer.Columns.Add("col3", "주민등록번호");
                DGV_All_Customer.Columns.Add("col4", "신분");
                DGV_All_Customer.Columns.Add("col5", "성별");
                DGV_All_Customer.Columns.Add("col6", "연락처");
                DGV_All_Customer.Columns.Add("col7", "휴대폰");
                DGV_All_Customer.Columns.Add("col8", "우편번호");
                DGV_All_Customer.Columns.Add("col9", "주소");

                while (reader.Read())
                {
                    DGV_All_Customer.Rows.Add(
                        reader["customer_code"].ToString(),
                        reader["customer_name"].ToString(),
                        reader["resident_number"].ToString(),
                        reader["customer_type_name"].ToString(),
                        reader["gender"].ToString(),
                        reader["phone_number"].ToString(),
                        reader["mobile_number"].ToString(),
                        reader["postal_code"].ToString(),
                        reader["address"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { con.Close(); }
        }
    }
}
