using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSB_Video_Rental_Click(object sender, EventArgs e)
        {
            Video_Rental vr = new Video_Rental();
            vr.Show();
        }

        private void TSM_Video_Rental_Click(object sender, EventArgs e)
        {
            Video_Rental vr = new Video_Rental();
            vr.Show();
        }

        private void TSB_Video_Information_Click(object sender, EventArgs e)
        {
            Video_Information vr = new Video_Information();
            vr.Show();
        }

        private void TSM_Video_Information_Click(object sender, EventArgs e)
        {
            Video_Information vr = new Video_Information();
            vr.Show();
        }

        private void TSM_Custom_Information_Click(object sender, EventArgs e)
        {
            Custom_Information ci = new Custom_Information();
            ci.Show();
        }

        private void TSB_Custom_Information_Click(object sender, EventArgs e)
        {
            Custom_Information ci = new Custom_Information();
            ci.Show();
        }

        private void TSM_Video_View_Management_Click(object sender, EventArgs e)
        {
            Video_View_Management vv = new Video_View_Management();
            vv.Show();
        }

        private void TSB_Video_View_Management_Click(object sender, EventArgs e)
        {
            Video_View_Management vv = new Video_View_Management();
            vv.Show();
        }

        private void 비디오정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Video_Output vo = new Video_Output();
            vo.Show();
        }

        private void 비디오대여설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rental_Policy rp = new Rental_Policy();
            rp.Show();
        }

        private void TSB_Option_Click(object sender, EventArgs e)
        {
            Video_Output vo = new Video_Output();
            Rental_Policy rp = new Rental_Policy();
            vo.Show();
            rp.Show();
        }
    }
}
