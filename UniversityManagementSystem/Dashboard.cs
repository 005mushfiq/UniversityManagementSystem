using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            CrudStudent scrud = new CrudStudent();
            scrud.Show();
            this.Hide();

        }

        private void TeacherBtn_Click(object sender, EventArgs e)
        {
            CrudTeacher tcrud = new CrudTeacher();
            tcrud.Show();
            this.Hide();


        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            CrudUser ucrud = new CrudUser();
            ucrud.Show();
            this.Hide();


        }

        private void LibraryBtn_Click(object sender, EventArgs e)
        {
            CrudLibrary lcrud = new CrudLibrary();
            lcrud.Show();
            this.Hide();

        }
    }
}
