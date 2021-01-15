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
    public partial class frmCreateQuiz : Form
    {
        private Account acc;
        private Exam exam;
        private string titleLbl;
        private string check;
        private int demAnwer = 1;

        public frmCreateQuiz()
        {
            InitializeComponent();
        }
        public frmCreateQuiz(Account acc, Exam exam)
        {
            InitializeComponent();
            this.acc = acc;
            this.exam = exam;
        }

        private void frmCreateQuiz_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            int dem = 0;
            txtExamID.Text = exam.ExamID.ToString();
            txtExamName.Text = exam.ExamName;
            txtTeacher.Text = acc.FullName;
            lblAllQuantityQuiz.Text = "Số câu hỏi trong đề: " + exam.TotalQuiz;
            ShowDgv();
            using(var _dbContext = new QuizContextDB())
            {
                foreach(Quiz quiz in _dbContext.Quizs.ToList().Where(p => p.ExamID == exam.ExamID))
                {
                    dem++;
                    lblNumberQuiz.Text = "Câu" + dem.ToString() + ":";
                }
            }
        }

        private void ShowDgv()
        {
            dgvAllQuiz.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Quiz quiz in _dbContext.Quizs.ToList().Where(p => p.ExamID == exam.ExamID))
                {
                    dem++;
                    viTriDong = dgvAllQuiz.Rows.Add();
                    dgvAllQuiz.Rows[viTriDong].Cells[0].Value = dem.ToString();
                    dgvAllQuiz.Rows[viTriDong].Cells[1].Value = quiz.QuizName;
                }
            }
        }

        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            if (txtQuizName.Text == "" || txtQuiz1.Text == "" || txtQuiz2.Text == "" || txtQuiz3.Text == "" || txtQuiz4.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin câu hỏi!");
                return;
            }
            if(a.Checked == false && c.Checked == false && b.Checked == false && d.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn 1 đáp án đúng!");
                return;
            }
            foreach (RadioButton chk in grBoxAnswer.Controls.OfType<RadioButton>())
            {
                if (chk.Checked == true)
                {
                    this.check = chk.Name;
                }
            }

            using (var _dbContext = new QuizContextDB())
            {
                Quiz quiz = new Quiz()
                {
                    QuizName = txtQuizName.Text,
                    SubjectID = exam.SubjectID,
                    ExamID = exam.ExamID
                };
                _dbContext.Quizs.Add(quiz);
                _dbContext.SaveChanges();
                foreach (TextBox textB in grBoxAnswer.Controls.OfType<TextBox>())
                {
                    using (var _dbContext1 = new QuizContextDB())
                    {
                        this.titleLbl = "txtQuiz" + this.demAnwer.ToString();
                        Answer answer = new Answer();
                        answer.QuizID = int.Parse(quiz.QuizID.ToString());
                        answer.ContentAnswer = textB.Text;
                        //if( this.check)
                        if (demAnwer == 1 && this.check == "b")
                            answer.Correct = 1.ToString();
                        else if(demAnwer == 2 && this.check == "a")
                            answer.Correct = 1.ToString();
                        else if (demAnwer == 3 && this.check == "d")
                            answer.Correct = 1.ToString();
                        else if (demAnwer == 4 && this.check == "c")
                            answer.Correct = 1.ToString();
                        else
                            answer.Correct = 0.ToString();
                        //answer.Correct = this.check == "a" ? 1.ToString() : this.check == "b" ? 1.ToString() : this.check == "c" ? 1.ToString() : this.check == "d" ? 1.ToString() : 0.ToString();
                        _dbContext1.Answers.Add(answer);
                        _dbContext1.SaveChanges();
                    }
                    demAnwer++;
                }
                ResetForm();
                this.demAnwer = 1;
                ShowDgv();
            }
        }

        private void ResetForm()
        {
            txtQuiz1.Text = "";
            txtQuizName.Text = "";
            txtQuiz2.Text = "";
            txtQuiz3.Text = "";
            txtQuiz4.Text = "";
            a.Checked = false;
            d.Checked = false;
            b.Checked = false;
            c.Checked = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thoát ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
