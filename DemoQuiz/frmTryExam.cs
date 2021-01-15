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
    public partial class frmTryExam : Form
    {
        private Account acc;
        public frmTryExam()
        {
            InitializeComponent();
        }

        public frmTryExam(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void frmTryExam_Load(object sender, EventArgs e)
        {
            ShowDgvExam();
        }

        private void ShowDgvExam()
        {
            // clear table first show list students
            dgvExam.Rows.Clear();
            int viTriDong, dem =0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Exam exam in _dbContext.Exams.ToList())
                {
                    dem++;
                    viTriDong = dgvExam.Rows.Add();
                    dgvExam.Rows[viTriDong].Cells[0].Value = dem.ToString();
                    dgvExam.Rows[viTriDong].Cells[1].Value = exam.ExamID;
                    dgvExam.Rows[viTriDong].Cells[2].Value = exam.ExamName;
                    dgvExam.Rows[viTriDong].Cells[3].Value = exam.Account.FullName;
                    dgvExam.Rows[viTriDong].Cells[4].Value = exam.Subject.SubjectName;
                    dgvExam.Rows[viTriDong].Cells[5].Value = exam.TotalQuiz;
                    dgvExam.Rows[viTriDong].Cells[6].Value = exam.TimeTotal;
                }
            }
        }

        private void dgvExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = e.RowIndex;
            txtExamID.Text = dgvExam.Rows[rowSelected].Cells[1].Value.ToString();
            txtExamName.Text = dgvExam.Rows[rowSelected].Cells[2].Value.ToString();
            txtTeacherName.Text = dgvExam.Rows[rowSelected].Cells[3].Value.ToString();
            txtSubjectName.Text = dgvExam.Rows[rowSelected].Cells[4].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtExamID.Text = "";
            txtExamName.Text = "";
            txtTeacherName.Text = "";
            txtSubjectName.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text == "")
            {
                MessageBox.Show("Không tìm thấy đề thi này !");
                return;
            }
            Form frmChild = this.MdiChildren.OfType<frmExamDetail>().FirstOrDefault();

            if (frmChild == null)
            {
                frmExamDetail frm = new frmExamDetail(int.Parse(txtExamID.Text), acc);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Dock = DockStyle.Fill;
                frm.Focus();
                frm.Show();
                return;
            }
            frmChild.Activate();
        }
    }
}
