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
    public partial class pickClass : Form
    {

        mainForm mf;
        bool pickedNothing = true;
        public pickClass(mainForm mainform)
        {
            mf = mainform;
            InitializeComponent();
        }

        private void pickClass_Load(object sender, EventArgs e)
        {
            foreach (HtmlElement element in mf.mainwb.Document.All)
            {
                if (element.GetAttribute("className") == "class")
                {
                    var classList = element.InnerText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    ListViewItem newClass = new ListViewItem();
                    newClass.Text = classList[0];
                    newClass.SubItems.Add(classList[1].Replace("Školska godina ", ""));
                    newClass.SubItems.Add(classList[2]);
                    newClass.SubItems.Add(classList[3].Replace("Razrednik: ", ""));
                    classListLV.Items.Add(newClass);
                }
            }
        }

        private void pickClassBtn_Click(object sender, EventArgs e)
        {
            if (classListLV.SelectedItems.Count == 1)
            {
                foreach (HtmlElement elem in mf.mainwb.Document.GetElementById("classes").All)
                {
                    if (elem.GetAttribute("className") == "class")
                    {
                        if (elem.InnerText.Contains(classListLV.SelectedItems[0].Text))
                        {
                            elem.InvokeMember("click");
                            pickedNothing = false;
                            break;
                        }
                    }
                }
                this.Close();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Nisi odabrao niti jedan razred.", "Odaberi razred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void classListLV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pickClassBtn.PerformClick();
        }

        private void pickClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pickedNothing)
            {
                e.Cancel = true;
            }
        }
    }
}
