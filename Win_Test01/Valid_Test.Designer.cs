namespace Win_Test01
{
    partial class Valid_Test
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
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Lab_Email = new System.Windows.Forms.Label();
            this.Lab_Num = new System.Windows.Forms.Label();
            this.Lab_Pnum = new System.Windows.Forms.Label();
            this.Lbl_Massage = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Num = new System.Windows.Forms.TextBox();
            this.Txt_Pnum = new System.Windows.Forms.TextBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.Location = new System.Drawing.Point(57, 23);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(48, 12);
            this.Lab_Name.TabIndex = 0;
            this.Lab_Name.Text = "이름(&N)";
            // 
            // Lab_Email
            // 
            this.Lab_Email.AutoSize = true;
            this.Lab_Email.Location = new System.Drawing.Point(57, 85);
            this.Lab_Email.Name = "Lab_Email";
            this.Lab_Email.Size = new System.Drawing.Size(59, 12);
            this.Lab_Email.TabIndex = 2;
            this.Lab_Email.Text = "이메일(&E)";
            // 
            // Lab_Num
            // 
            this.Lab_Num.AutoSize = true;
            this.Lab_Num.Location = new System.Drawing.Point(57, 147);
            this.Lab_Num.Name = "Lab_Num";
            this.Lab_Num.Size = new System.Drawing.Size(71, 12);
            this.Lab_Num.TabIndex = 4;
            this.Lab_Num.Text = "전화번호(&T)";
            // 
            // Lab_Pnum
            // 
            this.Lab_Pnum.AutoSize = true;
            this.Lab_Pnum.Location = new System.Drawing.Point(57, 209);
            this.Lab_Pnum.Name = "Lab_Pnum";
            this.Lab_Pnum.Size = new System.Drawing.Size(59, 12);
            this.Lab_Pnum.TabIndex = 6;
            this.Lab_Pnum.Text = "휴대폰(&H)";
            // 
            // Lbl_Massage
            // 
            this.Lbl_Massage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_Massage.Font = new System.Drawing.Font("굴림", 20F);
            this.Lbl_Massage.Location = new System.Drawing.Point(0, 342);
            this.Lbl_Massage.Name = "Lbl_Massage";
            this.Lbl_Massage.Size = new System.Drawing.Size(629, 151);
            this.Lbl_Massage.TabIndex = 10;
            this.Lbl_Massage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(194, 20);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(390, 21);
            this.Txt_Name.TabIndex = 1;
            this.Txt_Name.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Name_Validating);
            this.Txt_Name.Validated += new System.EventHandler(this.Txt_Name_Validated);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(194, 83);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(390, 21);
            this.Txt_Email.TabIndex = 3;
            this.Txt_Email.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Email_Validating);
            this.Txt_Email.Validated += new System.EventHandler(this.Txt_Email_Validated);
            // 
            // Txt_Num
            // 
            this.Txt_Num.Location = new System.Drawing.Point(194, 146);
            this.Txt_Num.Name = "Txt_Num";
            this.Txt_Num.Size = new System.Drawing.Size(390, 21);
            this.Txt_Num.TabIndex = 5;
            this.Txt_Num.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Num_Validating);
            // 
            // Txt_Pnum
            // 
            this.Txt_Pnum.Location = new System.Drawing.Point(194, 209);
            this.Txt_Pnum.Name = "Txt_Pnum";
            this.Txt_Pnum.Size = new System.Drawing.Size(390, 21);
            this.Txt_Pnum.TabIndex = 7;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Ok.Location = new System.Drawing.Point(365, 246);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(103, 26);
            this.Btn_Ok.TabIndex = 8;
            this.Btn_Ok.Text = "확인";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.CausesValidation = false;
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(481, 246);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(103, 26);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "종료";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Valid_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 493);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Txt_Pnum);
            this.Controls.Add(this.Txt_Num);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Massage);
            this.Controls.Add(this.Lab_Pnum);
            this.Controls.Add(this.Lab_Num);
            this.Controls.Add(this.Lab_Email);
            this.Controls.Add(this.Lab_Name);
            this.Name = "Valid_Test";
            this.Text = "Valid_Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Name;
        private System.Windows.Forms.Label Lab_Email;
        private System.Windows.Forms.Label Lab_Num;
        private System.Windows.Forms.Label Lab_Pnum;
        private System.Windows.Forms.Label Lbl_Massage;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Num;
        private System.Windows.Forms.TextBox Txt_Pnum;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}