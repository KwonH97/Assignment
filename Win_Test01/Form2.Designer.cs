namespace Win_Test01
{
    partial class Form2
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
            this.Btn_Modal = new System.Windows.Forms.Button();
            this.Btn_Modeless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Modal
            // 
            this.Btn_Modal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Modal.Location = new System.Drawing.Point(102, 41);
            this.Btn_Modal.Name = "Btn_Modal";
            this.Btn_Modal.Size = new System.Drawing.Size(590, 124);
            this.Btn_Modal.TabIndex = 0;
            this.Btn_Modal.Text = "Modal";
            this.Btn_Modal.UseVisualStyleBackColor = false;
            this.Btn_Modal.Click += new System.EventHandler(this.Btn_Modal_Click);
            // 
            // Btn_Modeless
            // 
            this.Btn_Modeless.Location = new System.Drawing.Point(105, 226);
            this.Btn_Modeless.Name = "Btn_Modeless";
            this.Btn_Modeless.Size = new System.Drawing.Size(586, 143);
            this.Btn_Modeless.TabIndex = 1;
            this.Btn_Modeless.Text = "Modeless";
            this.Btn_Modeless.UseVisualStyleBackColor = true;
            this.Btn_Modeless.Click += new System.EventHandler(this.Btn_Modeless_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Modeless);
            this.Controls.Add(this.Btn_Modal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Modal;
        private System.Windows.Forms.Button Btn_Modeless;
    }
}