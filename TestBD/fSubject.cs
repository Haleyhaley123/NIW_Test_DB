using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBD
{
    public partial class fSubject : Form
    {
        public fSubject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowSubject_Click(object sender, EventArgs e)
        {
            fStudent fs = new fStudent();
            this.Hide();
            fs.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            fStudent fc = new fStudent();
            this.Hide();
            fc.ShowDialog();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            fScore fc = new fScore();
            this.Hide();
            fc.ShowDialog();
        }
    }
}
