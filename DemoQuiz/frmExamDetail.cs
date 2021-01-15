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
    public partial class frmExamDetail : Form
    {
        private int examID;
        private string nameGr, nameBnt, nameLbl, nameRadio;
      
        private Account acc;
        public frmExamDetail()
        {
            InitializeComponent();
        }
        public frmExamDetail(int examID, Account acc)
        {
            InitializeComponent();
            this.examID = examID;
            this.acc = acc;
        }

        private void frmExamDetail_Load(object sender, EventArgs e)
        {
            ShowDetailExam();
        } 
            

        private void ShowDetailExam()
        {
            using(var _dbContext = new QuizContextDB())
            {
                Exam examFind = _dbContext.Exams.FirstOrDefault(p => p.ExamID == examID);
                if(examFind != null)
                {
                    lblExamName.Text = examFind.ExamName;
                    lblSubjectName.Text = examFind.Subject.SubjectName;
                    lblDateStart.Text = DateTime.Now.ToShortDateString();
                    lblFullName.Text = acc.FullName;
                    lblStudentID.Text = acc.AccountID;
                    lblClass.Text = acc.Class1.ClassName;
                    StartCountDown(int.Parse(examFind.TimeTotal.ToString()));

                    ShowListQuiz(examFind);

                }
            }
        }

        private void ShowListQuiz(Exam examFind)
        {
            using(var _dbContext = new QuizContextDB())
            {
                int dem = 0, demAnswer = 1;
                int y = 60, x = 55;
                int grVertical = 0;
                foreach (Quiz quiz in _dbContext.Quizs.ToList().Where(p => p.ExamID == this.examID))
                {
                    dem++;
                    this.nameGr ="grbox" + quiz.QuizID.ToString();
                    this.nameBnt ="btn" + quiz.QuizID.ToString();
                    GroupBox nameGr = new GroupBox();
                    nameGr.SuspendLayout();
                    nameGr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                       
                    nameGr.Controls.Add(CreateTitleQuiz(quiz.QuizName, dem));
                    foreach (Answer answer in _dbContext.Answers.ToList().Where(p => p.QuizID == quiz.QuizID))
                    {
                        if (demAnswer == 2)
                        {
                            x += 45;
                        }
                        if(demAnswer >=3)
                        {
                            _ = x == 100 ? x = 55 : x += 45;
                            y = 550;
                        }
                        nameGr.Controls.Add(CreateAwserQuiz(answer.ContentAnswer, demAnswer, x, y));
                        demAnswer++;
                    }
                    nameGr.Location = new System.Drawing.Point(0, grVertical);
                    nameGr.Name = nameGr.ToString();
                    nameGr.Size = new System.Drawing.Size(1110, 137);
                    nameGr.TabIndex = 6;
                    nameGr.TabStop = false;
                    nameGr.ResumeLayout(false);
                    nameGr.PerformLayout();
                    grVertical += 135;
                    demAnswer = 1;
                    y = 60; 
                    x = 55;
                    this.panelAllQuiz.Controls.Add(nameGr);
                }
                lblTotalDone.Text = dem.ToString();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            List<GroupBox> listGrBox = new List<GroupBox>();
            foreach (GroupBox grBox in this.panelAllQuiz.Controls.OfType<GroupBox>())
            {
                listGrBox.Add(grBox) ;
            }
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thoát khỏi kỳ thi !", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private RadioButton CreateAwserQuiz(string content, int dem, int x, int y)
        {
            this.nameRadio = "radio" + dem.ToString();
            RadioButton nameRadio = new RadioButton();
            nameRadio.AllowDrop = true;
            nameRadio.AutoSize = true;
            nameRadio.Location = new System.Drawing.Point(y, x);
            nameRadio.Name = nameRadio.ToString();
            nameRadio.Size = new System.Drawing.Size(350, 21);
            nameRadio.TabIndex = 5;
            nameRadio.TabStop = true;
            nameRadio.Text = content;
            nameRadio.UseVisualStyleBackColor = true;
            return nameRadio;
        }

        private Label CreateTitleQuiz(string quizName, int dem)
        {
            this.nameLbl = "lbl" + dem.ToString();
            Label nameLbl = new Label();
            nameLbl.AutoSize = true;
            nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nameLbl.Location = new System.Drawing.Point(31, 18);
            nameLbl.Name = nameLbl.ToString();
            nameLbl.Size = new System.Drawing.Size(469, 18);
            nameLbl.TabIndex = 0;
            nameLbl.Text = string.Format("Câu {0}. {1}", dem.ToString(), quizName);
            return nameLbl;
        }

        private void StartCountDown(int minutes)
        {
            CountDownTimer timer = new CountDownTimer();
            timer.SetTime(Convert.ToInt32(minutes), 0);
            timer.Start();
            timer.TimeChanged += () => lblCountDown.Text = timer.TimeLeftMsStr;
            timer.CountDownFinished += () => lblCountDown.Text = "Finish!";
            timer.StepMs = 77;
        }
    }
}
