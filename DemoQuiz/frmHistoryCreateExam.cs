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
    public partial class frmHistoryCreateExam : Form
    {
        private Account acc;
        public frmHistoryCreateExam()
        {
            InitializeComponent();
        }

        public frmHistoryCreateExam(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void frmHistoryCreateExam_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            lblFullName.Text = acc.FullName;
            // clear table first show list students
            dgvHistoryCreateExam.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Exam exam in _dbContext.Exams.Where(p => p.AccountID == acc.AccountID).ToList())
                {
                    if(exam != null)
                    {
                        dem++;
                        viTriDong = dgvHistoryCreateExam.Rows.Add();
                        dgvHistoryCreateExam.Rows[viTriDong].Cells[0].Value = exam.ExamID;
                        dgvHistoryCreateExam.Rows[viTriDong].Cells[1].Value = exam.ExamName;
                        dgvHistoryCreateExam.Rows[viTriDong].Cells[2].Value = exam.Subject.SubjectName;
                        dgvHistoryCreateExam.Rows[viTriDong].Cells[3].Value = exam.Account.Class1.Faculty.FacultyName;
                        dgvHistoryCreateExam.Rows[viTriDong].Cells[4].Value = exam.dateCreate;
                        dgvHistoryCreateExam.Rows[viTriDong].Cells[5].Value = exam.TotalQuiz;
                    }
                }
            }
        }
    }
}
