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
    public partial class frmResultExam : Form
    {
        private Result result;
        public frmResultExam()
        {
            InitializeComponent();
        }
        public frmResultExam(Result result)
        {
            InitializeComponent();
            this.result = result;
        }

        private void frmResultExam_Load(object sender, EventArgs e)
        {
            ShowDataResult();
        }

        private void ShowDataResult()
        {
            using (var _dbContext = new QuizContextDB())
            {
                Account acc = _dbContext.Accounts.FirstOrDefault(p => p.AccountID == result.AccountID);
                Exam exam = _dbContext.Exams.FirstOrDefault(p => p.ExamID == result.ExamID);

                lblNameExam.Text = exam.ExamName;
                lblFullName.Text = acc.FullName;
                lblScore.Text = result.Scores.ToString();
                lblDateExam.Text = result.DateExam.ToString();
            }
        }
    }
}
