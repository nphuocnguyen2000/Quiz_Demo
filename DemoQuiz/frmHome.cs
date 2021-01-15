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
    public partial class frmHome : Form
    {
        private Account acc;
        public frmHome()
        {
            InitializeComponent();
        }
        public frmHome(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            ShowProfile();
            if (int.Parse(acc.role) == 0)
                ControlCheckRole(true);
            else 
                ControlCheckRole(false);
        }

        private void ControlCheckRole(bool v)
        {
            btnTryExam.Visible = v;
            btnHistoryExam.Visible = v;
            btnCreateExam.Visible = !v;
            btnHistoryCreateExam.Visible = !v;
        }

        private void ShowProfile()
        {
            lblFullName.Text = acc.FullName;
            lblFacultyName.Text = acc.Faculty1.FacultyName;
            _ = int.Parse(acc.role) == 0 ? lblClassName.Text = acc.Class1.ClassName : lblClassName.Text = "";
            _ = int.Parse(acc.role) == 0 ? lblRoleAccount.Text = "Student" : lblRoleAccount.Text = "Teacher";
            if(int.Parse(acc.role) != 0)
                lblClass.Visible = false;
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            Form frmChild = this.MdiChildren.OfType<frmSearch>().FirstOrDefault();

            if (frmChild == null)
            {
                frmSearch frm = new frmSearch(acc);
                //frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                //frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }
    }
}
