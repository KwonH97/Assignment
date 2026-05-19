namespace Win_Test01
{
    partial class Dlg_Test
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
            this.Txt_Memo = new System.Windows.Forms.TextBox();
            this.Btn_Font = new System.Windows.Forms.Button();
            this.Btn_Color = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Txt_Memo
            // 
            this.Txt_Memo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Txt_Memo.Location = new System.Drawing.Point(0, 0);
            this.Txt_Memo.Multiline = true;
            this.Txt_Memo.Name = "Txt_Memo";
            this.Txt_Memo.Size = new System.Drawing.Size(598, 450);
            this.Txt_Memo.TabIndex = 0;
            // 
            // Btn_Font
            // 
            this.Btn_Font.Location = new System.Drawing.Point(632, 12);
            this.Btn_Font.Name = "Btn_Font";
            this.Btn_Font.Size = new System.Drawing.Size(111, 46);
            this.Btn_Font.TabIndex = 1;
            this.Btn_Font.Text = "Font";
            this.Btn_Font.UseVisualStyleBackColor = true;
            this.Btn_Font.Click += new System.EventHandler(this.Btn_Font_Click);
            // 
            // Btn_Color
            // 
            this.Btn_Color.Location = new System.Drawing.Point(632, 86);
            this.Btn_Color.Name = "Btn_Color";
            this.Btn_Color.Size = new System.Drawing.Size(111, 46);
            this.Btn_Color.TabIndex = 2;
            this.Btn_Color.Text = "Color";
            this.Btn_Color.UseVisualStyleBackColor = true;
            this.Btn_Color.Click += new System.EventHandler(this.Btn_Color_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(632, 171);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(111, 46);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(632, 252);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(111, 46);
            this.Btn_Open.TabIndex = 4;
            this.Btn_Open.Text = "불러오기";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(632, 330);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(111, 46);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "종료";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Dlg_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Color);
            this.Controls.Add(this.Btn_Font);
            this.Controls.Add(this.Txt_Memo);
            this.Name = "Dlg_Test";
            this.Text = "Dlg_Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Memo;
        private System.Windows.Forms.Button Btn_Font;
        private System.Windows.Forms.Button Btn_Color;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}