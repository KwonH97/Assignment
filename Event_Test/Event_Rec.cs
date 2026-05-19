using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Test
{
    public partial class Event_Rec : Form
    {
        public Event_Rec()
        {
            InitializeComponent();
        }

        private void Event_Rec_Load(object sender, EventArgs e)
        {
            Event_Pub event_Pub = new Event_Pub();
            event_Pub.InputString += Event_Pub_InputString;

            event_Pub.Show();
        }

        private void Event_Pub_InputString(string msg)
        {
            Txt_Rec.Text = msg;
        }
    }
}
