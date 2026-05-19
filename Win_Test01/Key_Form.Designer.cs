namespace Win_Test01
{
    partial class Key_Form
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
            this.Lbl_Mag = new System.Windows.Forms.Label();
            this.Txt_Memo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Mag
            // 
            this.Lbl_Mag.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Mag.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_Mag.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Mag.Name = "Lbl_Mag";
            this.Lbl_Mag.Size = new System.Drawing.Size(800, 84);
            this.Lbl_Mag.TabIndex = 0;
            this.Lbl_Mag.Text = "label1";
            this.Lbl_Mag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Mag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_Mag_MouseDown);
            // 
            // Txt_Memo
            // 
            this.Txt_Memo.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Txt_Memo.Location = new System.Drawing.Point(46, 87);
            this.Txt_Memo.Multiline = true;
            this.Txt_Memo.Name = "Txt_Memo";
            this.Txt_Memo.Size = new System.Drawing.Size(689, 338);
            this.Txt_Memo.TabIndex = 1;
            this.Txt_Memo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Memo_KeyDown);
            this.Txt_Memo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Memo_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Key_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Memo);
            this.Controls.Add(this.Lbl_Mag);
            this.KeyPreview = true;
            this.Name = "Key_Form";
            this.Text = "Key_Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Mag;
        private System.Windows.Forms.TextBox Txt_Memo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}