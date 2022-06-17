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
    public partial class addNewUserForm : Form
    {

        settingsForm sf;
        Regex passRegex = new Regex(@"^([^\s]+){4,}$");
        Regex userRegex = new Regex(@"^([\w.]+){4,}$");
        bool passok = false;
        public bool someoneNew = false;

        public addNewUserForm(settingsForm sform)
        {
            sf = sform;
            InitializeComponent();
        }


        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if (passok)
            {
                Properties.Settings.Default.rememberedUsers.Add(newUserTxt.Text + ":" + newPassTxt.Text);
                Properties.Settings.Default.Save();
                someoneNew = true;
            }
            else
            {
                if (string.IsNullOrEmpty(newPassTxt.Text))
                {
                    if (MessageBox.Show("Želite li dodati korisnika bez lozinke?", "Dodaj korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Properties.Settings.Default.rememberedUsers.Add(newUserTxt.Text + ":");
                        Properties.Settings.Default.Save();
                        someoneNew = true;
                    }
                }
            }
            if (someoneNew)
            {
                MessageBox.Show("Novi korisnik '" + newUserTxt.Text + "' je uspješno dodan.", "Novi korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void newPassTxt_TextChanged(object sender, EventArgs e)
        {
            if (passRegex.IsMatch(newPassTxt.Text))
            {
                passIndicator.BackColor = Color.Green;
                passok = true;
            }
            else
            {
                passIndicator.BackColor = Color.Red;
                passok = false;
            }
        }


        private void newUserTxt_TextChanged(object sender, EventArgs e)
        {
            addUserBtn.Enabled = userRegex.IsMatch(newUserTxt.Text);
        }
    }
}
