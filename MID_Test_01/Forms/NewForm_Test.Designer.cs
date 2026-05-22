namespace MID_Test_01
{
    partial class NewForm_Test
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
            this.SuspendLayout();
            // 
            // Txt_Memo
            // 
            this.Txt_Memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Memo.Location = new System.Drawing.Point(0, 0);
            this.Txt_Memo.Multiline = true;
            this.Txt_Memo.Name = "Txt_Memo";
            this.Txt_Memo.Size = new System.Drawing.Size(800, 450);
            this.Txt_Memo.TabIndex = 0;
            // 
            // NewForm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_Memo);
            this.Name = "NewForm_Test";
            this.Text = "문서1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Memo;
    }
}