using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MID_Test_01
{
    public partial class NewForm_Test : Form
    {
        public NewForm_Test()
        {
            InitializeComponent();
        }
        public NewForm_Test(string text)
        {
            InitializeComponent();

            Txt_Memo.Text = text;
        }
    }
}
