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
            video_search();
        }
        // 비디오 조회
        public void video_search()
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_video_read", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();

                DGV_All_Video.Rows.Clear();

                DGV_All_Video.Columns.Add("col1", "코드");
                DGV_All_Video.Columns.Add("col2", "장르");
                DGV_All_Video.Columns.Add("col3", "제목");
                DGV_All_Video.Columns.Add("col4", "주연 배우");
                DGV_All_Video.Columns.Add("col5", "감독");
                DGV_All_Video.Columns.Add("col6", "제작 및 배급");
                DGV_All_Video.Columns.Add("col7", "출시일");

                while (rd.Read())
                {
                    DGV_All_Video.Rows.Add(
                        rd["video_code"].ToString(),
                        rd["genre_name"].ToString(),
                        rd["title"].ToString(),
                        rd["actor_name"].ToString(),
                        rd["director_name"].ToString(),
                        rd["company_name"].ToString(),
                        rd["release_date"].ToString()
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
