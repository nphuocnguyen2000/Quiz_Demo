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
    }
}
