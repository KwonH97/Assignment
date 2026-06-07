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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.G_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_SC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_DepartMent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.List_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_ZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_Addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Combo_Box_Department = new System.Windows.Forms.ComboBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Txt_Box_Name = new System.Windows.Forms.TextBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Department = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_DataLoad = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.G_Name,
            this.G_Education,
            this.G_English,
            this.G_Math,
            this.G_SC,
            this.G_DepartMent,
            this.G_ID});
            this.dataGridView1.Location = new System.Drawing.Point(23, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // G_Name
            // 
            this.G_Name.HeaderText = "성명";
            this.G_Name.Name = "G_Name";
            this.G_Name.Width = 120;
            // 
            // G_Education
            // 
            this.G_Education.HeaderText = "학력";
            this.G_Education.Name = "G_Education";
            this.G_Education.Width = 120;
            // 
            // G_English
            // 
            this.G_English.HeaderText = "영어";
            this.G_English.Name = "G_English";
            this.G_English.Width = 120;
            // 
            // G_Math
            // 
            this.G_Math.HeaderText = "수학";
            this.G_Math.Name = "G_Math";
            this.G_Math.Width = 120;
            // 
            // G_SC
            // 
            this.G_SC.HeaderText = "전형구분";
            this.G_SC.Name = "G_SC";
            this.G_SC.Width = 120;
            // 
            // G_DepartMent
            // 
            this.G_DepartMent.HeaderText = "부서";
            this.G_DepartMent.Name = "G_DepartMent";
            this.G_DepartMent.Width = 120;
            // 
            // G_ID
            // 
            this.G_ID.HeaderText = "수험번호";
            this.G_ID.Name = "G_ID";
            this.G_ID.Width = 120;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.List_ID,
            this.List_Department,
            this.List_Name,
            this.List_Number,
            this.List_ZipCode,
            this.List_Addr});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1188, 259);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // List_ID
            // 
            this.List_ID.Text = "수험번호";
            this.List_ID.Width = 150;
            // 
            // List_Department
            // 
            this.List_Department.Text = "부서";
            this.List_Department.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.List_Department.Width = 120;
            // 
            // List_Name
            // 
            this.List_Name.Text = "성명";
            this.List_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.List_Name.Width = 120;
            // 
            // List_Number
            // 
            this.List_Number.Text = "주민등록번호";
            this.List_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.List_Number.Width = 180;
            // 
            // List_ZipCode
            // 
            this.List_ZipCode.Text = "우편번호";
            this.List_ZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.List_ZipCode.Width = 180;
            // 
            // List_Addr
            // 
            this.List_Addr.Text = "주소";
            this.List_Addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.List_Addr.Width = 400;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Combo_Box_Department);
            this.panel1.Controls.Add(this.Btn_Search);
            this.panel1.Controls.Add(this.Txt_Box_Name);
            this.panel1.Controls.Add(this.Lbl_Name);
            this.panel1.Controls.Add(this.Lbl_Department);
            this.panel1.Location = new System.Drawing.Point(746, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 204);
            this.panel1.TabIndex = 3;
            // 
            // Combo_Box_Department
            // 
            this.Combo_Box_Department.Font = new System.Drawing.Font("굴림", 20F);
            this.Combo_Box_Department.FormattingEnabled = true;
            this.Combo_Box_Department.Items.AddRange(new object[] {
            "부산지점",
            "창원지점",
            "진주지점"});
            this.Combo_Box_Department.Location = new System.Drawing.Point(100, 24);
            this.Combo_Box_Department.Name = "Combo_Box_Department";
            this.Combo_Box_Department.Size = new System.Drawing.Size(316, 35);
            this.Combo_Box_Department.TabIndex = 5;
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
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txt_Box_Name
            // 
            this.Txt_Box_Name.Font = new System.Drawing.Font("굴림", 20F);
            this.Txt_Box_Name.Location = new System.Drawing.Point(100, 72);
            this.Txt_Box_Name.Name = "Txt_Box_Name";
            this.Txt_Box_Name.Size = new System.Drawing.Size(316, 38);
            this.Txt_Box_Name.TabIndex = 3;
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
            // Btn_DataLoad
            // 
            this.Btn_DataLoad.Font = new System.Drawing.Font("굴림", 13F);
            this.Btn_DataLoad.Location = new System.Drawing.Point(12, 564);
            this.Btn_DataLoad.Name = "Btn_DataLoad";
            this.Btn_DataLoad.Size = new System.Drawing.Size(199, 65);
            this.Btn_DataLoad.TabIndex = 5;
            this.Btn_DataLoad.Text = "데이터 로드";
            this.Btn_DataLoad.UseVisualStyleBackColor = true;
            this.Btn_DataLoad.Click += new System.EventHandler(this.Btn_DataLoad_Click);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Font = new System.Drawing.Font("굴림", 13F);
            this.Btn_Insert.Location = new System.Drawing.Point(258, 564);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(199, 65);
            this.Btn_Insert.TabIndex = 6;
            this.Btn_Insert.Text = "추가";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("굴림", 13F);
            this.Btn_Update.Location = new System.Drawing.Point(501, 564);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(199, 65);
            this.Btn_Update.TabIndex = 7;
            this.Btn_Update.Text = "수정";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("굴림", 13F);
            this.Btn_Delete.Location = new System.Drawing.Point(746, 564);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(199, 65);
            this.Btn_Delete.TabIndex = 8;
            this.Btn_Delete.Text = "삭제";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("굴림", 13F);
            this.Btn_Close.Location = new System.Drawing.Point(990, 564);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(199, 65);
            this.Btn_Close.TabIndex = 9;
            this.Btn_Close.Text = "종료";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 641);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.Btn_DataLoad);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Department;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Txt_Box_Name;
        private System.Windows.Forms.ColumnHeader List_ID;
        private System.Windows.Forms.ColumnHeader List_Department;
        private System.Windows.Forms.ColumnHeader List_Name;
        private System.Windows.Forms.ColumnHeader List_Number;
        private System.Windows.Forms.ColumnHeader List_ZipCode;
        private System.Windows.Forms.ColumnHeader List_Addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Education;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_English;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Math;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_SC;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_DepartMent;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_ID;
        private System.Windows.Forms.Button Btn_DataLoad;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.ComboBox Combo_Box_Department;
    }
}

