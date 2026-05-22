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
        }

        private void MID_Test_Load(object sender, EventArgs e)
        {

        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.Newform(this);
        }

        private void TB_New_Click(object sender, EventArgs e)
        {
            w_service.Newform(this);
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.Open(this);
        }
    }
}
