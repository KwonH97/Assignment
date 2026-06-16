namespace Video
{
    partial class Video_Output
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Genre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Rental_List = new System.Windows.Forms.Button();
            this.Btn_List = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "비디오 장르 :";
            // 
            // CB_Genre
            // 
            this.CB_Genre.Font = new System.Drawing.Font("굴림", 15F);
            this.CB_Genre.FormattingEnabled = true;
            this.CB_Genre.Location = new System.Drawing.Point(148, 21);
            this.CB_Genre.Name = "CB_Genre";
            this.CB_Genre.Size = new System.Drawing.Size(249, 28);
            this.CB_Genre.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Rental_List);
            this.groupBox1.Controls.Add(this.Btn_List);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox1.Location = new System.Drawing.Point(16, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "엑셀로 출력";
            // 
            // Btn_Rental_List
            // 
            this.Btn_Rental_List.Location = new System.Drawing.Point(215, 43);
            this.Btn_Rental_List.Name = "Btn_Rental_List";
            this.Btn_Rental_List.Size = new System.Drawing.Size(134, 37);
            this.Btn_Rental_List.TabIndex = 8;
            this.Btn_Rental_List.Text = "대여 현황";
            this.Btn_Rental_List.UseVisualStyleBackColor = true;
            // 
            // Btn_List
            // 
            this.Btn_List.Location = new System.Drawing.Point(36, 43);
            this.Btn_List.Name = "Btn_List";
            this.Btn_List.Size = new System.Drawing.Size(134, 37);
            this.Btn_List.TabIndex = 7;
            this.Btn_List.Text = "비디오 목록";
            this.Btn_List.UseVisualStyleBackColor = true;
            // 
            // Video_Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 207);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CB_Genre);
            this.Controls.Add(this.label1);
            this.Name = "Video_Output";
            this.Text = "비디오 출력";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Genre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Rental_List;
        private System.Windows.Forms.Button Btn_List;
    }
}