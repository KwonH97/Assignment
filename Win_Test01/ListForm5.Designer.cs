namespace Win_Test01
{
    partial class ListForm5
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
            this.List_Source = new System.Windows.Forms.ListBox();
            this.List_Dest = new System.Windows.Forms.ListBox();
            this.Move = new System.Windows.Forms.Button();
            this.Move2 = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_Source
            // 
            this.List_Source.FormattingEnabled = true;
            this.List_Source.ItemHeight = 12;
            this.List_Source.Location = new System.Drawing.Point(47, 40);
            this.List_Source.Name = "List_Source";
            this.List_Source.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.List_Source.Size = new System.Drawing.Size(254, 352);
            this.List_Source.TabIndex = 0;
            // 
            // List_Dest
            // 
            this.List_Dest.FormattingEnabled = true;
            this.List_Dest.ItemHeight = 12;
            this.List_Dest.Location = new System.Drawing.Point(485, 40);
            this.List_Dest.Name = "List_Dest";
            this.List_Dest.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.List_Dest.Size = new System.Drawing.Size(286, 352);
            this.List_Dest.TabIndex = 1;
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(354, 111);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(75, 23);
            this.Move.TabIndex = 2;
            this.Move.Text = "▶▶▶▶▶▶";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // Move2
            // 
            this.Move2.Location = new System.Drawing.Point(354, 214);
            this.Move2.Name = "Move2";
            this.Move2.Size = new System.Drawing.Size(75, 23);
            this.Move2.TabIndex = 3;
            this.Move2.Text = "◀◀◀◀◀";
            this.Move2.UseVisualStyleBackColor = true;
            this.Move2.Click += new System.EventHandler(this.Move2_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(354, 284);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 23);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "검색";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(598, 462);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ListForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Move2);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.List_Dest);
            this.Controls.Add(this.List_Source);
            this.Name = "ListForm5";
            this.Text = "v";
            this.Load += new System.EventHandler(this.ListForm5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List_Source;
        private System.Windows.Forms.ListBox List_Dest;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button Move2;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}