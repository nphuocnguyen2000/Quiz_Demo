
namespace DemoQuiz
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogoutIcon = new System.Windows.Forms.Button();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateExam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistoryCreateExam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTryExam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistoryExam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuHome,
            this.menuSearch,
            this.menuCreateExam,
            this.menuHistoryCreateExam,
            this.menuTryExam,
            this.menuHistoryExam,
            this.menuHelper});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.Window;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Location = new System.Drawing.Point(836, 5);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(184, 17);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "______________________";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.CausesValidation = false;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(1087, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 28);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogoutIcon
            // 
            this.btnLogoutIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogoutIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogoutIcon.BackgroundImage")));
            this.btnLogoutIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoutIcon.FlatAppearance.BorderSize = 0;
            this.btnLogoutIcon.Location = new System.Drawing.Point(1170, 3);
            this.btnLogoutIcon.Name = "btnLogoutIcon";
            this.btnLogoutIcon.Size = new System.Drawing.Size(41, 28);
            this.btnLogoutIcon.TabIndex = 5;
            this.btnLogoutIcon.UseVisualStyleBackColor = true;
            this.btnLogoutIcon.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.Image = ((System.Drawing.Image)(resources.GetObject("menuLogin.Image")));
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(116, 24);
            this.menuLogin.Text = "Đăng nhập";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuHome
            // 
            this.menuHome.Image = ((System.Drawing.Image)(resources.GetObject("menuHome.Image")));
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(84, 24);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // menuSearch
            // 
            this.menuSearch.Image = ((System.Drawing.Image)(resources.GetObject("menuSearch.Image")));
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(104, 24);
            this.menuSearch.Text = "Tìm kiếm";
            this.menuSearch.Click += new System.EventHandler(this.menuSearch_Click);
            // 
            // menuCreateExam
            // 
            this.menuCreateExam.Image = ((System.Drawing.Image)(resources.GetObject("menuCreateExam.Image")));
            this.menuCreateExam.Name = "menuCreateExam";
            this.menuCreateExam.Size = new System.Drawing.Size(110, 24);
            this.menuCreateExam.Text = "Tạo đề thi";
            this.menuCreateExam.Click += new System.EventHandler(this.menuCreateExam_Click);
            // 
            // menuHistoryCreateExam
            // 
            this.menuHistoryCreateExam.Image = ((System.Drawing.Image)(resources.GetObject("menuHistoryCreateExam.Image")));
            this.menuHistoryCreateExam.Name = "menuHistoryCreateExam";
            this.menuHistoryCreateExam.Size = new System.Drawing.Size(135, 24);
            this.menuHistoryCreateExam.Text = "Lịch sử tạo đề";
            this.menuHistoryCreateExam.Click += new System.EventHandler(this.menuHistoryCreateExam_Click);
            // 
            // menuTryExam
            // 
            this.menuTryExam.Image = ((System.Drawing.Image)(resources.GetObject("menuTryExam.Image")));
            this.menuTryExam.Name = "menuTryExam";
            this.menuTryExam.Size = new System.Drawing.Size(102, 24);
            this.menuTryExam.Text = "Luyện thi";
            this.menuTryExam.Click += new System.EventHandler(this.menuTryExam_Click);
            // 
            // menuHistoryExam
            // 
            this.menuHistoryExam.Image = ((System.Drawing.Image)(resources.GetObject("menuHistoryExam.Image")));
            this.menuHistoryExam.Name = "menuHistoryExam";
            this.menuHistoryExam.Size = new System.Drawing.Size(142, 24);
            this.menuHistoryExam.Text = "Lịch sử làm bài";
            this.menuHistoryExam.Click += new System.EventHandler(this.menuHistoryExam_Click);
            // 
            // menuHelper
            // 
            this.menuHelper.Image = ((System.Drawing.Image)(resources.GetObject("menuHelper.Image")));
            this.menuHelper.Name = "menuHelper";
            this.menuHelper.Size = new System.Drawing.Size(86, 24);
            this.menuHelper.Text = "Hỗ trợ";
            this.menuHelper.Click += new System.EventHandler(this.menuHelper_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1211, 588);
            this.Controls.Add(this.btnLogoutIcon);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblWelcome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuHelper;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;
        private System.Windows.Forms.ToolStripMenuItem menuCreateExam;
        private System.Windows.Forms.ToolStripMenuItem menuHistoryCreateExam;
        private System.Windows.Forms.ToolStripMenuItem menuTryExam;
        private System.Windows.Forms.ToolStripMenuItem menuHistoryExam;
        private System.Windows.Forms.Button btnLogoutIcon;
    }
}