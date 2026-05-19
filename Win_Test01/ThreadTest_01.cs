using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Test01
{
    public partial class ThreadTest_01 : Form
    {
        public ThreadTest_01()
        {
            InitializeComponent();
        }
        
        Thread th = null;
        bool th_go = false;

        private void ThreadTest_01_Load(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(Th_Work));
            th.IsBackground = true;
            th.Start();
        }
        private void Th_Work()
        {
            while (!th_go)
            {
                
                //label112.Text = DateTime.Now.ToLongTimeString();
                
                this.BeginInvoke(new Action(() =>
                {
                    label112.Text = DateTime.Now.ToLongTimeString();
                }));

                Thread.Sleep(1000);
            }
        }

        private void ThreadTest_01_FormClosed(object sender, FormClosedEventArgs e)
        {
            th_go = true;
            if (th != null)
            {
                th.Interrupt();
                // interrupt를 쓰면 try catch문쓰기
            }            
        }
    }
}
