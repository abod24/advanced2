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
    public partial class AddLectur : Form
    {
        public AddLectur()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADDLectur_btn_Click(object sender, EventArgs e)
        {
            SubjectLectur subjectLectur = new SubjectLectur
            {
                SubjectId = Convert.ToInt32(IDSubject.Text),
                Title = Title.Text,
                Content = content.Text
            };
            ADD.AddSubjectLectur(subjectLectur);
        }
    }
}
