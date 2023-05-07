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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void DepartmentAdd_Click(object sender, EventArgs e)
        {
            Department department = new Department
            {
                Name = DepartmentName.Text,
            };
            ADD.AddDepartment(department);
        }
    }
}
