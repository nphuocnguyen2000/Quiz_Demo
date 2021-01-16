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
    public partial class frmCreateExam : Form
    {
        private Account acc;
        private int examID;
        public frmCreateExam()
        {
            InitializeComponent();
        }

        public frmCreateExam(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void frmCreateExam_Load(object sender, EventArgs e)
        {
            RenderData();
        }

        private void RenderData()
        {
            ShowDgv();
            using (var _dbContext = new QuizContextDB())
            {
                List<Subject> subject = _dbContext.Subjects.Where(p => p.FacultyID == acc.Faculty1.FacultyID).ToList();
                this.cmbSubject.DataSource = subject;
                this.cmbSubject.DisplayMember = "SubjectName";
                this.cmbSubject.ValueMember = "SubjectID";

                List<Subject> subjectSearch = _dbContext.Subjects.Where(p => p.FacultyID == acc.Faculty1.FacultyID).ToList();
                this.cmbSearchSubject.DataSource = subjectSearch;
                this.cmbSearchSubject.DisplayMember = "SubjectName";
                this.cmbSearchSubject.ValueMember = "SubjectID";
            }
            txtNameTeacher.Text = acc.FullName;
            txtFacultyName.Text = acc.Faculty1.FacultyName;
            ShowDgv();
        }

        private void ShowDgv()
        {
            // clear table first show list students
            dgvAllExam.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Exam exam in _dbContext.Exams.Where(p => p.Subject.FacultyID == acc.Faculty).ToList())
                {
                    dem++;
                    viTriDong = dgvAllExam.Rows.Add();
                    dgvAllExam.Rows[viTriDong].Cells[0].Value = exam.ExamName;
                    dgvAllExam.Rows[viTriDong].Cells[1].Value = exam.ExamID;
                    dgvAllExam.Rows[viTriDong].Cells[2].Value = exam.Subject.SubjectName;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtExamName.Text == "" || txtFacultyName.Text == "" || quantityQuiz.Value == 0 || quantityTime.Value == 0)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin !");
                return;
            }
            if(txtExamID.Text != "")
            {
                this.examID = int.Parse(txtExamID.Text.ToString());
            }
            using (var _dbContext = new QuizContextDB())
            {
                Exam examFind = _dbContext.Exams.FirstOrDefault(p => p.ExamID == this.examID);
                if(examFind == null)
                {
                    Exam exam = new Exam()
                    {
                        SubjectID = cmbSubject.SelectedValue.ToString(),
                        ExamName = txtExamName.Text,
                        AccountID = acc.AccountID,
                        TimeTotal = int.Parse(quantityTime.Value.ToString()),
                        TotalQuiz = int.Parse(quantityQuiz.Value.ToString()),
                        dateCreate = DateTime.Now
                    };
                    _dbContext.Exams.Add(exam);
                    _dbContext.SaveChanges();
                    ShowDgv();
                    ShowFrmCreateQuiz(exam);
                }
                else
                {
                    MessageBox.Show("Mã kỳ thi tồn tại!");
                    return;
                }
            }
        }

        private void ShowFrmCreateQuiz(Exam exam)
        {
            Form frmChild = this.MdiChildren.OfType<frmCreateQuiz>().FirstOrDefault();

            if (frmChild == null)
            {
                frmCreateQuiz frm = new frmCreateQuiz(acc, exam);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void dgvAllExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = e.RowIndex;
            txtExamName.Text = dgvAllExam.Rows[rowSelected].Cells[0].Value.ToString();
            txtExamID.Text = dgvAllExam.Rows[rowSelected].Cells[1].Value.ToString();
            cmbSubject.Text = dgvAllExam.Rows[rowSelected].Cells[2].Value.ToString();
            int idExam = int.Parse(dgvAllExam.Rows[rowSelected].Cells[1].Value.ToString());
            using (var _dbContext = new QuizContextDB())
            {
                Exam exam = _dbContext.Exams.FirstOrDefault(p => p.ExamID == idExam);
                txtNameTeacher.Text = exam.Account.FullName;
                quantityQuiz.Value = int.Parse(exam.TotalQuiz.ToString());
                quantityTime.Value = int.Parse(exam.TimeTotal.ToString());
                txtFacultyName.Text = acc.Faculty1.FacultyName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtExamID.Text == "")
            {
                MessageBox.Show("Mã kỳ thi rỗng !!");
                return;
            }
            using( var _dbContext = new QuizContextDB())
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa kỳ thi này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int idExam = int.Parse(txtExamID.Text.ToString());
                    Exam exam = _dbContext.Exams.FirstOrDefault(p => p.ExamID == idExam);
                    foreach (Result i in _dbContext.Results.Where(p => p.ExamID == idExam).ToList())
                    {
                        _dbContext.Results.Remove(i);
                    }
                    //foreach (Quiz i in _dbContext.Quizs.Where(p => p.ExamID == idExam).ToList())
                    //{
                    //    _dbContext.Quizs.Remove(i);
                    //}
                    if (exam != null)
                    {
                        Quiz quiz = _dbContext.Quizs.FirstOrDefault(p => p.ExamID == idExam);
                        if(quiz != null)
                        {
                            Answer answer = _dbContext.Answers.FirstOrDefault(p => p.QuizID == quiz.QuizID);
                            if (answer != null)
                            {
                                _dbContext.Answers.Remove(answer);
                            }
                        }
                        _dbContext.Exams.Remove(exam); 
                        _dbContext.SaveChanges();
                        MessageBox.Show("Xóa thành công");
                        ShowDgv();
                        RestDataForm();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestDataForm();
        }

        private void RestDataForm()
        {
            txtExamID.Text = "";
            txtExamName.Text = "";
            quantityQuiz.Value = 0;
            quantityTime.Value = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtExamID.Text == "")
            {
                MessageBox.Show("Mã kỳ thi rỗng !!!");
                return;
            }
            if(txtExamName.Text == "" || txtFacultyName.Text == "" || quantityQuiz.Value == 0 || quantityTime.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ các thông tin !!!");
                return;
            }
            if(txtNameTeacher.Text != acc.FullName)
            {
                MessageBox.Show("Bạn không có quyền sửa đề thi này!");
                return;
            }
            int idExam = int.Parse(txtExamID.Text.ToString());
            using (var _dbContext = new QuizContextDB())
            {
                Exam exam = _dbContext.Exams.FirstOrDefault(p => p.ExamID == idExam);
                if (exam != null)
                {
                    exam.ExamName = txtExamName.Text;
                    exam.TotalQuiz = int.Parse(quantityQuiz.Value.ToString());
                    exam.TimeTotal = int.Parse(quantityTime.Value.ToString());
                    exam.SubjectID = cmbSubject.SelectedValue.ToString();
                    _dbContext.SaveChanges();
                }
                MessageBox.Show("Cập nhập thành công");
                ShowDgv();
            }
        }

        private void btnSearchNameExam_Click(object sender, EventArgs e)
        {
            if(txtSearchNameExam.Text == "")
            {
                ShowDgv();
                return;
            }
            // clear table first show list students
            dgvAllExam.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Exam exam in _dbContext.Exams.Where(p => p.ExamName == txtSearchNameExam.Text).ToList())
                {
                    dem++;
                    viTriDong = dgvAllExam.Rows.Add();
                    dgvAllExam.Rows[viTriDong].Cells[0].Value = exam.ExamName;
                    dgvAllExam.Rows[viTriDong].Cells[1].Value = exam.ExamID;
                    dgvAllExam.Rows[viTriDong].Cells[2].Value = exam.Subject.SubjectName;
                }
            }
        }

        private void cmbSearchSubject_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvAllExam.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Exam exam in _dbContext.Exams.Where(p => p.Subject.SubjectName == cmbSearchSubject.Text).ToList())
                {
                    dem++;
                    viTriDong = dgvAllExam.Rows.Add();
                    dgvAllExam.Rows[viTriDong].Cells[0].Value = exam.ExamName;
                    dgvAllExam.Rows[viTriDong].Cells[1].Value = exam.ExamID;
                    dgvAllExam.Rows[viTriDong].Cells[2].Value = exam.Subject.SubjectName;
                }
            }
        }

        private void txtSearchNameExam_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchNameExam.Text == "")
            {
                ShowDgv();
                return;
            }
            // clear table first show list students
            dgvAllExam.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Exam exam in _dbContext.Exams.Where(p => p.ExamName.Contains(txtSearchNameExam.Text)).ToList())
                {
                    dem++;
                    viTriDong = dgvAllExam.Rows.Add();
                    dgvAllExam.Rows[viTriDong].Cells[0].Value = exam.ExamName;
                    dgvAllExam.Rows[viTriDong].Cells[1].Value = exam.ExamID;
                    dgvAllExam.Rows[viTriDong].Cells[2].Value = exam.Subject.SubjectName;
                }
            }
        }
    }
}
