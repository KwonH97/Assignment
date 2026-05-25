using MID_Test_01.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_Test_01
{
    public partial class MID_Test : Form
    {
        WindowService w_service = new WindowService();

        public MID_Test()
        {
            InitializeComponent();
            TSSL_3.Text = "준비 완료";
        }

        private void MID_Test_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            w_service.UpdateTime(TSSL_1, TSSL_2);
            timer1.Start();
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.Newform(this, TSSL_3);
        }

        private void TB_New_Click(object sender, EventArgs e)
        {
            w_service.Newform(this, TSSL_3);
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.Open(this, TSSL_3);
        }

        private void 닫기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 모두닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.AllClose(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            w_service.UpdateTime(TSSL_1, TSSL_2);
        }

        private void TB_Open_Click(object sender, EventArgs e)
        {
            w_service.Open(this, TSSL_3);
        }
    }
}
