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
    public partial class frmHistoryExam : Form
    {
        private Account acc;
        public frmHistoryExam()
        {
            InitializeComponent();
        }
        public frmHistoryExam(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void frmHistoryExam_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            lblFullName.Text = acc.FullName;
            dgvHistoryExam.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Result result in _dbContext.Results.Where(p => p.AccountID == acc.AccountID).ToList())
                {
                    if (result != null)
                    {
                        dem++;
                        viTriDong = dgvHistoryExam.Rows.Add();
                        dgvHistoryExam.Rows[viTriDong].Cells[0].Value = result.Exam.ExamID;
                        dgvHistoryExam.Rows[viTriDong].Cells[1].Value = result.Exam.ExamName;
                        dgvHistoryExam.Rows[viTriDong].Cells[2].Value = result.Exam.Subject.SubjectName;
                        dgvHistoryExam.Rows[viTriDong].Cells[3].Value = result.Scores;
                        dgvHistoryExam.Rows[viTriDong].Cells[4].Value = result.DateExam;
                    }
                }
            }
        }
    }
}
