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
    public partial class AddMark : Form
    {
        public AddMark()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMark_Load(object sender, EventArgs e)
        {

        }

        private void AddExam_btn_Click(object sender, EventArgs e)
        {
            StudentMark studentMark = new StudentMark 
            {
                StudentId = Convert.ToInt32(IDStudent.Text),
                ExamId = Convert.ToInt32(IDExam.Text),
                Mark = Convert.ToInt32(Mark.Text)
            };
            ADD.AddStudentMark(studentMark);
        }
    }
}
