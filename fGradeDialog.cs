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
    public partial class fGradeDialog : Form
    {
        public fGradeDialog()
        {
            InitializeComponent();
        }

        public string result = null;

        private void grade_Click(object sender, EventArgs e)
        {
            Button sBtn = (Button)sender;
            result = sBtn.Tag.ToString();
            this.Close();
        }
    }
}
