using DemoQuiz.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQuiz
{
    public partial class frmMain : Form
    {
        private Account acc;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenFrmLogin();
            ControlMenuTop(false);
        }

        
        private void Frm_accountAuthentication(Account acc)
        {
            this.acc = acc;
            OpenFrmHome();
            ControlMenuTop(true);
            ControlMenuTopRule();
            lblWelcome.Text = string.Format("Hello {0}", acc.FullName);
        }

       
        private void menuLogin_Click(object sender, EventArgs e)
        {
            OpenFrmLogin();
        }

        private void menuHelper_Click(object sender, EventArgs e)
        {
            OpenFrmHelper();
        }
        
        private void menuHome_Click(object sender, EventArgs e)
        {
            OpenFrmHome();
        }
        
        private void OpenFrmHelper()
        {
            Form frmChild = this.MdiChildren.OfType<frmHelper>().FirstOrDefault();

            if (frmChild == null)
            {
                frmHelper frm = new frmHelper();
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                //frmLogin.chungThucTaiKhoan += FrmLogin_chungThucTaiKhoan1;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void OpenFrmLogin()
        {
            Form frmChild = this.MdiChildren.OfType<frmLogin>().FirstOrDefault();

            if (frmChild == null)
            {
                frmLogin frm = new frmLogin();
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.accountAuthentication += Frm_accountAuthentication;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void OpenFrmHome()
        {
            Form frmChild = this.MdiChildren.OfType<frmHome>().FirstOrDefault();

            if (frmChild == null)
            {
                frmHome frm = new frmHome(acc);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void ControlMenuTopRule()
        {
            if (int.Parse(acc.role) == 0)
            {
                menuHistoryExam.Visible = true;
                menuTryExam.Visible = true;
                menuCreateExam.Visible = false;
                menuHistoryCreateExam.Visible = false;
            }
            else
            {
                menuCreateExam.Visible = true;
                menuHistoryCreateExam.Visible = true;
                menuHistoryExam.Visible = false;
                menuTryExam.Visible = false;
            }
        }

        private void ControlMenuTop(bool v)
        {
            menuHome.Visible = v;
            lblWelcome.Visible = v;
            btnLogout.Visible = v;
            menuSearch.Visible = v;
            menuHistoryExam.Visible = v;
            menuTryExam.Visible = v;
            menuCreateExam.Visible = v;
            menuHistoryCreateExam.Visible = v;
            btnLogoutIcon.Visible = v;

            menuLogin.Visible = !v;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.acc = null;
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            ControlMenuTop(false);
            OpenFrmLogin();
        }

        private void menuTryExam_Click(object sender, EventArgs e)
        {
            OpenFrmTryExam();
        }

        private void OpenFrmTryExam()
        {
            Form frmChild = this.MdiChildren.OfType<frmTryExam>().FirstOrDefault();

            if (frmChild == null)
            {
                frmTryExam frm = new frmTryExam(acc);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void menuSearch_Click(object sender, EventArgs e)
        {
            Form frmChild = this.MdiChildren.OfType<frmSearch>().FirstOrDefault();

            if (frmChild == null)
            {
                frmSearch frm = new frmSearch(acc);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void menuCreateExam_Click(object sender, EventArgs e)
        {
            Form frmChild = this.MdiChildren.OfType<frmCreateExam>().FirstOrDefault();

            if (frmChild == null)
            {
                frmCreateExam frm = new frmCreateExam(acc);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void menuHistoryCreateExam_Click(object sender, EventArgs e)
        {
            Form frmChild = this.MdiChildren.OfType<frmHistoryCreateExam>().FirstOrDefault();

            if (frmChild == null)
            {
                frmHistoryCreateExam frm = new frmHistoryCreateExam(acc);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void menuListExam_Click(object sender, EventArgs e)
        {

        }

        private void menuHistoryExam_Click(object sender, EventArgs e)
        {
            Form frmChild = this.MdiChildren.OfType<frmHistoryExam>().FirstOrDefault();

            if (frmChild == null)
            {
                frmHistoryExam frm = new frmHistoryExam(acc);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Đóng chương trình!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
