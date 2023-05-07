using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class AddExam : Form
    {
        public AddExam()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ADDExam_btn_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam
            {
                SubjectId = Convert.ToInt32(SubjectID.Text),
                Term = Convert.ToInt32(Term.Text),
                Date = Convert.ToDateTime(Date.Text)
            };
            ADD.AddExams(exam);
        }
    }
}
