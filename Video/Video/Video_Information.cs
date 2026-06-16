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
    public partial class Video_Information : Form
    {
        string str = @"server=localhost;database=kh;uid=sa;pwd=std001;";

        public Video_Information()
        {
            InitializeComponent();
        }

        public void video_search_()
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_video_read", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();

                DGV_All_Video.Rows.Clear();

                while (rd.Read())
                {
                    DGV_All_Video.Rows.Add(
                        rd["코드"].ToString(),
                        rd["장르"].ToString(),
                        rd["제목"].ToString(),
                        rd["주연 배우"].ToString(),
                        rd["감독"].ToString(),
                        rd["제작 및 배급"].ToString(),
                        rd["출시일"].ToString()
                    );
                }
            }
            catch (Exception ex) 
            {

            }
            finally { con.Close(); }
        }
    }
}
