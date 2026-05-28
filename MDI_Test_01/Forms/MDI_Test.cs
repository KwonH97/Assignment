using MDI_Test_01.Services;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MDI_Test_01
{
    public partial class MDI_Test : System.Windows.Forms.Form
    {
        WindowService w_service = new WindowService();

        private int chidform = 0;

        public MDI_Test()
        {
            InitializeComponent();
            TSSL_3.Text = "준비 완료";
        }

        private void MDI_Test_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            w_service.UpdateTime(TSSL_1, TSSL_2);
            timer1.Start();
        }
        private void CreateNewDocument()
        {
            chidform++;
            string title = "새문서" + chidform;
            w_service.Newform(this, TSSL_3, title);
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewDocument();
        }

        private void TB_New_Click(object sender, EventArgs e)
        {
            CreateNewDocument();
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

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 계단식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 바둑판식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 아이콘식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.Save(this);
        }
    }
}
