namespace Data_Grid_Form
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_SC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_DepartMent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_Department = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Txt_Box_Department = new System.Windows.Forms.TextBox();
            this.Txt_Box_Name = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.List_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Name,
            this.C_Education,
            this.C_English,
            this.C_Math,
            this.C_SC,
            this.C_DepartMent,
            this.C_ID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(25, 321);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(705, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // C_Name
            // 
            this.C_Name.HeaderText = "성명";
            this.C_Name.Name = "C_Name";
            this.C_Name.Width = 120;
            // 
            // C_Education
            // 
            this.C_Education.HeaderText = "학력";
            this.C_Education.Name = "C_Education";
            this.C_Education.Width = 120;
            // 
            // C_English
            // 
            this.C_English.HeaderText = "영어";
            this.C_English.Name = "C_English";
            this.C_English.Width = 120;
            // 
            // C_Math
            // 
            this.C_Math.HeaderText = "수학";
            this.C_Math.Name = "C_Math";
            this.C_Math.Width = 120;
            // 
            // C_SC
            // 
            this.C_SC.HeaderText = "전형구분";
            this.C_SC.Name = "C_SC";
            this.C_SC.Width = 120;
            // 
            // C_DepartMent
            // 
            this.C_DepartMent.HeaderText = "부서";
            this.C_DepartMent.Name = "C_DepartMent";
            this.C_DepartMent.Width = 120;
            // 
            // C_ID
            // 
            this.C_ID.HeaderText = "수험번호";
            this.C_ID.Name = "C_ID";
            this.C_ID.Width = 120;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.List_Name});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1188, 259);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btn_Search);
            this.panel1.Controls.Add(this.Txt_Box_Name);
            this.panel1.Controls.Add(this.Txt_Box_Department);
            this.panel1.Controls.Add(this.Lbl_Name);
            this.panel1.Controls.Add(this.Lbl_Department);
            this.panel1.Location = new System.Drawing.Point(746, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 204);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("굴림", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 260);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조회";
            // 
            // Lbl_Department
            // 
            this.Lbl_Department.AutoSize = true;
            this.Lbl_Department.Font = new System.Drawing.Font("굴림", 20F);
            this.Lbl_Department.Location = new System.Drawing.Point(1, 24);
            this.Lbl_Department.Name = "Lbl_Department";
            this.Lbl_Department.Size = new System.Drawing.Size(93, 27);
            this.Lbl_Department.TabIndex = 0;
            this.Lbl_Department.Text = "부서 : ";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("굴림", 20F);
            this.Lbl_Name.Location = new System.Drawing.Point(1, 75);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(84, 27);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "성명 :";
            // 
            // Txt_Box_Department
            // 
            this.Txt_Box_Department.Font = new System.Drawing.Font("굴림", 20F);
            this.Txt_Box_Department.Location = new System.Drawing.Point(100, 21);
            this.Txt_Box_Department.Name = "Txt_Box_Department";
            this.Txt_Box_Department.Size = new System.Drawing.Size(316, 38);
            this.Txt_Box_Department.TabIndex = 2;
            // 
            // Txt_Box_Name
            // 
            this.Txt_Box_Name.Font = new System.Drawing.Font("굴림", 20F);
            this.Txt_Box_Name.Location = new System.Drawing.Point(100, 72);
            this.Txt_Box_Name.Name = "Txt_Box_Name";
            this.Txt_Box_Name.Size = new System.Drawing.Size(316, 38);
            this.Txt_Box_Name.TabIndex = 3;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Search.Location = new System.Drawing.Point(23, 133);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(393, 64);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "검색";
            this.Btn_Search.UseVisualStyleBackColor = true;
            // 
            // List_Name
            // 
            this.List_Name.Text = "수험번호";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Education;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_English;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Math;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_SC;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DepartMent;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Department;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Txt_Box_Name;
        private System.Windows.Forms.TextBox Txt_Box_Department;
        private System.Windows.Forms.ColumnHeader List_Name;
    }
}

