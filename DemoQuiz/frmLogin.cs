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
    public partial class frmLogin : Form
    {
        public delegate void AccountAuthentication(Account acc);
        public event AccountAuthentication accountAuthentication;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Wrong username or password", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            using (var _dbContext = new QuizContextDB())
            {
                Account acc = _dbContext.Accounts.Where(p => p.Email == email ).FirstOrDefault();
                Account acc1 = _dbContext.Accounts.Where(p => p.Password == password).FirstOrDefault();
                if (acc == null && acc1 == null)
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                else if(acc == null && acc1 != null)
                {
                    MessageBox.Show("Không tìm thấy email này");
                }
                else if (acc != null && acc1 == null)
                {
                    MessageBox.Show("Sai mật khẩu");
                }
                else
                {
                    if (accountAuthentication != null)
                        accountAuthentication(acc);
                    this.Close();
                }

            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void optShowPass_Click(object sender, EventArgs e)
        {
            this.optShowPass.Checked = this.txtPassword.UseSystemPasswordChar;
            this.txtPassword.UseSystemPasswordChar = !this.txtPassword.UseSystemPasswordChar;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Text == "")
            {
                errorProvider1.SetError(textBox, "Không dc để trống!");
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }
    }
}
