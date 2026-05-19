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
    public partial class ListForm5 : Form
    {
        public ListForm5()
        {
            InitializeComponent();
        }

        private void ListForm5_Load(object sender, EventArgs e)
        {
            List_Source.Items.AddRange(new string[]{
                "키보드", "마우스","메인보드","모니터","스피커","하드디스크","메인메모리","USB메모리","프린터"
            });
        }

        private void Move_Click(object sender, EventArgs e)
        {
            if (List_Source.SelectedItems.Count > 0)
            {
                foreach (string MyItem in List_Source.SelectedItems) {
                
                    List_Dest.Items.Add(MyItem);
                }
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }

            for (int MyitemIndex = List_Source.SelectedItems.Count - 1; MyitemIndex >= 0; MyitemIndex--)
            {
                List_Source.Items.RemoveAt(List_Source.SelectedIndices[MyitemIndex]);
            }
        }

        private void Move2_Click(object sender, EventArgs e)
        {
            if (List_Dest.SelectedItems.Count > 0)
            {
                foreach (string MyItem in List_Dest.SelectedItems)
                {

                    List_Source.Items.Add(MyItem);
                }
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }

            for (int MyitemIndex = List_Dest.SelectedItems.Count - 1; MyitemIndex >= 0; MyitemIndex--)
            {
                List_Dest.Items.RemoveAt(List_Dest.SelectedIndices[MyitemIndex]);
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string SearchItem;
            int index;

            SearchForm SDForm = new SearchForm();

            SDForm.Text = "상품검색";

            if (SDForm.ShowDialog() == DialogResult.OK)
            {
                SearchItem = SDForm.SearchText;
                index = List_Source.Items.IndexOf(SearchItem);

                List_Source.ClearSelected();

                if(index > -1)
                {
                    List_Source.SetSelected(index, true);
                }
                else
                {
                    MessageBox.Show("찾을 수 없습니다", "찾기실패");
                }
            }

        }
    }
}
