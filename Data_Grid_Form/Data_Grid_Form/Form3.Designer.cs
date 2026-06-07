namespace Data_Grid_Form
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Cbb_Sc = new System.Windows.Forms.ComboBox();
            this.Cbb_Department = new System.Windows.Forms.ComboBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Txt_Math = new System.Windows.Forms.TextBox();
            this.Txt_Eng = new System.Windows.Forms.TextBox();
            this.Txt_Edu = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Close.Location = new System.Drawing.Point(325, 437);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(114, 51);
            this.Btn_Close.TabIndex = 38;
            this.Btn_Close.Text = "종료";
            this.Btn_Close.UseVisualStyleBackColor = true;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Clear.Location = new System.Drawing.Point(173, 437);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(114, 51);
            this.Btn_Clear.TabIndex = 37;
            this.Btn_Clear.Text = "초기화";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("굴림", 20F);
            this.Btn_Save.Location = new System.Drawing.Point(21, 437);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(114, 51);
            this.Btn_Save.TabIndex = 36;
            this.Btn_Save.Text = "저장";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Cbb_Sc
            // 
            this.Cbb_Sc.Font = new System.Drawing.Font("굴림", 20F);
            this.Cbb_Sc.FormattingEnabled = true;
            this.Cbb_Sc.Items.AddRange(new object[] {
            "공채",
            "수시",
            "특채"});
            this.Cbb_Sc.Location = new System.Drawing.Point(179, 302);
            this.Cbb_Sc.Name = "Cbb_Sc";
            this.Cbb_Sc.Size = new System.Drawing.Size(248, 35);
            this.Cbb_Sc.TabIndex = 34;
            // 
            // Cbb_Department
            // 
            this.Cbb_Department.Font = new System.Drawing.Font("굴림", 20F);
            this.Cbb_Department.FormattingEnabled = true;
            this.Cbb_Department.Items.AddRange(new object[] {
            "부산지점",
            "창원지점",
            "진주지점"});
            this.Cbb_Department.Location = new System.Drawing.Point(179, 62);
            this.Cbb_Department.Name = "Cbb_Department";
            this.Cbb_Department.Size = new System.Drawing.Size(248, 35);
            this.Cbb_Department.TabIndex = 33;
            // 
            // Txt_Id
            // 
            this.Txt_Id.Font = new System.Drawing.Font("굴림", 20F);
            this.Txt_Id.Location = new System.Drawing.Point(179, 350);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(248, 38);
            this.Txt_Id.TabIndex = 32;
            // 
            // Txt_Math
            // 
            this.Txt_Math.Font = new System.Drawing.Font("굴림", 20F);
            this.Txt_Math.Location = new System.Drawing.Point(179, 254);
            this.Txt_Math.Name = "Txt_Math";
            this.Txt_Math.Size = new System.Drawing.Size(248, 38);
            this.Txt_Math.TabIndex = 31;
            // 
            // Txt_Eng
            // 
            this.Txt_Eng.Font = new System.Drawing.Font("굴림", 20F);
            this.Txt_Eng.Location = new System.Drawing.Point(179, 206);
            this.Txt_Eng.Name = "Txt_Eng";
            this.Txt_Eng.Size = new System.Drawing.Size(248, 38);
            this.Txt_Eng.TabIndex = 30;
            // 
            // Txt_Edu
            // 
            this.Txt_Edu.Font = new System.Drawing.Font("굴림", 20F);
            this.Txt_Edu.Location = new System.Drawing.Point(179, 158);
            this.Txt_Edu.Name = "Txt_Edu";
            this.Txt_Edu.Size = new System.Drawing.Size(248, 38);
            this.Txt_Edu.TabIndex = 29;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Font = new System.Drawing.Font("굴림", 20F);
            this.Txt_Name.Location = new System.Drawing.Point(179, 110);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(248, 38);
            this.Txt_Name.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 20F);
            this.label7.Location = new System.Drawing.Point(24, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 27);
            this.label7.TabIndex = 27;
            this.label7.Text = "학번 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 20F);
            this.label6.Location = new System.Drawing.Point(24, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 27);
            this.label6.TabIndex = 26;
            this.label6.Text = "전형구분 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 20F);
            this.label5.Location = new System.Drawing.Point(24, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "수학 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20F);
            this.label4.Location = new System.Drawing.Point(24, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "영어 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20F);
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "학력 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "성명 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "부서 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("굴림", 20F);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 402);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "데이터 수정";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 497);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Cbb_Sc);
            this.Controls.Add(this.Cbb_Department);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Txt_Math);
            this.Controls.Add(this.Txt_Eng);
            this.Controls.Add(this.Txt_Edu);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox Cbb_Department;
        public System.Windows.Forms.TextBox Txt_Name;
        public System.Windows.Forms.TextBox Txt_Edu;
        public System.Windows.Forms.ComboBox Cbb_Sc;
        public System.Windows.Forms.TextBox Txt_Id;
        public System.Windows.Forms.TextBox Txt_Math;
        public System.Windows.Forms.TextBox Txt_Eng;
    }
}