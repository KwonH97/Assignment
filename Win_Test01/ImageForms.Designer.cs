namespace Win_Test01
{
    partial class ImageForms
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Undo = new System.Windows.Forms.Button();
            this.Btn_Copy = new System.Windows.Forms.Button();
            this.Btn_Cut = new System.Windows.Forms.Button();
            this.Btn_Paste = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Txt_Memo = new System.Windows.Forms.TextBox();
            this.Lbl_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Btn_Undo
            // 
            this.Btn_Undo.ImageList = this.imageList1;
            this.Btn_Undo.Location = new System.Drawing.Point(602, 27);
            this.Btn_Undo.Name = "Btn_Undo";
            this.Btn_Undo.Size = new System.Drawing.Size(106, 40);
            this.Btn_Undo.TabIndex = 1;
            this.Btn_Undo.Text = "실행 취소";
            this.Btn_Undo.UseVisualStyleBackColor = true;
            this.Btn_Undo.Click += new System.EventHandler(this.Btn_Undo_Click);
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.Location = new System.Drawing.Point(602, 96);
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Size = new System.Drawing.Size(106, 40);
            this.Btn_Copy.TabIndex = 2;
            this.Btn_Copy.Text = "복사";
            this.Btn_Copy.UseVisualStyleBackColor = true;
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            // 
            // Btn_Cut
            // 
            this.Btn_Cut.Location = new System.Drawing.Point(602, 164);
            this.Btn_Cut.Name = "Btn_Cut";
            this.Btn_Cut.Size = new System.Drawing.Size(106, 40);
            this.Btn_Cut.TabIndex = 3;
            this.Btn_Cut.Text = "잘라내기";
            this.Btn_Cut.UseVisualStyleBackColor = true;
            this.Btn_Cut.Click += new System.EventHandler(this.Btn_Cut_Click);
            // 
            // Btn_Paste
            // 
            this.Btn_Paste.Location = new System.Drawing.Point(602, 226);
            this.Btn_Paste.Name = "Btn_Paste";
            this.Btn_Paste.Size = new System.Drawing.Size(106, 40);
            this.Btn_Paste.TabIndex = 4;
            this.Btn_Paste.Text = "붙여넣기";
            this.Btn_Paste.UseVisualStyleBackColor = true;
            this.Btn_Paste.Click += new System.EventHandler(this.Btn_Paste_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(602, 296);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(106, 40);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "종료";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Txt_Memo
            // 
            this.Txt_Memo.Location = new System.Drawing.Point(12, 12);
            this.Txt_Memo.Multiline = true;
            this.Txt_Memo.Name = "Txt_Memo";
            this.Txt_Memo.Size = new System.Drawing.Size(550, 313);
            this.Txt_Memo.TabIndex = 6;
            // 
            // Lbl_Message
            // 
            this.Lbl_Message.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_Message.Location = new System.Drawing.Point(12, 366);
            this.Lbl_Message.Name = "Lbl_Message";
            this.Lbl_Message.Size = new System.Drawing.Size(776, 75);
            this.Lbl_Message.TabIndex = 7;
            this.Lbl_Message.Text = "label1";
            this.Lbl_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Message);
            this.Controls.Add(this.Txt_Memo);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Paste);
            this.Controls.Add(this.Btn_Cut);
            this.Controls.Add(this.Btn_Copy);
            this.Controls.Add(this.Btn_Undo);
            this.Name = "ImageForms";
            this.Text = "ImageForms";
            this.Load += new System.EventHandler(this.ImageForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_Undo;
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.Button Btn_Cut;
        private System.Windows.Forms.Button Btn_Paste;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.TextBox Txt_Memo;
        private System.Windows.Forms.Label Lbl_Message;
    }
}