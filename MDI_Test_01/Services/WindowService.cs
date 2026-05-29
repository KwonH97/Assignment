using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MDI_Test_01.Services
{
    internal class WindowService
    {
        public void Newform(Form parent, ToolStripStatusLabel txtLabel, string title)
        {
            NewForm_Test nf = new NewForm_Test(txtLabel);
            nf.MdiParent = parent;
            nf.BringToFront();
            nf.Text = title;
            nf.Show();
            txtLabel.Text = "새 문서 생성";
            
        }
        public void Open(Form parent, ToolStripStatusLabel txtLabel)
        {
            OpenFileDialog open = new OpenFileDialog();
            txtLabel.Text = "여는 중";
            open.Filter = "텍스트문서(*.txt)|*.txt|모든 파일(*.*)|*.*";
            open.FilterIndex = 1;
            open.InitialDirectory = @"C:\";

            if (open.ShowDialog() == DialogResult.OK) 
            {
                string fileName = open.FileName;
                string text = File.ReadAllText(fileName, Encoding.UTF8);
                NewForm_Test nf = new NewForm_Test(text, txtLabel);
                nf.FilePath = fileName;
                nf.MdiParent = parent;
                nf.BringToFront();
                nf.Show();
                txtLabel.Text = "불러오기 완료";
            }
            else
            {
                txtLabel.Text = "열기 취소";
            }
        }
        public void AllClose(Form parent, ToolStripStatusLabel txtLabel)
        {
            foreach (Form form in parent.MdiChildren.ToList())
            {
                form.Close();
            }
            txtLabel.Text = "모두 닫기";
        }
        public void Save(Form parent, ToolStripStatusLabel txtLabel)
        {
            NewForm_Test child = parent.ActiveMdiChild as NewForm_Test;
            txtLabel.Text = "저장 완료";

            if (child == null)
            {
                MessageBox.Show("저장할 문서가 없습니다.");
                return;
            }

            if (string.IsNullOrEmpty(child.FilePath))
            {
                SaveAs(parent, txtLabel);
                return;
            }

            File.WriteAllText(child.FilePath, child.MemoText, Encoding.UTF8);

        }
        public void SaveAs(Form parent, ToolStripStatusLabel txtLabel)
        {
            NewForm_Test child = parent.ActiveMdiChild as NewForm_Test;
            txtLabel.Text = "다른 이름으로 저장 중";
            if (child == null)
            {
                MessageBox.Show("저장할 문서가 없습니다.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "텍스트문서(*.txt)|*.txt|모든 파일(*.*)|*.*";
            save.OverwritePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                string File_Name = save.FileName;
                
                StreamWriter stw = new StreamWriter(File_Name, false, Encoding.UTF8);

                stw.Write(child.MemoText);
                stw.Flush();
                stw.Close();
                child.Text = Path.GetFileName(File_Name);
            }
            else
            {
                txtLabel.Text = "저장 취소";
            }
        }
        public WindowService()
        {
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private PrintDocument printDocument = new PrintDocument();
        private string printText = "";
        public void PageSetup(Form parent, ToolStripStatusLabel txtLabel)
        {
            PageSetupDialog psd = new PageSetupDialog();

            txtLabel.Text = "페이지 설정 중";

            psd.Document = printDocument;
            psd.ShowDialog();
            txtLabel.Text = "페이지 설정 닫음";
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("맑은 고딕", 10);

            e.Graphics.DrawString(
                printText,
                font,
                Brushes.Black,
                e.MarginBounds
            );

            e.HasMorePages = false;
        }

        public void Print(Form parent, ToolStripStatusLabel txtLabel)
        {
            NewForm_Test child = parent.ActiveMdiChild as NewForm_Test;

            if (child == null)
            {
                MessageBox.Show("출력할 문서가 없습니다.");
                return;
            }

            txtLabel.Text = "프린트 출력";

            printText = child.MemoText;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
                txtLabel.Text = "프린트 출력 완료";
            }
            else
            {
                txtLabel.Text = "프린트 출력 닫기";
            }
        }

        public void PrintPreview(Form parent, ToolStripStatusLabel txtLabel)
        {
            NewForm_Test child = parent.ActiveMdiChild as NewForm_Test;

            if (child == null)
            {
                MessageBox.Show("미리보기할 문서가 없습니다.");
                return;
            }

            txtLabel.Text = "프린트 미리보기";

            printText = child.MemoText;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;

            previewDialog.ShowDialog();

            txtLabel.Text = "프린트 미리보기 닫기";
        }

        private Thread timeThread;
        private bool isRunning;
        public void UpdateTime(ToolStripStatusLabel dateLabel, ToolStripStatusLabel timeLabel)
        {
            DateTime now = DateTime.Now;
            dateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void StartTimeThread(Form parent, ToolStripStatusLabel dateLabel, ToolStripStatusLabel timeLabel)
        {
            isRunning = true;

            timeThread = new Thread(() =>
            {
                while (isRunning)
                {
                    if (parent.IsDisposed)
                    {
                        break;
                    }

                    parent.Invoke(new MethodInvoker(delegate
                    {
                        UpdateTime(dateLabel, timeLabel);
                    }));

                    Thread.Sleep(1000);
                }
            });

            timeThread.IsBackground = true;
            timeThread.Start();
        }

        public void StopTimeThread()
        {
            isRunning = false;
        }

        public void UndoText(Form parent)
        {
            NewForm_Test nf = parent.ActiveMdiChild as NewForm_Test;

            if (nf == null)
            {
                MessageBox.Show("되돌릴 문서가 없습니다.");
                return;
            }

            nf.UndoMemo();
        }

        public void CutText(Form parent)
        {
            NewForm_Test nf = parent.ActiveMdiChild as NewForm_Test;

            if(nf == null)
            {
                MessageBox.Show("잘라낼 문서가 없습니다.");
                return;
            }
            nf.CutMemo();
        }
        public void CopyText(Form parent)
        {
            NewForm_Test nf = parent.ActiveMdiChild as NewForm_Test;

            if (nf == null)
            {
                MessageBox.Show("복사할 문서가 없습니다.");
                return;
            }

            nf.CopyMemo();
        }

        public void PasteText(Form parent)
        {
            NewForm_Test nf = parent.ActiveMdiChild as NewForm_Test;

            if (nf == null)
            {
                MessageBox.Show("붙여넣을 문서가 없습니다.");
                return;
            }

            nf.PasteMemo();
        }
        
        public void ChangeFont(Form parent, ToolStripStatusLabel txtLabel)
        {
            txtLabel.Text = "폰트 바꾸는 중";

            NewForm_Test nf = parent.ActiveMdiChild as NewForm_Test;

            if (nf == null)
            {
                MessageBox.Show("글꼴을 바꿀 문서가 없습니다.");
                return;
            }

            FontDialog fontDialog = new FontDialog();

            fontDialog.Font = nf.Font;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                nf.ChangeFont(fontDialog.Font);
            }
            else
            {
                txtLabel.Text = "폰트 바꾸기 취소";
            }
        }

        public void ChangeBackColor(Form parent, ToolStripStatusLabel txtLabel)
        {
            txtLabel.Text = "배경 바꾸는 중";

            NewForm_Test child = parent.ActiveMdiChild as NewForm_Test;

            if (child == null)
            {
                MessageBox.Show("배경색을 바꿀 문서가 없습니다.");
                return;
            }

            ColorDialog colorDialog = new ColorDialog();

            colorDialog.Color = child.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                child.ChangeBackColor(colorDialog.Color);
            }
            else
            {
                txtLabel.Text = "배경 바꾸기 취소";
            }
        }
    }
}
