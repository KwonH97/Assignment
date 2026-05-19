using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Test01
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Btn_Child_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4();
            //자식폼의 디폴트 설정
            child.TopLevel = false;
            child.Parent = this;
            child.BringToFront();
            child.Show();
        }

        private void Btn_Own_Click(object sender, EventArgs e)
        {
            Form4 own = new Form4();
            this.AddOwnedForm(own);
            own.Show();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
