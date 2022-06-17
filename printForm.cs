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
    public partial class printForm : Form
    {

        mainForm mf;
        statsForm sf;
        
        public printForm(mainForm mform)
        {
            mf = mform;
            InitializeComponent();
        }



        bool printConcl = false;
        bool printAvg = false;
        bool printAg = false;
        bool printMissing = false;
        bool printSI = false;

        bool printableVersion = false;
        int checkedCounter = 0;


        void changeState(ref PictureBox pb, ref bool refBool)
        {
            if (refBool)
            {
                pb.Image = Properties.Resources.unCheckMark;
                refBool = false;
                checkedCounter--;
            }
            else
            {
                refBool = true;
                pb.Image = Properties.Resources.checkmark;
                checkedCounter++;
            }
            if (checkedCounter != 0)
            {
                printBtn.Enabled = true;
            }
            else
            {
                printBtn.Enabled = false;
            }
        }

        private void printFgAvgBtn_Click(object sender, EventArgs e)
        {
            changeState(ref avgPb, ref printAvg);
        }

        private void printAllGradesBtn_Click(object sender, EventArgs e)
        {
            changeState(ref agPb, ref printAg);
        }

        private void printMissingBtn_Click(object sender, EventArgs e)
        {
            changeState(ref misPb, ref printMissing);
        }

        private void printConclBtn_Click(object sender, EventArgs e)
        {
            changeState(ref conclPb, ref printConcl);
        }

        private void printStudentInfoBtn_Click(object sender, EventArgs e)
        {
            changeState(ref studInfoPb, ref printSI);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            sf.calledByPrint = true;
            sf.Show();
            this.Focus();
            this.BringToFront();
            printSfd.FileName = "EasySchool Ispis - " + mf.studentNameLabel.Text;
            printSfd.ShowDialog();
        }

        private void printForm_Load(object sender, EventArgs e)
        {
            sf = new statsForm(mf);
        }

        private void printForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sf.Close();
            }
            catch { }
        }

        private void printSfd_FileOk(object sender, CancelEventArgs e)
        {
            if (printAvg || printAg)
            {
                if (MessageBox.Show("Želiš li postaviti širinu tablice za ocjene tako da pri ispisu na papir bude jednaka širini papira? U slučaju da planiraš ispisati na papir pritisni 'Da/Yes'", "Ispiši punom širinom?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    printableVersion = true;
                }
                else
                {
                    printableVersion = false;
                }
            }
            using (System.IO.StreamWriter textWriterHTML = new System.IO.StreamWriter(printSfd.FileName))
            {
                textWriterHTML.WriteLine("<!DOCTYPE html><html><head><meta charset=\"UTF-8\"><style>table, th, td " +
                    "{border: 2px solid black; border-collapse: collapse;} th, td {padding: 6px;}</style><title>EasySchool Ispis - " +
                    mf.studentNameLabel.Text + "</title></head><body><h1>EasySchool Ispis</h1><hr><h3>" + mf.studentNameLabel.Text + "</h3>");

                if (printSI)
                {

                    textWriterHTML.WriteLine("<ul style=\"list-style-type:none\">");
                    textWriterHTML.WriteLine("<li><b>Ime razrednika/ice:</b>" + mf.teacherNameLabel.Text.Split(':')[1] + "</li>");
                    textWriterHTML.WriteLine("<li><b>Razred:</b>" + mf.teacherNameLabel.Text.Split(':')[1] + "</li>");
                    textWriterHTML.WriteLine("<li><b>Škola:</b>" + mf.schoolNameLabel.Text + "</li>");
                    textWriterHTML.WriteLine("<li><b> " + mf.schoolYearLabel.Text + "</b></li></ul>");
                }


                if (printAg || printAvg)
                {
                    if (printableVersion)
                    {
                        textWriterHTML.WriteLine("<hr><h3>Ocjene</h3><table style=\"width:100%\"><tr><th>Predmet</th>");
                    }
                    else
                    {
                    textWriterHTML.WriteLine("<hr><h3>Ocjene</h3><table style=\"width:50%\"><tr><th>Predmet</th>");
                    }

                    if (printAvg)
                    {
                        textWriterHTML.WriteLine("<th>Zaključna Ocjena</th>");
                        textWriterHTML.WriteLine("<th>Prosjek</th>");
                    }
                    if (printAg)
                    {
                        textWriterHTML.WriteLine("<th>Ocjene</th>");
                    }
                    textWriterHTML.WriteLine("</tr>");
                    foreach (ListViewItem subject in sf.subjectList.Items)
                    {
                        textWriterHTML.WriteLine("<tr>");
                        textWriterHTML.WriteLine("<td>" + subject.Text.TrimEnd() + "</td>");
                        if (printAvg)
                        {
                            textWriterHTML.WriteLine("<td><b>" + subject.SubItems[2].Text + "</b></td>");
                            textWriterHTML.WriteLine("<td>" + subject.SubItems[1].Text + "</td>");
                        }
                        if (printAg)
                        {
                            textWriterHTML.WriteLine("<td>");
                            foreach (ListViewItem item in sf.allGradesListView.Items)
                            {
                                if (item.Text == subject.Text)
                                {
                                    textWriterHTML.Write(item.SubItems[1].Text);
                                    break;
                                }
                            }
                            textWriterHTML.WriteLine("</td>");
                        }
                        textWriterHTML.WriteLine("</tr>");
                    }
                    textWriterHTML.WriteLine("</table>");
                }
          
                if (printConcl)
                {
                    textWriterHTML.WriteLine("<hr><h3>Zaključak</h3><textarea readonly rows=\"10\" style=\"width:24.6%\">" + sf.conclusionTxt.Text + "</textarea>");
                }
                textWriterHTML.WriteLine("</body></html>");
                if (printMissing)
                {
                    textWriterHTML.WriteLine("<hr><h3>Izostanci</h3><table style=\"width:25%\"><tr><th>Vrsta izostanka</th><th>Broj izostanka</th></tr>");
                    textWriterHTML.WriteLine("<tr><td>Opravdano</td><th>" + sf.opravdanihLabel.Text.Split(':')[1] + "</th></tr>");
                    textWriterHTML.WriteLine("<tr><td>Neopravdano</td><th>" + sf.neopravdanihLabel.Text.Split(':')[1] + "</th></tr>");
                    textWriterHTML.WriteLine("<tr><td>Čeka odluku razrednika/ce</td><th>" + sf.cekaodlukuLabel.Text.Split(':')[1] + "</th></tr>");
                    textWriterHTML.WriteLine("<tr><td>Ukupno</td><th>" + sf.ukupnoLabel.Text.Split(':')[1] + "</th></tr>");
                    textWriterHTML.WriteLine("<tr><td>Ostali izostanci</td><th>" + sf.ostaloLabel.Text.Split(':')[1] + "</th></tr>");
                }
            }
            if (MessageBox.Show("Ispis uspješan! Želite li otvoriti ispis u zadanom internet pregledniku?", "Prikaži ispis?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(printSfd.FileName);
            }
        }
    }
}
