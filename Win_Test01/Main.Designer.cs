namespace Win_Test01
{
    partial class Main
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
            this.Btn_Child = new System.Windows.Forms.Button();
            this.Btn_Own = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Child
            // 
            this.Btn_Child.Location = new System.Drawing.Point(66, 23);
            this.Btn_Child.Name = "Btn_Child";
            this.Btn_Child.Size = new System.Drawing.Size(671, 127);
            this.Btn_Child.TabIndex = 0;
            this.Btn_Child.Text = "자식폼";
            this.Btn_Child.UseVisualStyleBackColor = true;
            this.Btn_Child.Click += new System.EventHandler(this.Btn_Child_Click);
            // 
            // Btn_Own
            // 
            this.Btn_Own.Location = new System.Drawing.Point(62, 166);
            this.Btn_Own.Name = "Btn_Own";
            this.Btn_Own.Size = new System.Drawing.Size(671, 127);
            this.Btn_Own.TabIndex = 1;
            this.Btn_Own.Text = "소유폼";
            this.Btn_Own.UseVisualStyleBackColor = true;
            this.Btn_Own.Click += new System.EventHandler(this.Btn_Own_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(62, 311);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(671, 127);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.Text = "종료";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Own);
            this.Controls.Add(this.Btn_Child);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Child;
        private System.Windows.Forms.Button Btn_Own;
        private System.Windows.Forms.Button Btn_Exit;
    }
}