using System;
using System.Windows.Forms;

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
    }
}
