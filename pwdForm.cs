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
    public partial class pwdForm : Form
    {
        settingsForm sf;
        Regex userPassRegex = new Regex(@"^(.+)\:(.+)?$");
        public bool userRemoved = false;

        public pwdForm(settingsForm sform)
        {
            sf = sform;
            InitializeComponent();
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            foreach (string user in Properties.Settings.Default.rememberedUsers)
            {
                string username = userPassRegex.Matches(user)[0].Groups[1].Value;
                string password = userPassRegex.Matches(user)[0].Groups[2].Value;
                if (username == sf.removingUser)
                {
                    if (password == passTxt.Text)
                    {
                        passIndicator.BackColor = Color.Green;
                    }
                    else
                    {
                        passIndicator.BackColor = Color.Red;

                    }
                    removeUserBtn.Enabled = (password == passTxt.Text);
                    break;
                }
            }

            
        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            userRemoved = true;
            this.Close();
        }
    }
}
