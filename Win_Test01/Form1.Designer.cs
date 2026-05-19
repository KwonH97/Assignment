namespace Win_Test01
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
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancle = new System.Windows.Forms.Button();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Lbl_Pass = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(923, 100);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(150, 45);
            this.Btn_Ok.TabIndex = 4;
            this.Btn_Ok.Text = "확인";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Cancle
            // 
            this.Btn_Cancle.Location = new System.Drawing.Point(923, 261);
            this.Btn_Cancle.Name = "Btn_Cancle";
            this.Btn_Cancle.Size = new System.Drawing.Size(150, 45);
            this.Btn_Cancle.TabIndex = 5;
            this.Btn_Cancle.Text = "취소";
            this.Btn_Cancle.UseVisualStyleBackColor = true;
            this.Btn_Cancle.Click += new System.EventHandler(this.Btn_Cancle_Click);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("굴림", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_ID.Location = new System.Drawing.Point(261, 86);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(161, 67);
            this.Lbl_ID.TabIndex = 0;
            this.Lbl_ID.Text = "ID : ";
            this.Lbl_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Pass
            // 
            this.Lbl_Pass.AutoSize = true;
            this.Lbl_Pass.Font = new System.Drawing.Font("굴림", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_Pass.Location = new System.Drawing.Point(12, 247);
            this.Lbl_Pass.Name = "Lbl_Pass";
            this.Lbl_Pass.Size = new System.Drawing.Size(410, 67);
            this.Lbl_Pass.TabIndex = 1;
            this.Lbl_Pass.Text = "PassWord : ";
            this.Lbl_Pass.Click += new System.EventHandler(this.Lbl_Pass_Click);
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_ID.Font = new System.Drawing.Font("굴림", 30F);
            this.Txt_ID.Location = new System.Drawing.Point(412, 100);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(438, 53);
            this.Txt_ID.TabIndex = 2;
            this.Txt_ID.TextChanged += new System.EventHandler(this.Txt_ID_TextChanged);
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Font = new System.Drawing.Font("굴림", 30F);
            this.Txt_Pass.Location = new System.Drawing.Point(412, 261);
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.PasswordChar = '*';
            this.Txt_Pass.Size = new System.Drawing.Size(438, 53);
            this.Txt_Pass.TabIndex = 3;
            this.Txt_Pass.TextChanged += new System.EventHandler(this.Txt_Pass_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 582);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Lbl_Pass);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Btn_Cancle);
            this.Controls.Add(this.Btn_Ok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancle;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Label Lbl_Pass;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.TextBox Txt_Pass;
    }
}

