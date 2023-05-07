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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Username = UserName.Text,
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                Email = Email.Text,
                Phone = Phone.Text,
                RegisterDate = Convert.ToInt32(RegesterData.Text),
                DepartmentId = Convert.ToInt32(Department.Text)
            };
            ADD.AddStudent(student);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
