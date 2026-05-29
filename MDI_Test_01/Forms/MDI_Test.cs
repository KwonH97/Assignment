using MDI_Test_01.Services;
using System;
using System.IO;
using System.Runtime.Remoting.Contexts;
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

            this.FormClosing += MDI_Test_FormClosing;
        }

        private void MDI_Test_Load(object sender, EventArgs e)
        {
            w_service.StartTimeThread(this, TSSL_1, TSSL_2);
        }
        
        private void MDI_Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            w_service.StopTimeThread();
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
            w_service.AllClose(this, TSSL_3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            w_service.StartTimeThread(this, TSSL_1, TSSL_2);
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
            TSSL_3.Text = "계단식정렬";
        }

        private void 바둑판식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            TSSL_3.Text = "바둑판식정렬";
        }

        private void 아이콘식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
            TSSL_3.Text = "아이콘식정렬";
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.Save(this, TSSL_3);
        }

        private void TB_Save_Click(object sender, EventArgs e)
        {
            w_service.Save(this, TSSL_3);
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.SaveAs(this, TSSL_3);
        }

        private void TB_SaveAs_Click(object sender, EventArgs e)
        {
            w_service.SaveAs(this, TSSL_3);
        }

        private void 페이지설정UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.PageSetup(this, TSSL_3);
        }

        private void 출력PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.Print(this, TSSL_3);
        }

        private void TB_Print_Click(object sender, EventArgs e)
        {
            w_service.Print(this, TSSL_3);
        }

        private void 미리보기RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.PrintPreview(this, TSSL_3);
        }

        private void TB_Printpreview_Click(object sender, EventArgs e)
        {
            w_service.PrintPreview(this, TSSL_3);
        }

        private void 지우기취소ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.UndoText(this);
        }

        private void TB_Undo_Click(object sender, EventArgs e)
        {
            w_service.UndoText(this);
        }

        private void 잘라내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.CutText(this);
        }

        private void TB_Cut_Click(object sender, EventArgs e)
        {
            w_service.CutText(this);
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.CopyText(this);
        }

        private void TB_Copy_Click(object sender, EventArgs e)
        {
            w_service.CopyText(this);
        }

        private void 붙여넣기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.PasteText(this);
        }

        private void TB_Paste_Click(object sender, EventArgs e)
        {
            w_service.PasteText(this);
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.ChangeFont(this, TSSL_3);
        }

        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_service.ChangeBackColor(this, TSSL_3);
        }
    }
}
