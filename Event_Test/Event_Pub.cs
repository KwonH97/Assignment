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

namespace Event_Test
{
    public partial class Event_Pub : Form
    {
        public delegate void OnTextBoxEvent(string msg);
        public event OnTextBoxEvent InputString;

        public Event_Pub()
        {
            InitializeComponent();
        }

        /*
        private void Txt_Res_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InputString(Txt_Res.Text.Trim());
            }
        }
        */

        private void Txt_Res_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputString(Txt_Res.Text.Trim());
        }
    }
}
