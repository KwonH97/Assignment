using System;
using System.Windows.Forms;
using System.Drawing;

namespace MDI_Test_01
{
    public partial class NewForm_Test : System.Windows.Forms.Form
    {
        private ToolStripStatusLabel _statusLabel;

        public NewForm_Test()
        {
            InitializeComponent();
            ConnectMemoStatus();
        }

        public NewForm_Test(string text) 
        {
            InitializeComponent();
            Txt_Memo.Text = text;
            ConnectMemoStatus();
        }

        // 새 문서용
        public NewForm_Test(ToolStripStatusLabel statusLabel)
        {
            InitializeComponent();
            _statusLabel = statusLabel;
            ConnectMemoStatus();
        }

        // 파일 열기용
        public NewForm_Test(string text, ToolStripStatusLabel statusLabel)
        {
            InitializeComponent();
            Txt_Memo.Text = text;
            _statusLabel = statusLabel;
            ConnectMemoStatus();
        }

        private void ConnectMemoStatus()
        {
            Txt_Memo.TextChanged += Txt_Memo_TextChanged;
        }

        private void Txt_Memo_TextChanged(object sender, EventArgs e)
        {
            if (_statusLabel != null)
            {
                _statusLabel.Text = "작성 중";
            }
        }

        public string MemoText
        {
            get { return Txt_Memo.Text; }
        }

        public string FilePath { get; set; }

        public void UndoMemo()
        {
            Txt_Memo.Undo();
            _statusLabel.Text = "되돌리기";
        }

        public void CutMemo()
        {
            Txt_Memo.Cut();
            _statusLabel.Text = "자르기 완료";
        }

        public void CopyMemo()
        {
            Txt_Memo.Copy();
            _statusLabel.Text = "복사 완료";
        }
        
        public void PasteMemo()
        {
            Txt_Memo.Paste();
            _statusLabel.Text = "붙여놓기 완료";
        }

        public void ChangeFont(Font font)
        {
            Txt_Memo.Font = font;
            _statusLabel.Text = "글꼴 바꾸기 완료";
        }
        
        public void ChangeBackColor(Color color)
        {
            Txt_Memo.BackColor = color;
            _statusLabel.Text = "배경 바꾸기 완료";
        }
    }
}
