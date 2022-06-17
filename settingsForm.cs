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
    public partial class settingsForm : Form
    {
        mainForm mf;
        addNewUserForm anuf;
        pwdForm pf;
        editPassForm epf;

        Regex onlyNumRegex = new Regex(@"^\d{1,3}$");

        public string removingUser;
        public string editingUser;

        public settingsForm(mainForm mainform)
        {
            mf = mainform;
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            foreach (string user in Properties.Settings.Default.rememberedUsers)
            {
                ListViewItem newUser = new ListViewItem();
                string username = mf.userPassRegex.Matches(user)[0].Groups[1].Value;
                string passwd = mf.userPassRegex.Matches(user)[0].Groups[2].Value;
                if (!string.IsNullOrWhiteSpace(username))
                {
                    newUser.Text = username;
                    if (!string.IsNullOrWhiteSpace(passwd))
                    {
                        newUser.SubItems.Add("Da");
                    }
                    else
                    {
                        newUser.SubItems.Add("Ne");
                    }
                    userListView.Items.Add(newUser);
                }
            }
            if (userListView.Items.Count < 1)
            {
                removeUserBtn.Enabled = false;
                editUserBtn.Enabled = false;
            }
            autoPickClassCheckBox.Checked = Properties.Settings.Default.autoPickClass;
            showSplashCheckBox.Checked = Properties.Settings.Default.showSplash;
            gradeRangeTxt.Text = Properties.Settings.Default.gradeRange.ToString();
            testRangeTxt.Text = Properties.Settings.Default.testRange.ToString();

        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            if (userListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Niste odabrali niti jednog korisnika.", "Odaberite korisnika", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                removingUser = userListView.SelectedItems[0].Text;
                pf = new pwdForm(this);
                pf.ShowDialog();
                if (pf.userRemoved)
                {
                    foreach (string user in Properties.Settings.Default.rememberedUsers)
                    {
                        string username = mf.userPassRegex.Matches(user)[0].Groups[1].Value;
                        if (username == userListView.SelectedItems[0].Text)
                        {
                            if (mf.userNameTxt.Text == username)
                            {
                                mf.userNameTxt.Clear();
                                mf.passwordTxt.Clear();
                                mf.rememberPassCheckBox.Checked = false;
                            }
                            Properties.Settings.Default.rememberedUsers.Remove(user);
                            Properties.Settings.Default.Save();
                            mf.refreshUserAutocomplete();
                            break;
                        }
                    }
                    MessageBox.Show("Korisnik '" + userListView.SelectedItems[0].Text + "' je uspješno obrisan.", "Korisnik obrisan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    removingUser = null;
                    userListView.Items.Remove(userListView.SelectedItems[0]);
                }
            }
            if (userListView.Items.Count < 1)
            {
                removeUserBtn.Enabled = false;
                editUserBtn.Enabled = false;
            }

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            anuf = new addNewUserForm(this);
            anuf.ShowDialog();
            if (anuf.someoneNew)
            {
                userListView.Items.Clear();
                settingsForm_Load(this, null);
                mf.refreshUserAutocomplete();
            }
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            if (userListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Niste odabrali niti jednog korisnika.", "Odaberite korisnika", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                editingUser = userListView.SelectedItems[0].Text;
                epf = new editPassForm(this);
                epf.ShowDialog();
                if (epf.passChanged)
                {
                    if (editingUser == mf.userNameTxt.Text)
                    {
                        mf.userNameTxt.Clear();
                        mf.userNameTxt.Text = editingUser;
                    }
                    MessageBox.Show("Uspješno ste promjenili lozinku za korisnika: '" + editingUser + "'", "Lozinka promjenjena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editingUser = null;
                    userListView.Items.Clear();
                    settingsForm_Load(this, null);
                    mf.refreshUserAutocomplete();
                }
            }
        }

        private void autoPickClassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoPickClass = autoPickClassCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void showSplashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            splashScreenMs.Enabled = showSplashCheckBox.Checked;
            Properties.Settings.Default.showSplash = showSplashCheckBox.Checked;
            Properties.Settings.Default.splashms = Convert.ToInt32(splashScreenMs.Value);
            Properties.Settings.Default.Save();
        }

        private void gradeRangeTxt_TextChanged(object sender, EventArgs e)
        {
            applyGBtn.Enabled = onlyNumRegex.IsMatch(gradeRangeTxt.Text);
        }

        private void testRangeTxt_TextChanged(object sender, EventArgs e)
        {
            applyTBtn.Enabled = onlyNumRegex.IsMatch(testRangeTxt.Text);
        }

        private void applyGBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.gradeRange = Convert.ToInt32(gradeRangeTxt.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("Upsješno si promjenio opseg traženja nedavnih ocjena.", "Opseg traženja promjenjen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void applyTBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.testRange = Convert.ToInt32(testRangeTxt.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("Upsješno si promjenio opseg traženja nadolazećih ispita.", "Opseg traženja promjenjen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void splashScreenMs_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.splashms = Convert.ToInt32(splashScreenMs.Value);
            Properties.Settings.Default.Save();
        }
    }
}
