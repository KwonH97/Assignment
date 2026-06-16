namespace Video
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Video_Rental = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Video_Information = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Custom_Information = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Video_View_Management = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Video_Rental = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Video_Information = new System.Windows.Forms.ToolStripButton();
            this.TSB_Custom_Information = new System.Windows.Forms.ToolStripButton();
            this.TSB_Video_View_Management = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Option = new System.Windows.Forms.ToolStripButton();
            this.비디오정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.비디오대여설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_File,
            this.TSM_Video_Rental,
            this.TSM_Video_Information,
            this.TSM_Custom_Information,
            this.TSM_Video_View_Management,
            this.TSM_Option,
            this.TSM_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM_File
            // 
            this.TSM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.TSM_File.Name = "TSM_File";
            this.TSM_File.Size = new System.Drawing.Size(43, 20);
            this.TSM_File.Text = "파일";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // TSM_Video_Rental
            // 
            this.TSM_Video_Rental.Name = "TSM_Video_Rental";
            this.TSM_Video_Rental.Size = new System.Drawing.Size(112, 20);
            this.TSM_Video_Rental.Text = "비디오 대여/반납";
            this.TSM_Video_Rental.Click += new System.EventHandler(this.TSM_Video_Rental_Click);
            // 
            // TSM_Video_Information
            // 
            this.TSM_Video_Information.Name = "TSM_Video_Information";
            this.TSM_Video_Information.Size = new System.Drawing.Size(83, 20);
            this.TSM_Video_Information.Text = "비디오 관리";
            this.TSM_Video_Information.Click += new System.EventHandler(this.TSM_Video_Information_Click);
            // 
            // TSM_Custom_Information
            // 
            this.TSM_Custom_Information.Name = "TSM_Custom_Information";
            this.TSM_Custom_Information.Size = new System.Drawing.Size(71, 20);
            this.TSM_Custom_Information.Text = "고객 관리";
            this.TSM_Custom_Information.Click += new System.EventHandler(this.TSM_Custom_Information_Click);
            // 
            // TSM_Video_View_Management
            // 
            this.TSM_Video_View_Management.Name = "TSM_Video_View_Management";
            this.TSM_Video_View_Management.Size = new System.Drawing.Size(71, 20);
            this.TSM_Video_View_Management.Text = "정보 조회";
            this.TSM_Video_View_Management.Click += new System.EventHandler(this.TSM_Video_View_Management_Click);
            // 
            // TSM_Option
            // 
            this.TSM_Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.비디오정보ToolStripMenuItem,
            this.toolStripSeparator3,
            this.비디오대여설정ToolStripMenuItem});
            this.TSM_Option.Name = "TSM_Option";
            this.TSM_Option.Size = new System.Drawing.Size(67, 20);
            this.TSM_Option.Text = "환경설정";
            // 
            // TSM_Help
            // 
            this.TSM_Help.Name = "TSM_Help";
            this.TSM_Help.Size = new System.Drawing.Size(55, 20);
            this.TSM_Help.Text = "도움말";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Video_Rental,
            this.toolStripSeparator1,
            this.TSB_Video_Information,
            this.TSB_Custom_Information,
            this.TSB_Video_View_Management,
            this.toolStripSeparator2,
            this.TSB_Option});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1205, 76);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Video_Rental
            // 
            this.TSB_Video_Rental.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.TSB_Video_Rental.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Video_Rental.Image")));
            this.TSB_Video_Rental.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Video_Rental.Name = "TSB_Video_Rental";
            this.TSB_Video_Rental.Size = new System.Drawing.Size(84, 73);
            this.TSB_Video_Rental.Text = "대여/반납";
            this.TSB_Video_Rental.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_Video_Rental.Click += new System.EventHandler(this.TSB_Video_Rental_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 76);
            // 
            // TSB_Video_Information
            // 
            this.TSB_Video_Information.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Video_Information.Image")));
            this.TSB_Video_Information.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Video_Information.Name = "TSB_Video_Information";
            this.TSB_Video_Information.Size = new System.Drawing.Size(83, 73);
            this.TSB_Video_Information.Text = "비디오관리";
            this.TSB_Video_Information.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_Video_Information.Click += new System.EventHandler(this.TSB_Video_Information_Click);
            // 
            // TSB_Custom_Information
            // 
            this.TSB_Custom_Information.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Custom_Information.Image")));
            this.TSB_Custom_Information.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Custom_Information.Name = "TSB_Custom_Information";
            this.TSB_Custom_Information.Size = new System.Drawing.Size(69, 73);
            this.TSB_Custom_Information.Text = "고객관리";
            this.TSB_Custom_Information.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_Custom_Information.ToolTipText = "고객관리";
            this.TSB_Custom_Information.Click += new System.EventHandler(this.TSB_Custom_Information_Click);
            // 
            // TSB_Video_View_Management
            // 
            this.TSB_Video_View_Management.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Video_View_Management.Image")));
            this.TSB_Video_View_Management.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Video_View_Management.Name = "TSB_Video_View_Management";
            this.TSB_Video_View_Management.Size = new System.Drawing.Size(69, 73);
            this.TSB_Video_View_Management.Text = "정보조회";
            this.TSB_Video_View_Management.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_Video_View_Management.Click += new System.EventHandler(this.TSB_Video_View_Management_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 76);
            // 
            // TSB_Option
            // 
            this.TSB_Option.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Option.Image")));
            this.TSB_Option.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Option.Name = "TSB_Option";
            this.TSB_Option.Size = new System.Drawing.Size(69, 73);
            this.TSB_Option.Text = "환경설정";
            this.TSB_Option.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_Option.Click += new System.EventHandler(this.TSB_Option_Click);
            // 
            // 비디오정보ToolStripMenuItem
            // 
            this.비디오정보ToolStripMenuItem.Name = "비디오정보ToolStripMenuItem";
            this.비디오정보ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.비디오정보ToolStripMenuItem.Text = "비디오 정보";
            this.비디오정보ToolStripMenuItem.Click += new System.EventHandler(this.비디오정보ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // 비디오대여설정ToolStripMenuItem
            // 
            this.비디오대여설정ToolStripMenuItem.Name = "비디오대여설정ToolStripMenuItem";
            this.비디오대여설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.비디오대여설정ToolStripMenuItem.Text = "비디오 대여 설정";
            this.비디오대여설정ToolStripMenuItem.Click += new System.EventHandler(this.비디오대여설정ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 582);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "비디오 관리 프로그램";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM_File;
        private System.Windows.Forms.ToolStripMenuItem TSM_Video_Rental;
        private System.Windows.Forms.ToolStripMenuItem TSM_Video_Information;
        private System.Windows.Forms.ToolStripMenuItem TSM_Custom_Information;
        private System.Windows.Forms.ToolStripMenuItem TSM_Video_View_Management;
        private System.Windows.Forms.ToolStripMenuItem TSM_Option;
        private System.Windows.Forms.ToolStripMenuItem TSM_Help;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Video_Rental;
        private System.Windows.Forms.ToolStripButton TSB_Video_Information;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_Custom_Information;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSB_Video_View_Management;
        private System.Windows.Forms.ToolStripButton TSB_Option;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비디오정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 비디오대여설정ToolStripMenuItem;
    }
}

