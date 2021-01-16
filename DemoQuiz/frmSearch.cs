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
    public partial class frmSearch : Form
    {
        private Account acc;
        public frmSearch()
        {
            InitializeComponent();
        }
        public frmSearch(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if( txtExamName.Text  == "")
            {
                ShowAllExam();
                return;
            }
            // clear table first show list students
            SearchForName();
            
        }

        private void SearchForName()
        {
            dgvSearchResult.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Exam exam in _dbContext.Exams.Where(p => p.ExamName.Contains(txtExamName.Text)).ToList())
                {
                    dem++;
                    viTriDong = dgvSearchResult.Rows.Add();
                    dgvSearchResult.Rows[viTriDong].Cells[0].Value = exam.ExamID;
                    dgvSearchResult.Rows[viTriDong].Cells[1].Value = exam.ExamName;
                    dgvSearchResult.Rows[viTriDong].Cells[2].Value = exam.Account.Faculty1.FacultyName;
                    dgvSearchResult.Rows[viTriDong].Cells[3].Value = exam.Account.Class1.ClassName;
                    dgvSearchResult.Rows[viTriDong].Cells[4].Value = exam.Account.FullName;
                    dgvSearchResult.Rows[viTriDong].Cells[5].Value = exam.Subject.SubjectName;
                    dgvSearchResult.Rows[viTriDong].Cells[6].Value = exam.dateCreate;
                }
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            ShowDataCmb();
            ShowAllExam();
        }

        private void ShowDataCmb()
        {
            QuizContextDB context = new QuizContextDB();
            List<Faculty> listFaculty = context.Faculties.ToList();
            cmbFacultyName.DataSource = listFaculty;
            cmbFacultyName.DisplayMember = "FacultyName";
            cmbFacultyName.ValueMember = "FacultyName";
        }

        private void ShowAllExam()
        {
            // clear table first show list students
            dgvSearchResult.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                foreach (Exam exam in _dbContext.Exams.ToList())
                {
                    dem++;
                    viTriDong = dgvSearchResult.Rows.Add();
                    dgvSearchResult.Rows[viTriDong].Cells[0].Value = exam.ExamID;
                    dgvSearchResult.Rows[viTriDong].Cells[1].Value = exam.ExamName;
                    dgvSearchResult.Rows[viTriDong].Cells[2].Value = exam.Account.Faculty1.FacultyName;
                    dgvSearchResult.Rows[viTriDong].Cells[3].Value = exam.Account.Class1.ClassName;
                    dgvSearchResult.Rows[viTriDong].Cells[4].Value = exam.Account.FullName;
                    dgvSearchResult.Rows[viTriDong].Cells[5].Value = exam.Subject.SubjectName;
                    dgvSearchResult.Rows[viTriDong].Cells[6].Value = exam.dateCreate;
                }
            }
        }

        private void txtExamName_TextChanged(object sender, EventArgs e)
        {
            if (txtExamName.Text == "")
            {
                ShowAllExam();
                return;
            }
            // clear table first show list students
            SearchForName();
        }

        private void cmbFacultyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSearchResult.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                Faculty faculty = _dbContext.Faculties.FirstOrDefault(p => p.FacultyName == cmbFacultyName.Text);
                if(faculty != null)
                {
                    foreach (Exam exam in _dbContext.Exams.Where(p => p.Subject.FacultyID == faculty.FacultyID).ToList())
                    {
                        dem++;
                        viTriDong = dgvSearchResult.Rows.Add();
                        dgvSearchResult.Rows[viTriDong].Cells[0].Value = exam.ExamID;
                        dgvSearchResult.Rows[viTriDong].Cells[1].Value = exam.ExamName;
                        dgvSearchResult.Rows[viTriDong].Cells[2].Value = exam.Account.Faculty1.FacultyName;
                        dgvSearchResult.Rows[viTriDong].Cells[3].Value = exam.Account.Class1.ClassName;
                        dgvSearchResult.Rows[viTriDong].Cells[4].Value = exam.Account.FullName;
                        dgvSearchResult.Rows[viTriDong].Cells[5].Value = exam.Subject.SubjectName;
                        dgvSearchResult.Rows[viTriDong].Cells[6].Value = exam.dateCreate;
                    }
                }
            }
            ShowCmbSearchSubject(cmbFacultyName.Text);
        }

        private void ShowCmbSearchSubject(string nameFaculty)
        {
            QuizContextDB context = new QuizContextDB();
            List<Subject> listSubject = context.Subjects.Where(p => p.Faculty.FacultyName == nameFaculty).ToList();
            cmbSubjectSearch.DataSource = listSubject;
            cmbSubjectSearch.DisplayMember = "SubjectName";
            cmbSubjectSearch.ValueMember = "SubjectName";
        }

        private void cmbSubjectSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSearchResult.Rows.Clear();
            int viTriDong, dem = 0;
            using (var _dbContext = new QuizContextDB())
            {
                Subject subject = _dbContext.Subjects.FirstOrDefault(p => p.SubjectName == cmbSubjectSearch.Text);
                if (subject != null)
                {
                    foreach (Exam exam in _dbContext.Exams.Where(p => p.SubjectID == subject.SubjectID).ToList())
                    {
                        dem++;
                        viTriDong = dgvSearchResult.Rows.Add();
                        dgvSearchResult.Rows[viTriDong].Cells[0].Value = exam.ExamID;
                        dgvSearchResult.Rows[viTriDong].Cells[1].Value = exam.ExamName;
                        dgvSearchResult.Rows[viTriDong].Cells[2].Value = exam.Account.Faculty1.FacultyName;
                        dgvSearchResult.Rows[viTriDong].Cells[3].Value = exam.Account.Class1.ClassName;
                        dgvSearchResult.Rows[viTriDong].Cells[4].Value = exam.Account.FullName;
                        dgvSearchResult.Rows[viTriDong].Cells[5].Value = exam.Subject.SubjectName;
                        dgvSearchResult.Rows[viTriDong].Cells[6].Value = exam.dateCreate;
                    }
                }
            }
        }
    }
}
