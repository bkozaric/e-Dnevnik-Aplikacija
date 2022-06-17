using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasySchool
{
    public partial class mainForm : Form
    {

        //DEFAULT HEIGHTS:
        //LOGIN PANEL : 72
        //SETTINGS PANEL : 89

        public WebBrowser mainwb;
        public WebBrowser utWb;
        public WebBrowser missingWb;
        WebBrowser curVisible;

        gradeDialog gd;
        statsForm stats;
        pickClass pClass;
        settingsForm sf;
        printForm pf;


        public Regex usernameRegex = new Regex(@"^[\w.]+$");
        public Regex userPassRegex = new Regex(@"^(.+)\:(.+)?$"); //GROUP[1] = user, GROUP[2] = pass
        bool notesHiden = false;

        public mainForm()
        {
            InitializeComponent();
            changePanelHeight(true);
            mainwb = new WebBrowser();
            utWb = new WebBrowser();
            missingWb = new WebBrowser();
            mainwb.ScriptErrorsSuppressed = true;
            mainwb.Navigate("ocjene.skole.hr");
            mainwb.DocumentCompleted += mainwb_DocumentCompleted;

            utWb.ScriptErrorsSuppressed = true;
            missingWb.ScriptErrorsSuppressed = true;

            if (Properties.Settings.Default.showSplash)
            {
                splashScreen splash = new splashScreen();
                splash.ShowDialog();
            }

            // JUST IN CASE I NEED IT
            //mainwb.Dock = DockStyle.Fill;
            //mainContainerPanel.Controls.Add(mainwb);
        }



        /************************
        ********FUNCTIONS********
        ************************/
        #region Functions

        void changePanelHeight(bool loginVisible = true, bool hideSettings = false)
        {
            if (loginVisible)
            {
                loginPanel.Height = 100;
                settingsContainerPanel.Height = 0;
            }
            else
            {
                if (!hideSettings)
                {
                    settingsContainerPanel.Height = 89;
                }
                loginPanel.Height = 0;
            }
        }

        void logout()
        {
            logoutTimer.Stop();
            statsBtn.Enabled = false;
            printBtn.Enabled = false;
            wbOptionsPanel.Width = 0;
            subjectContainerPanel.Controls.Clear();
            mainContainerPanel.Controls.Clear();
            resetStudentInfoLabels();
        }

        void resetStudentInfoLabels()
        {
            foreach (Control lbl in studentInfoPanel.Controls)
            {
                if(lbl is Label)
                {
                    lbl.Text = lbl.Tag.ToString();
                }
            }
            genderPb.Visible = false;
        }

        void manageRemembered()
        {
            bool pwdRem = false;
            bool usrRem = false;
            bool cbCheck = rememberPassCheckBox.Checked;

            string oldPwd = null;

            foreach (string user in Properties.Settings.Default.rememberedUsers)
            {
                if (user.Contains(userNameTxt.Text))
                {
                    usrRem = true;
                    if (user.Contains(passwordTxt.Text))
                    {
                        pwdRem = true;
                        oldPwd = userPassRegex.Matches(user)[0].Groups[2].Value;
                    }
                }
            }

            if (cbCheck) // pamti lozinku
            {
                showPassPb.Visible = false;
                if (usrRem && !pwdRem)
                {
                    // user vec postoji, sada dodaj lozinku
                    foreach (string user in Properties.Settings.Default.rememberedUsers)
                    {
                        if (user.Contains(userNameTxt.Text))
                        {
                            Properties.Settings.Default.rememberedUsers.Remove(user);
                            Properties.Settings.Default.rememberedUsers.Add(userNameTxt.Text + ":" + passwordTxt.Text);
                            Properties.Settings.Default.Save();
                            break;
                        }
                    }
                }
                else if (!usrRem && !pwdRem)
                {
                    // ne postoji ni user ni lozinka, dodaj lozinku i user
                    Properties.Settings.Default.rememberedUsers.Add(userNameTxt.Text + ":" + passwordTxt.Text);
                    Properties.Settings.Default.Save();
                }
                else if(usrRem && pwdRem)
                {
                    // postoje i lozinka i user, ne treba nista mjenjat, osim ako se lozinka nije promjenila?
                    if (passwordTxt.Text != oldPwd)
                    {
                        foreach (string user in Properties.Settings.Default.rememberedUsers)
                        {
                            if (user.Contains(userNameTxt.Text))
                            {
                                Properties.Settings.Default.rememberedUsers.Remove(user);
                                Properties.Settings.Default.rememberedUsers.Add(userNameTxt.Text + ":" + passwordTxt.Text);
                                Properties.Settings.Default.Save();
                                break;
                            }
                        }
                    }
                }
            }
            else // nemoj pamtit lozinku
            {
                if (usrRem && pwdRem)
                {
                    // postoje i lozinka i user, brisi lozinku
                    foreach (string user in Properties.Settings.Default.rememberedUsers)
                    {
                        if(user.Contains(userNameTxt.Text))
                        {
                            Properties.Settings.Default.rememberedUsers.Remove(user);
                            Properties.Settings.Default.rememberedUsers.Add(userNameTxt.Text + ":");
                            Properties.Settings.Default.Save();
                            break;
                        }
                    }
                }
                else if(!usrRem && !pwdRem)
                {
                    // uopce ne postoji user, dodaj user, ALI NE lozinku
                    Properties.Settings.Default.rememberedUsers.Add(userNameTxt.Text + ":");
                    Properties.Settings.Default.Save();
                }
            }
            refreshUserAutocomplete();
            if (!cbCheck)
            {
                passwordTxt.Clear();
            }
        }

        public void refreshUserAutocomplete()
        {
            userNameTxt.AutoCompleteCustomSource.Clear();
            foreach (string user in Properties.Settings.Default.rememberedUsers)
            {
                string userName = userPassRegex.Matches(user)[0].Groups[1].Value;
                if (!string.IsNullOrWhiteSpace(userName))
                {
                    userNameTxt.AutoCompleteCustomSource.Add(userName);
                }
            }
        }
        #endregion
        /************************
        ********FUNCTIONS********
        ************************/


        /************************
        ***DOC HOVER & R.CLICK***
        ************************/
        #region Document Hover and Right Click
        string result = "";
        bool rgrade;
        HtmlElement clickedelement;
        private void wb_MouseDown(object sender, HtmlElementEventArgs e)
        {
            if (e.MouseButtonsPressed == MouseButtons.Right)
            {
                Point pos = curVisible.PointToClient(MousePosition);
                clickedelement = curVisible.Document.GetElementFromPoint(pos); 
                if (clickedelement == last_hover)
                {
                    last_hover = null;
                    if (lhStyle != null)
                    {
                        clickedelement.Style = lhStyle;

                    }
                    lhStyle = null;
                    gd = new gradeDialog();
                    gd.ShowDialog();
                    result = gd.result;
                    rgrade = gd.replacegrade;

                    // RED --- #FFB3B3
                    // GREEN --- #B3FFB3
                    // BLUE --- #B3D9FF
                    // HOVER --- #F4F5FF


                    if (result != null && result != "")
                    {
                        if (result == "x")
                        {
                            if (!string.IsNullOrEmpty(clickedelement.InnerText))
                            {
                                clickedelement.Style = "background-color:#FFB3B3;"; //RED
                            }
                            clickedelement.InnerText = "";
                        }
                        else
                        {
                            if (rgrade)
                            {
                                if (string.IsNullOrEmpty(clickedelement.InnerText)) // if cell empty
                                {
                                    if (clickedelement.Style.Contains("ffb3b3")) // if red
                                    {
                                        clickedelement.Style = "background-color:#B3FFB3;"; // then green
                                    }
                                    else
                                    {
                                        clickedelement.Style = "background-color:#B3D9FF;"; // else blue
                                    }
                                }
                                else
                                {
                                    clickedelement.Style = "background-color:#B3FFB3;"; // else green
                                }
                                if (result == "1")
                                {
                                    clickedelement.Style += "; color:red; font-weight: bold;"; // if negative grade, text color is red
                                }
                                clickedelement.InnerText = result;

                            }
                            else
                            {
                                if (clickedelement.InnerText == null)
                                {
                                    clickedelement.InnerText = result;
                                }
                                else
                                {
                                    clickedelement.InnerText += ", " + result;
                                }
                                if (clickedelement.Style.Contains("#ffb3b3")) // if cell is red
                                {
                                    clickedelement.Style = "background-color:#B3FFB3;"; // then cell = green
                                }
                                else
                                {
                                    clickedelement.Style = "background-color:#B3D9FF;"; // else cell is blue
                                }
                                if (result == "1" || clickedelement.InnerText.Contains("1")) // if negativne grade
                                {
                                    clickedelement.Style += "; color:red; font-weight: bold;"; // text color is red
                                }

                            }
                        }
                    }
                    if (clickedelement.Style.Contains("#f4f5ff")) // if hover
                    {
                        clickedelement.Style = null; // style = none
                    }
                    string curavg = "";
                    string newavg = "";
                    decimal noviprosjek;
                    HtmlElementCollection wholesubjectarray = clickedelement.Parent.Parent.Parent.Parent.All;
                    List<string> wholesubject = new List<string>();
                    List<string> subjectgrades = new List<string>();
                    string curgrade = "";
                    int sumaocjena = 0;

                    foreach (HtmlElement elem in wholesubjectarray)
                    {
                        if (elem.GetAttribute("className") == "t-center")
                        {
                            if (!string.IsNullOrEmpty(elem.InnerText))
                            {
                                wholesubject.Add(elem.InnerText);
                            }
                        }
                        else if (elem.GetAttribute("className") == "average")
                        {
                            curavg = elem.InnerText.Substring(elem.InnerText.IndexOf(":") + 2, 4);
                            break;
                        }
                    }

                    foreach (string item in wholesubject)
                    {
                        curgrade = item;
                        foreach (char g in curgrade)
                        {
                            if (Convert.ToString(g) != "," && Convert.ToString(g) != " ")
                            {
                                subjectgrades.Add(Convert.ToString(g));
                            }
                        }
                    }
                    foreach (string g in subjectgrades)
                    {
                        sumaocjena += Convert.ToInt32(g);
                    }
                    if (sumaocjena > 0)
                    {
                        noviprosjek = Decimal.Round((decimal)sumaocjena / subjectgrades.Count, 2, MidpointRounding.AwayFromZero);
                        newavg = String.Format("{0:0.##}", noviprosjek);
                        if (newavg.Length == 3)
                        {
                            newavg += "0";
                        }
                        else if (newavg.Length == 1)
                        {
                            newavg += ",00";
                        }
                        clickedelement.Parent.Parent.Parent.Parent.OuterHtml = clickedelement.Parent.Parent.Parent.Parent.OuterHtml.Replace("Prosjek ocjena: " + curavg, "Prosjek ocjena: " + newavg);
                    }
                    else
                    {
                        clickedelement.Parent.Parent.Parent.Parent.OuterHtml = clickedelement.Parent.Parent.Parent.Parent.OuterHtml.Replace("Prosjek ocjena: " + curavg, "Prosjek ocjena: 0,00");

                    }
                }
            }
        }


        HtmlElement last_hover = null;
        string lhStyle = null;
        private void wb_MouseOver(object sender, HtmlElementEventArgs e)
        {
            if (last_hover != null)
            {
                if (string.IsNullOrEmpty(lhStyle))
                {
                    last_hover.Style = "";
                }
                else
                {
                    last_hover.Style = lhStyle;
                    lhStyle = null;
                }
                last_hover = null;
            }
            try
            {
                if (e.ToElement.GetAttribute("className") == "t-center")
                {
                    if (e.ToElement.Style != null)
                    {
                        lhStyle = e.ToElement.Style;
                    }
                    e.ToElement.Style = "background-color:#f4f5ff;";
                    last_hover = e.ToElement;
                }
            }
            catch
            {
                //html length error
            }
        }
#endregion
        /************************
        ***DOC HOVER & R.CLICK***
        ************************/


        void mainwb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri.Contains("ocjene.skole.hr/pocetna/prijava"))
            {
                changePanelHeight();
                loginBtn.Enabled = true;
            }
            else if (e.Url.AbsoluteUri.Contains("ocjene.skole.hr/razredi/odabir"))
            {
                logoutTimer.Start();
                if (Properties.Settings.Default.autoPickClass)
                {
                    foreach (HtmlElement elem in mainwb.Document.GetElementById("classes").All)
                    {
                        if (elem.GetAttribute("className") == "class-wrap")
                        {
                            elem.InvokeMember("click");
                            break;
                        }
                    }
                }
                else
                {
                    pClass = new pickClass(this);
                    pClass.ShowDialog();
                }
            }
            else if (e.Url.AbsoluteUri.Contains("ocjene.skole.hr/pregled/predmeti/"))
            {
                //navigate utWb and missingWb
                utWb.Navigate(e.Url.AbsoluteUri.Replace("predmeti", "ispiti"));
                missingWb.Navigate(e.Url.AbsoluteUri.Replace("predmeti", "izostanci"));

                //Remember pass, user etc.
                manageRemembered();

                //Collecting subjects, creating button list, navigating each webbrowser to a subject
                changePanelHeight(false);
                var subjectCollection = mainwb.Document.GetElementById("courses").GetElementsByTagName("a");
                int counter = 1;
                foreach (HtmlElement elem in subjectCollection)
                {
                    if (!elem.InnerHtml.Contains("Nove ocjene"))
                    {
                        Button subjectBtn = new Button();
                        subjectBtn.Text = elem.InnerText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
                        if (counter % 2 == 0)
                        {
                            subjectBtn.BackColor = loginBtn.BackColor;
                        }
                        else
                        {
                            subjectBtn.BackColor = SystemColors.GradientInactiveCaption;
                        }
                        counter++;

                        subjectBtn.FlatStyle = FlatStyle.Popup;
                        subjectBtn.Font = loginBtn.Font;
                        subjectBtn.Click += subjectBtn_Click;
                        subjectBtn.Dock = DockStyle.Top;
                        subjectBtn.Height = 35;
                        subjectBtn.Enabled = false;
                        subjectBtn.Tag = elem.GetAttribute("name");

                        subjectContainerPanel.Controls.Add(subjectBtn);
                        subjectBtn.BringToFront();

                        WebBrowser wb = new WebBrowser();
                        wb.ScriptErrorsSuppressed = true;
                        wb.Dock = DockStyle.Fill;
                        wb.Visible = false;
                        wb.Tag = elem.GetAttribute("name");
                        wb.IsWebBrowserContextMenuEnabled = false;
                        wb.Navigate(elem.GetAttribute("href"));
                        wb.DocumentCompleted += wb_DocumentCompleted;

                        mainContainerPanel.Controls.Add(wb);
                    }
                }
                if ((counter - 1) % 2 == 0)
                {
                    foreach (Button btn in settingsContainerPanel.Controls)
                    {
                        btn.BackColor = SystemColors.GradientActiveCaption;
                    }
                    subjectContainerPanel.BackColor = SystemColors.GradientInactiveCaption;
                }
                else
                {
                    foreach (Button btn in settingsContainerPanel.Controls)
                    {
                        btn.BackColor = SystemColors.GradientInactiveCaption;
                    }
                    subjectContainerPanel.BackColor = SystemColors.GradientActiveCaption;
                }


                //Filling out student info panel
                var studentInfoArray = mainwb.Document.GetElementById("student-class").InnerHtml.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                Regex studentNameRegex = new Regex(@"<B>(.+)<\/B>");
                Regex studentInfoRegex = new Regex(@".+>(.+)<\/DIV>");
                studentNameLabel.Text = studentNameRegex.Matches(studentInfoArray[1])[0].Groups[1].Value;
                classLabel.Text = studentInfoRegex.Matches(studentInfoArray[6])[0].Groups[1].Value;
                schoolNameLabel.Text = studentInfoRegex.Matches(studentInfoArray[4])[0].Groups[1].Value;
                teacherNameLabel.Text = studentInfoRegex.Matches(studentInfoArray[5])[0].Groups[1].Value;
                schoolYearLabel.Text = studentInfoRegex.Matches(studentInfoArray[3])[0].Groups[1].Value;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://gender-api.com/get?name=" + studentNameLabel.Text.Split(' ')[0].ToLower() + "&key=bXXAEABCkzvJSdhpEH");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                System.IO.StreamReader streamReader = new System.IO.StreamReader(responseStream);

                Regex genderRegex = new Regex("gender\":\"([A-z]{1,10})\"");

                //{"name":"nekoIme","gender":"male","samples":123,"accuracy":123,"duration":"123ms"}

                string gender = genderRegex.Match(streamReader.ReadToEnd()).Groups[1].Value;
                if(gender == "male")
                {
                    genderPb.BackgroundImage = Properties.Resources.user_male;
                    genderPb.Visible = true;
                }
                else if (gender == "female")
                {
                    genderPb.BackgroundImage = Properties.Resources.female_user;
                    genderPb.Visible = true;
                }
                



            }
            else if (e.Url.AbsoluteUri.Contains("ocjene.skole.hr/pocetna/posalji/"))
            {
                MessageBox.Show("Unjeli ste pogrešnu lozinku i/ili korisničko ime.", "Došlo je do greške", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changePanelHeight();
                loginBtn.Enabled = true;
            }
        }

        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri.Contains("ocjene.skole.hr/pocetna/prijava")) // LOGOUT CLICKED
            {
                mainwb.Navigate(e.Url);
                logout();
                changePanelHeight();
                subjectContainerPanel.Controls.Clear();
                mainContainerPanel.Controls.Clear();
            }
            else if (e.Url.AbsoluteUri.Contains("ocjene.skole.hr/pregled/predmet")) // REMOVE ALL UNNECESSARY STUFF
            {
                bool containsDisabled = false;
                WebBrowser wb = (WebBrowser)sender;
                foreach(Button sBtn in subjectContainerPanel.Controls)
                {
                    if(sBtn.Tag.ToString() == wb.Tag.ToString())
                    {
                        sBtn.Enabled = true;
                    }
                    if (!sBtn.Enabled)
                    {
                        containsDisabled = true;
                    }
                }
                if (!containsDisabled)
                {
                    statsBtn.Enabled = true;
                    printBtn.Enabled = true;
                }
                wb.Document.Body.Style = "overflow:hidden";
                wb.Document.Body.MouseDown += new HtmlElementEventHandler(wb_MouseDown);
                wb.Document.Body.MouseOver += new HtmlElementEventHandler(wb_MouseOver);
                wb.Document.GetElementById("menu").InnerHtml = "";
                wb.Document.GetElementById("e-dnevnik").InnerHtml = "";
                wb.Document.GetElementById("student-class").InnerHtml = "";
                wb.Document.GetElementById("footer").InnerHtml = "";
            }
        }


        /************************
        ********REG EVENTS*******
        ****Btn clicks etc..*****
        ************************/
        #region Regular Events
        private void hidewbBtn_Click(object sender, EventArgs e)
        {
            foreach (WebBrowser wb in mainContainerPanel.Controls)
            {
                wb.Visible = false;
            }
            wbOptionsPanel.Width = 0;
        }

        private void refreshwbBtn_Click(object sender, EventArgs e)
        {
            foreach (WebBrowser wb in mainContainerPanel.Controls)
            {
                if (wb.Visible)
                {
                    wb.Navigate(wb.Url);
                    break;
                }
            }
            removeNotesBtn.Image = Properties.Resources.removenotes;
            notesHiden = false;
        }

        private void removeNotesBtn_Click(object sender, EventArgs e)
        {
            if (!notesHiden)
            {
                foreach (WebBrowser wb in mainContainerPanel.Controls)
                {
                    if (wb.Visible)
                    {
                        foreach (HtmlElement element in wb.Document.All)
                        {
                            if (element.GetAttribute("id") == "grade_notes" || element.GetAttribute("id") == "tasks" || element.GetAttribute("id") == "notes" || element.GetAttribute("className") == "notes-title" || element.GetAttribute("className") == "tasks-title" || element.GetAttribute("id") == "readings")
                            {
                                element.OuterHtml = "";
                            }
                        }
                        break;
                    }
                }
                removeNotesBtn.Image = Properties.Resources.resetnotes;
                notesHiden = true;
            }
            else
            {
                refreshwbBtn.PerformClick();
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            sf = new settingsForm(this);
            sf.ShowDialog();
        }

        private void userNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            passwordTxt_KeyDown(this, e);
        }

        void subjectBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (WebBrowser wb in mainContainerPanel.Controls)
            {
                if (wb.Tag.ToString() == btn.Tag.ToString())
                {
                    wb.Visible = true;
                    curVisible = wb;
                    if (wb.Document.GetElementById("notes") == null)
                    {
                        notesHiden = true;
                        removeNotesBtn.Image = Properties.Resources.resetnotes;
                    }
                    else
                    {
                        notesHiden = false;
                        removeNotesBtn.Image = Properties.Resources.removenotes;
                    }
                }
                else
                {
                    wb.Visible = false;
                }
            }
            wbOptionsPanel.Width = 57;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //LOGIN
            loginBtn.Enabled = false;
            if (usernameRegex.IsMatch(userNameTxt.Text))
            {
                changePanelHeight(false, true);
                
                mainwb.Document.GetElementById("user_login").SetAttribute("value", userNameTxt.Text);
                mainwb.Document.GetElementById("user_password").SetAttribute("value", passwordTxt.Text);
                foreach (HtmlElement elem in mainwb.Document.GetElementById("login-students").All)
                {
                    if (elem.GetAttribute("className").Contains("button"))
                    {
                        elem.InvokeMember("click");
                        break;
                    }
                }
            }
            else
            {
                loginBtn.Enabled = true;
                MessageBox.Show("Unjeli ste neispravno korisničko ime! Korisničko ime može sadržavati same abecedne znakove, brojeve i točke. Polje ne smije biti prazno!", "Neispravno korisničko ime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (loginBtn.Enabled)
                {
                    loginBtn.PerformClick();
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            //LOGOUT
            subjectContainerPanel.BackColor = SystemColors.GradientInactiveCaption;
            foreach (Button btn in settingsContainerPanel.Controls)
            {
                btn.BackColor = SystemColors.GradientActiveCaption;
            }
            mainwb.Navigate("ocjene.skole.hr/pocetna/odjava");
            logout();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //AUTOCOMPLETE
            refreshUserAutocomplete();
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            //AUTO FILL PASSWORD IF IT EXISTS
            bool foundMatching = false;

            foreach (string user in Properties.Settings.Default.rememberedUsers)
            {
                string autocUsr = userPassRegex.Matches(user)[0].Groups[1].Value;
                if (userNameTxt.Text == autocUsr)
                {
                    string autocPwd = userPassRegex.Matches(user)[0].Groups[2].Value;
                    if (autocPwd != " " && autocPwd != "")
                    {
                        passwordTxt.Text = autocPwd;
                        foundMatching = true;
                    }
                    break;
                }
            }
            rememberPassCheckBox.Checked = !string.IsNullOrWhiteSpace(passwordTxt.Text);
            if (!foundMatching)
            {
                passwordTxt.Clear();
                showPassPb.Visible = true;
            }
            else
            {
                showPassPb.Visible = false;
            }

        }
        #endregion

        private void statsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            stats = new statsForm(this);
            stats.calledByPrint = false;
            stats.Show();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            pf = new printForm(this);
            pf.ShowDialog();
        }

        private void showPassPb_MouseDown(object sender, MouseEventArgs e)
        {
            showPassPb.Image = Properties.Resources.showPass;
            showPassPb.BackColor = SystemColors.ControlLight;
            passwordTxt.UseSystemPasswordChar = false;
        }

        private void showPassPb_MouseUp(object sender, MouseEventArgs e)
        {
            showPassPb.Image = Properties.Resources.hidePass;
            showPassPb.BackColor = SystemColors.Control;
            passwordTxt.UseSystemPasswordChar = true;
        }

        private void showPassPb_MouseHover(object sender, EventArgs e)
        {
            showPassPb.BackColor = SystemColors.Control;
        }

        private void showPassPb_MouseLeave(object sender, EventArgs e)
        {
            showPassPb.BackColor = SystemColors.InactiveBorder;
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text.Length == 0)
            {
                showPassPb.Visible = true;
            }
        }

        private void logoutTimer_Tick(object sender, EventArgs e)
        {
            logoutBtn.PerformClick();
        }


        /************************
        ********REG EVENTS*******
        ************************/

    }
}
