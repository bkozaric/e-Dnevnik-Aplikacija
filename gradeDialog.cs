using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasySchool
{
    public partial class gradeDialog : Form
    {
        public gradeDialog()
        {
            InitializeComponent();
        }

        public string result = null;
        public bool replacegrade = false;

        private void button6_Click(object sender, EventArgs e)
        {
            if (!replacegrade)
            {
                replacegrade = true;
                mainLabel.Text = "Zamjeni s ocjenom:";      
            }
            else
            {
                replacegrade = false;
                mainLabel.Text = "Dodaj ocjenu:";
            }
        }

        private void grade1_Click(object sender, EventArgs e)
        {
            
            result = "1";
            this.Close();
        }

        private void grade2_Click(object sender, EventArgs e)
        {
            result = "2";
            this.Close();
        }

        private void grade3_Click(object sender, EventArgs e)
        {
            result = "3";
            this.Close();
        }

        private void grade4_Click(object sender, EventArgs e)
        {
            result = "4";
            this.Close();
        }

        private void grade5_Click(object sender, EventArgs e)
        {
            result = "5";
            this.Close();
        }

        private void delGrade_Click(object sender, EventArgs e)
        {
            result = "x";
            this.Close();
        }
    }
}
