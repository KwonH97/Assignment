namespace Video
{
    partial class Video_View_Management
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_Customer_Type_Name = new System.Windows.Forms.ComboBox();
            this.CB_Genre = new System.Windows.Forms.ComboBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RB_Rental_Video = new System.Windows.Forms.RadioButton();
            this.RB_Customer_Rank = new System.Windows.Forms.RadioButton();
            this.RB_Video_Rank = new System.Windows.Forms.RadioButton();
            this.DGV_View = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Customer_Type_Name);
            this.groupBox1.Controls.Add(this.CB_Genre);
            this.groupBox1.Controls.Add(this.Btn_Close);
            this.groupBox1.Controls.Add(this.Btn_Search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RB_Rental_Video);
            this.groupBox1.Controls.Add(this.RB_Customer_Rank);
            this.groupBox1.Controls.Add(this.RB_Video_Rank);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조회 정보";
            // 
            // CB_Customer_Type_Name
            // 
            this.CB_Customer_Type_Name.FormattingEnabled = true;
            this.CB_Customer_Type_Name.Location = new System.Drawing.Point(500, 74);
            this.CB_Customer_Type_Name.Name = "CB_Customer_Type_Name";
            this.CB_Customer_Type_Name.Size = new System.Drawing.Size(121, 28);
            this.CB_Customer_Type_Name.TabIndex = 10;
            // 
            // CB_Genre
            // 
            this.CB_Genre.FormattingEnabled = true;
            this.CB_Genre.Location = new System.Drawing.Point(500, 37);
            this.CB_Genre.Name = "CB_Genre";
            this.CB_Genre.Size = new System.Drawing.Size(121, 28);
            this.CB_Genre.TabIndex = 9;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(737, 37);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(92, 67);
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.Text = "나가기";
            this.Btn_Close.UseVisualStyleBackColor = true;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(639, 37);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(92, 67);
            this.Btn_Search.TabIndex = 7;
            this.Btn_Search.Text = "검색";
            this.Btn_Search.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "고객 신분 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "장르 :";
            // 
            // RB_Rental_Video
            // 
            this.RB_Rental_Video.AutoSize = true;
            this.RB_Rental_Video.Location = new System.Drawing.Point(208, 38);
            this.RB_Rental_Video.Name = "RB_Rental_Video";
            this.RB_Rental_Video.Size = new System.Drawing.Size(174, 24);
            this.RB_Rental_Video.TabIndex = 2;
            this.RB_Rental_Video.TabStop = true;
            this.RB_Rental_Video.Text = "대여중인 비디오";
            this.RB_Rental_Video.UseVisualStyleBackColor = true;
            // 
            // RB_Customer_Rank
            // 
            this.RB_Customer_Rank.AutoSize = true;
            this.RB_Customer_Rank.Location = new System.Drawing.Point(17, 78);
            this.RB_Customer_Rank.Name = "RB_Customer_Rank";
            this.RB_Customer_Rank.Size = new System.Drawing.Size(161, 24);
            this.RB_Customer_Rank.TabIndex = 1;
            this.RB_Customer_Rank.TabStop = true;
            this.RB_Customer_Rank.Text = "고객 대여 순위";
            this.RB_Customer_Rank.UseVisualStyleBackColor = true;
            // 
            // RB_Video_Rank
            // 
            this.RB_Video_Rank.AutoSize = true;
            this.RB_Video_Rank.Location = new System.Drawing.Point(17, 38);
            this.RB_Video_Rank.Name = "RB_Video_Rank";
            this.RB_Video_Rank.Size = new System.Drawing.Size(181, 24);
            this.RB_Video_Rank.TabIndex = 0;
            this.RB_Video_Rank.TabStop = true;
            this.RB_Video_Rank.Text = "비디오 대여 순위";
            this.RB_Video_Rank.UseVisualStyleBackColor = true;
            // 
            // DGV_View
            // 
            this.DGV_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_View.Location = new System.Drawing.Point(12, 149);
            this.DGV_View.Name = "DGV_View";
            this.DGV_View.RowTemplate.Height = 23;
            this.DGV_View.Size = new System.Drawing.Size(846, 289);
            this.DGV_View.TabIndex = 11;
            // 
            // Video_View_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.DGV_View);
            this.Controls.Add(this.groupBox1);
            this.Name = "Video_View_Management";
            this.Text = "비디오 조회 관리";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_Customer_Type_Name;
        private System.Windows.Forms.ComboBox CB_Genre;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RB_Rental_Video;
        private System.Windows.Forms.RadioButton RB_Customer_Rank;
        private System.Windows.Forms.RadioButton RB_Video_Rank;
        private System.Windows.Forms.DataGridView DGV_View;
    }
}