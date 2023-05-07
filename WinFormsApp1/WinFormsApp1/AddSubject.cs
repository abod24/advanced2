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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void ADDSbject_btn_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject
            {
                DepartmentId = Convert.ToInt32(Department.Text),
                Name = Name.Text,
                MinimumDgree = Convert.ToInt32(MinimumDegree.Text),
                Term = Convert.ToInt32(Term.Text),
                Year = Convert.ToInt32(Year.Text),
            };
            ADD.AddSubject(subject);
        }
    }
}
