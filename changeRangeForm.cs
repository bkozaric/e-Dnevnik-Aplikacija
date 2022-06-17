using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasySchool
{
    public partial class changeRangeForm : Form
    {

        statsForm sf;
        public string result = null;
        Regex numRegex = new Regex(@"^\d{1,3}$");

        public changeRangeForm(statsForm sform)
        {
            sf = sform;
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            result = newRangeTxt.Text;
            this.Close();
        }

        private void newRangeTxt_TextChanged(object sender, EventArgs e)
        {
            searchBtn.Enabled = (numRegex.IsMatch(newRangeTxt.Text));
        }

        private void newRangeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (searchBtn.Enabled)
                {
                    searchBtn.PerformClick();
                }
            }
        }
    }
}
