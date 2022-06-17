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
    public partial class editPassForm : Form
    {

        settingsForm sf;
        Regex passRegex = new Regex(@"^([^\s]+){4,}$");
        Regex userPassRegex = new Regex(@"^(.+)\:(.+)?$");

        bool passok = false;
        public bool passChanged = false;

        public editPassForm(settingsForm sform)
        {
            sf = sform;
            InitializeComponent();
        }

        private void oldPassTxt_TextChanged(object sender, EventArgs e)
        {
            foreach (string user in Properties.Settings.Default.rememberedUsers)
            {
                string username = userPassRegex.Matches(user)[0].Groups[1].Value;
                string password = userPassRegex.Matches(user)[0].Groups[2].Value;
                if (username == sf.editingUser)
                {
                    if (password == oldPassTxt.Text)
                    {
                        oldPassIndicator.BackColor = Color.Green;
                        newPassTxt.Enabled = true;
                        newPassTxt.Focus();
                    }
                    else
                    {
                        oldPassIndicator.BackColor = Color.Red;

                    }
                    editPass.Enabled = (password == oldPassTxt.Text);
                    break;
                }
            }
        }

        private void newPassTxt_TextChanged(object sender, EventArgs e)
        {
            passok = passRegex.IsMatch(newPassTxt.Text);
            if (passok)
            {
                if (oldPassIndicator.BackColor == Color.Green && oldPassTxt.Text == newPassTxt.Text)
                {
                    newPassIndicator.BackColor = Color.Red;
                    passok = false;
                }
                else
                {
                    newPassIndicator.BackColor = Color.Green;
                }
            }
            else
            {
                newPassIndicator.BackColor = Color.Red;
            }
        }

        private void editPass_Click(object sender, EventArgs e)
        {

            foreach (string user in Properties.Settings.Default.rememberedUsers)
            {
                string username = userPassRegex.Matches(user)[0].Groups[1].Value;
                if (username == sf.editingUser)
                {
                    Properties.Settings.Default.rememberedUsers.Remove(user);
                    if (passok)
                    {
                        Properties.Settings.Default.rememberedUsers.Add(sf.editingUser + ":" + newPassTxt.Text);
                    }
                    else
                    {
                        Properties.Settings.Default.rememberedUsers.Add(sf.editingUser + ":");
                    }
                    Properties.Settings.Default.Save();
                    passChanged = true;
                    break;
                }
            }
            this.Close();
        }
    }
}
