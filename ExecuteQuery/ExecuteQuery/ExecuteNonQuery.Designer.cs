namespace ExecuteQuery
{
    partial class ExecuteNonQuery
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Create_Table = new System.Windows.Forms.Button();
            this.Drop_Table = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 35F);
            this.textBox1.Location = new System.Drawing.Point(343, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 61);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 35F);
            this.textBox2.Location = new System.Drawing.Point(343, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(532, 61);
            this.textBox2.TabIndex = 1;
            // 
            // Create_Table
            // 
            this.Create_Table.Font = new System.Drawing.Font("굴림", 20F);
            this.Create_Table.Location = new System.Drawing.Point(199, 30);
            this.Create_Table.Name = "Create_Table";
            this.Create_Table.Size = new System.Drawing.Size(203, 68);
            this.Create_Table.TabIndex = 3;
            this.Create_Table.Text = "테이블생성";
            this.Create_Table.UseVisualStyleBackColor = true;
            this.Create_Table.Click += new System.EventHandler(this.Create_Table_Click);
            // 
            // Drop_Table
            // 
            this.Drop_Table.Font = new System.Drawing.Font("굴림", 20F);
            this.Drop_Table.Location = new System.Drawing.Point(588, 30);
            this.Drop_Table.Name = "Drop_Table";
            this.Drop_Table.Size = new System.Drawing.Size(203, 68);
            this.Drop_Table.TabIndex = 4;
            this.Drop_Table.Text = "테이블삭제";
            this.Drop_Table.UseVisualStyleBackColor = true;
            this.Drop_Table.Click += new System.EventHandler(this.Drop_Table_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 30F);
            this.label1.Location = new System.Drawing.Point(133, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "학번 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 30F);
            this.label2.Location = new System.Drawing.Point(133, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "이름 :";
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Font = new System.Drawing.Font("굴림", 25F);
            this.Btn_Insert.Location = new System.Drawing.Point(362, 381);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(242, 78);
            this.Btn_Insert.TabIndex = 7;
            this.Btn_Insert.Text = "삽입";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // ExecuteNonQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 558);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Drop_Table);
            this.Controls.Add(this.Create_Table);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "ExecuteNonQuery";
            this.Text = "ExecuteNonQuery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Create_Table;
        private System.Windows.Forms.Button Drop_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Insert;
    }
}