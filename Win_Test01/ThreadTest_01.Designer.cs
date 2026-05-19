namespace Win_Test01
{
    partial class ThreadTest_01
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
            this.label112 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label112
            // 
            this.label112.Font = new System.Drawing.Font("굴림", 25F);
            this.label112.Location = new System.Drawing.Point(12, 20);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(674, 112);
            this.label112.TabIndex = 0;
            this.label112.Text = "label1";
            this.label112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ThreadTest_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label112);
            this.Name = "ThreadTest_01";
            this.Text = "ThreadTest_01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThreadTest_01_FormClosed);
            this.Load += new System.EventHandler(this.ThreadTest_01_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Button button1;
    }
}