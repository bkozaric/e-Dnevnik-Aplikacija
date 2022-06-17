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
    public partial class statsForm : Form
    {
        //default panel size = 806; 462, location = 3;3

        mainForm mf;

        Regex averageRegex = new Regex(@"^Prosjek ocjena\:\s([\d\,]{4})$");
        Regex finalGradeRegex = new Regex(@"^.+\(([1-5]{1})\)$");
        Regex gradeRegex = new Regex(@"\d");
        Regex noteRegex = new Regex(@">(.+)<");
        Regex gradeDateRegex = new Regex(@"(\d{2}\.\d{2}\.\d{4}\.)\s");
        Regex testDateRegex = new Regex(@"(\d{2}\.\d{2}\.\d{4}\.)");

        public bool calledByPrint = false;

        //school variables
        int gradeSum = 0;
        decimal totalAverage = 0.0M;
        int subjectCount = 0;

        int fGrade5counter = 0;
        int fGrade4counter = 0;
        int fGrade3counter = 0;
        int fGrade2counter = 0;
        int fGrade1counter = 0;

        public statsForm(mainForm mform)
        {
            mf = mform;
            InitializeComponent();
            foreach (Panel pnl in mainContainerPanel.Controls)
            {
                pnl.Visible = false;
                pnl.Location = new Point(0, 0);
                pnl.Size = new Size(0, 0);
            }

        }

        private void statsForm_Load(object sender, EventArgs e)
        {

            fGradeCombo.SelectedIndex = 4;
            goToAvgBtn.PerformClick();

            //SUBJECT LIST
            foreach (Button btn in mf.subjectContainerPanel.Controls)
            {
                if (btn.Tag.ToString() != "sat-razrednika")
                {
                    ListViewItem newSubject = new ListViewItem();
                    newSubject.Text = btn.Text;
                    newSubject.SubItems.Add("p");
                    newSubject.SubItems.Add("z");
                    newSubject.SubItems.Add("NE");
                    subjectList.Items.Insert(0, newSubject);
                }
            }
            subjectCount = subjectList.Items.Count;
            subjectCountLabel.Text = "Broj predmeta: " + subjectCount.ToString();

            //AVERAGES
            int averageIndexCounter = 0;
            foreach (WebBrowser wb in mf.mainContainerPanel.Controls)
            {
                if (wb.Tag.ToString() != "sat-razrednika")
                {
                    foreach (HtmlElement avg in wb.Document.GetElementById("content").All)
                    {
                        if (avg.GetAttribute("className") == "average")
                        {
                            subjectList.Items[averageIndexCounter].SubItems[1].Text = averageRegex.Matches(avg.InnerText)[0].Groups[1].Value;
                            averageIndexCounter++;
                            break;
                        }
                    }
                }
            }

            //FINAL GRADES
            int fGradeIndexCounter = 0;
            foreach (WebBrowser wb in mf.mainContainerPanel.Controls)
            {
                if (wb.Tag.ToString() != "sat-razrednika")
                {
                    foreach (HtmlElement fgrade in wb.Document.GetElementById("content").All)
                    {
                        if (fgrade.GetAttribute("className") == "t-center bold" && fgrade.GetAttribute("colspan") != "4")
                        {
                            if (!string.IsNullOrEmpty(fgrade.InnerText))
                            {
                                subjectList.Items[fGradeIndexCounter].SubItems[2].Text = finalGradeRegex.Matches(fgrade.InnerText)[0].Groups[1].Value;
                                subjectList.Items[fGradeIndexCounter].SubItems[3].Text = "DA";
                            }
                            fGradeIndexCounter++;
                            break;
                        }
                    }
                }
            }

            //FINAL GRADES BY AVERAGE - zaključi ocjene po prosjeku u slučaju da neke ocjene nisu zaključene
            //Prebroji zaključne ocjene, ukupni prosjek
            gradeCount_totalAverage_fGradesByAverage();


            // ALL GRADES
            int grade5counter = 0;
            int grade4counter = 0;
            int grade3counter = 0;
            int grade2counter = 0;
            int grade1counter = 0;
            int totalGradeCount = 0;
            foreach (ListViewItem subject in subjectList.Items)
            {
                allGradesListView.Items.Add(subject.Text);
            }
            foreach (ListViewItem subject in allGradesListView.Items)
            {
                foreach (WebBrowser wb in mf.mainContainerPanel.Controls)
                {
                    foreach (HtmlElement elem in wb.Document.GetElementById("content").All)
                    {
                        if (elem.GetAttribute("className") == "course-name")
                        {
                            if (elem.InnerText.Split('\n')[0].Substring(0, elem.InnerText.Split('\n')[0].Length - 1) == subject.Text)
                            {
                                List<string> gradeList = new List<string>();
                                foreach (HtmlElement grade in wb.Document.GetElementById("content").All)
                                {
                                    if (grade.GetAttribute("className") == "ocjena")
                                    {
                                        if (!string.IsNullOrEmpty(grade.InnerText))
                                        {
                                            gradeList.Add(grade.InnerText);
                                        }
                                    }
                                }
                                subject.SubItems.Add("");
                                for (int i = gradeList.Count - 1; i >= 0; i--)
                                {
                                    string grd = gradeList[i];
                                    totalGradeCount++;
                                    if (grd == "1")
                                    {
                                        grade1counter++;
                                    }
                                    else if (grd == "2")
                                    {
                                        grade2counter++;
                                    }
                                    else if (grd == "3")
                                    {
                                        grade3counter++;
                                    }
                                    else if (grd == "4")
                                    {
                                        grade4counter++;
                                    }
                                    else if (grd == "5")
                                    {
                                        grade5counter++;
                                    }
                                    subject.SubItems[1].Text += grd;
                                    if (i != 0)
                                    {
                                        subject.SubItems[1].Text += ", ";
                                    }

                                }
                            }
                            break;
                        }
                    }
                }
            }

            totaleGradeCountLabel.Text = "Ukupan broj ocjena: " + totalGradeCount.ToString();
            grade5Label.Text = "Broj odličnih: " + grade5counter.ToString();
            grade4Label.Text = "Broj vrlo dobrih: " + grade4counter.ToString();
            grade3Label.Text = "Broj dobrih: " + grade3counter.ToString();
            grade2Label.Text = "Broj dovoljnih: " + grade2counter.ToString();
            grade1Label.Text = "Broj nedovoljnih: " + grade1counter.ToString();
            grade5PercLabel.Text = "Postotak odličnih: " + Decimal.Round(Decimal.Round((decimal)grade5counter / totalGradeCount, 4) * 100, 2).ToString() + "%";
            grade4PercLabel.Text = "Postotak vrlo dobrih: " + Decimal.Round(Decimal.Round((decimal)grade4counter / totalGradeCount, 4) * 100, 2).ToString() + "%";
            grade3PercLabel.Text = "Postotak dobrih: " + Decimal.Round(Decimal.Round((decimal)grade3counter / totalGradeCount, 4) * 100, 2).ToString() + "%";
            grade2PercLabel.Text = "Postotak dovoljnih: " + Decimal.Round(Decimal.Round((decimal)grade2counter / totalGradeCount, 4) * 100, 2).ToString() + "%";
            grade1PercLabel.Text = "Postotak nedovoljnih: " + Decimal.Round(Decimal.Round((decimal)grade1counter / totalGradeCount, 4) * 100, 2).ToString() + "%";

            //nedavne ocjene
            recentGrades(Properties.Settings.Default.gradeRange);

            //testovi
            upcomingTests(Properties.Settings.Default.testRange);

            //addInfo
            generateAddInfo();

            //izostanci
            Regex misHourRegex = new Regex(@"sat>(\d{1,2}\.)<");
            Regex misStatusRegex = new Regex(@"alt=(\w+)");
            Regex missingLegendRegex = new Regex(@":\s(\d+)");
            int missingTreeCounter = 0;
            List<string> tempMissingList = new List<string>();
            string lastDate = null;
            foreach (HtmlElement mis in mf.missingWb.Document.All)
            {
                if (mis.GetAttribute("className") == "datum")
                {
                    if (lastDate != null)
                    {
                        foreach (string misItem in tempMissingList)
                        {
                            missingTreeView.Nodes[missingTreeCounter].Nodes.Add(misItem);
                        }
                        missingTreeCounter++;
                        tempMissingList.Clear();
                    }
                    lastDate = mis.InnerHtml.Replace("<BR>", " ");
                    missingTreeView.Nodes.Add(lastDate);
                }
                if (mis.GetAttribute("className") == "predmet")
                {
                    try
                    {
                        tempMissingList.Add(misHourRegex.Matches(mis.Parent.InnerHtml)[0].Groups[1].Value + " " +
                          mis.InnerText + " — " + misStatusRegex.Matches(mis.Parent.InnerHtml)[0].Groups[1].Value);
                    }
                    catch
                    {
                        tempMissingList.Add(misHourRegex.Matches(mis.Parent.InnerHtml)[0].Groups[1].Value + " " + mis.InnerText + " — Čeka odluku razrednika");
                    }
                }
            }
            foreach (string misItem in tempMissingList)
            {
                missingTreeView.Nodes[missingTreeCounter].Nodes.Add(misItem);
            }
            foreach(HtmlElement mis in mf.missingWb.Document.All)
            {
                if(mis.GetAttribute("className") == "legend")
                {
                    MatchCollection missingLegend = missingLegendRegex.Matches(mis.InnerText);
                    int opravdanih = Convert.ToInt32(missingLegend[0].Groups[1].Value);
                    int neopravdanih = Convert.ToInt32(missingLegend[1].Groups[1].Value);
                    int cekaodluku = Convert.ToInt32(missingLegend[2].Groups[1].Value);
                    int ukupno = Convert.ToInt32(missingLegend[3].Groups[1].Value);
                    int ostalo = Convert.ToInt32(missingLegend[4].Groups[1].Value);

                    opravdanihLabel.Text = "Opravdanih: " + opravdanih.ToString();
                    neopravdanihLabel.Text = "Neopravdanih: " + neopravdanih.ToString();
                    cekaodlukuLabel.Text = "Čeka odluku razrednika: " + cekaodluku.ToString();
                    ukupnoLabel.Text = "Ukupno: " + ukupno.ToString();
                    ostaloLabel.Text = "Ostalo: " + ostalo.ToString();

                    if (opravdanih > 0)
                    {
                        percOpravdanoLabel.Text = "Postotak opravdanih: " + Decimal.Round(Decimal.Round((decimal)opravdanih / ukupno, 4) * 100, 2).ToString() + "%";
                    }
                    else
                    {
                        percOpravdanoLabel.Text = "Postotak opravdanih: 0%";
                    }
                    if(neopravdanih > 0)
                    {
                        percNeopravdanoLabel.Text = "Postotak neopravdanih: " + Decimal.Round(Decimal.Round((decimal)neopravdanih / ukupno, 4) * 100, 2).ToString() + "%";
                    }
                    else
                    {
                        percNeopravdanoLabel.Text = "Postotak neopravdanih: 0%";
                    }
                    if(cekaodluku > 0)
                    {
                        percCekaLabel.Text = "Postotak Čeka odluku razrednika: " + Decimal.Round(Decimal.Round((decimal)cekaodluku / ukupno, 4) * 100, 2).ToString() + "%";
                    }
                    else
                    {
                        percCekaLabel.Text = "Postotak Čeka odluku razrednika: 0%";
                    }
                    break;
                }
            }
            if (!calledByPrint)
            {
                this.ShowInTaskbar = true;
                this.Opacity = 1;
            }
        }


        void generateAddInfo()
        {
            int sumNeededForPerfect = subjectCount * 5;
            int sumNeededFor5 = Convert.ToInt32(decimal.Round((decimal)subjectCount * 4.5M, 0));
            int sumNeededFor4 = Convert.ToInt32(decimal.Round((decimal)subjectCount * 3.5M, 0));
            int sumNeededFor3 = Convert.ToInt32(decimal.Round((decimal)subjectCount * 2.5M, 0));
            int sumNeededFor2 = Convert.ToInt32(decimal.Round((decimal)subjectCount * 2M, 0));

            sumNeededForPerfectLabel.Text = "Suma zaključnih ocjena potrebna za najbolji opći uspjeh: " + sumNeededForPerfect.ToString();
            sumNeededFor5Label.Text = "Suma zaključnih ocjena potrebna za odličan opći uspjeh: " + sumNeededFor5.ToString();
            sumNeededFor4Label.Text = "Suma zaključnih ocjena potrebna za vrlo dobar opći uspjeh: " + sumNeededFor4.ToString();
            sumNeededFor3Label.Text = "Suma zaključnih ocjena potrebna za dobar opći uspjeh: " + sumNeededFor3.ToString();
            sumNeededFor2Label.Text = "Suma zaključnih ocjena potrebna za prolaz: " + sumNeededFor2.ToString();

            string conclusionInfo = "";

            if (fGrade1counter > 0)
            {
                conclusionInfo = "Zbroj tvojih zaključnih ocjena je " + Convert.ToString(gradeSum) + ", a prosjek iznosi " + Convert.ToString(totalAverage).Replace(",", ".") + ". No nažalost ti imaš negativnu ocjenu i ne možeš proći razred. Broj negativnih zaključnih ocjena: " + fGrade1counter.ToString();
            }
            else
            {
                if (totalAverage >= 2.0M && totalAverage < 2.5M)
                {
                    conclusionInfo += "Zbroj tvojih zaključnih ocjena je " + Convert.ToString(gradeSum) + ", a prosjek iznosi " + Convert.ToString(totalAverage).Replace(",", ".") + ", prema tom prosjeku ti razred prolaziš sa dovoljnim uspjehom, za dobar uspjeh moraš dignuti zbroj zaključnih ocjena za " + Convert.ToString(sumNeededFor3 - gradeSum);
                }
                else if (totalAverage < 3.5M)
                {
                    conclusionInfo += "Zbroj tvojih zaključnih ocjena je " + Convert.ToString(gradeSum) + ", a prosjek iznosi " + Convert.ToString(totalAverage).Replace(",", ".") + ", prema tom prosjeku ti razred prolaziš sa dobrim uspjehom, za vrlo dobar uspjeh moraš dignuti zbroj zaključnih ocjena za " + Convert.ToString(sumNeededFor4 - gradeSum);
                }
                else if (totalAverage < 4.5M)
                {
                    conclusionInfo += "Zbroj tvojih zaključnih ocjena je " + Convert.ToString(gradeSum) + ", a prosjek iznosi " + Convert.ToString(totalAverage).Replace(",", ".") + ", prema tom prosjeku ti razred prolaziš sa vrlo dobrim uspjehom, za odličan uspjeh moraš dignuti zbroj zaključnih ocjena za " + Convert.ToString(sumNeededFor5 - gradeSum);
                }
                else if (totalAverage < 5.0M)
                {
                    conclusionInfo += "Zbroj tvojih zaključnih ocjena je " + Convert.ToString(gradeSum) + ", a prosjek iznosi " + Convert.ToString(totalAverage).Replace(",", ".") + ", prema tom prosjeku ti razred prolaziš sa odličnim uspjehom, za najbolji mogući uspjeh moraš dignuti zbroj zaključnih ocjena za " + Convert.ToString(sumNeededForPerfect - gradeSum);
                }
                else if (totalAverage == 5.0M)
                {
                    conclusionInfo += "Zbroj tvojih zaključnih ocjena je " + Convert.ToString(gradeSum) + ", a prosjek iznosi 5.0, prema tom prosjeku ti razred prolaziš sa odličnim uspjehom, te ujedno i najboljim mogućim uspjehom!";
                }
                else
                {
                    conclusionInfo += "Došlo je do greške pri generiranju zaključka";
                }
            }
            conclusionInfo += ".";
            conclusionTxt.Text = conclusionInfo;
            if (fGrade1counter > 0 ||fGrade2counter > 0)
            {
                conclusionTxt.Text += "\n\nIz sljedećih predmeta imaš najgore zaključne ocjene i njih bi prve trebao popraviti:\n";
            }
            

            List<string> mustFixSubjects = new List<string>();
            List<string> shouldFixSubjects = new List<string>();
            for (int i = 0; i < subjectCount; i++)
            {
                ListViewItem tempSubj = subjectList.Items[i];
                if (tempSubj.SubItems[2].Text == "1") 
                {
                    mustFixSubjects.Insert(0,tempSubj.Text + " - imaš zaključnu ocjenu 1\n");
                }
                if (tempSubj.SubItems[2].Text == "2")
                {
                    mustFixSubjects.Add(tempSubj.Text + " - imaš zaključnu ocjenu 2\n");
                }
                if (tempSubj.SubItems[2].Text == "3") 
                {
                    shouldFixSubjects.Insert(0, tempSubj.Text + " - imaš zaključnu ocjenu 3\n");
                }
                if (tempSubj.SubItems[2].Text == "4")
                {
                    shouldFixSubjects.Add(tempSubj.Text + " - imaš zaključnu ocjenu 4\n");
                }
            }
            foreach (string str in mustFixSubjects)
            {
                conclusionTxt.Text += str; 
            }

            if (fGrade3counter > 0 || fGrade4counter > 0)
            {           
                conclusionTxt.Text += "\n\nIz sljedećih predmeta imaš lošije zaključne ocjene i njih bi trebao popraviti za bolji uspjeh:\n";
                foreach (string str in shouldFixSubjects)
                {
                    conclusionTxt.Text += str;
                }
            }

            fGradeSumLabel.Text = "Suma zaključnih ocjena: " + gradeSum.ToString();
            totalAverageLabel.Text = totalAvgLabel.Text;
            overallSuccessLabel.Text = "Opći uspjeh: " + Decimal.Round(totalAverage, 0).ToString();

        }

        bool noFGrade = false;
        void gradeCount_totalAverage_fGradesByAverage()
        {
            
            foreach (ListViewItem subject in subjectList.Items)
            {
                if (subject.SubItems[2].Text.Contains("z"))
                {
                    decimal average = Convert.ToDecimal(subject.SubItems[1].Text);
                    if(average != (decimal)0.0)
                    {
                        if (average < (decimal)1.5)
                        {
                            subject.SubItems[2].Text = "1";
                        }
                        else if (average < (decimal)2.5)
                        {
                            subject.SubItems[2].Text = "2";
                        }
                        else if (average < (decimal)3.5)
                        {
                            subject.SubItems[2].Text = "3";
                        }
                        else if (average < (decimal)4.5)
                        {
                            subject.SubItems[2].Text = "4";
                        }
                        else
                        {
                            subject.SubItems[2].Text = "5";
                        }
                    }
                    else
                    {
                        noFGrade = true;
                        subject.SubItems[1].Text = "5,00";
                        subject.SubItems[2].Text = "5";
                    }
                }
            }
            if (noFGrade)
            {
                MessageBox.Show("Iz nekih predmeta još uvijek nisi ocjenjen. Iz tih predmeta ti je automatski zaključena ocjena 'Odličan (5)'", "Pronađeni predmeti bez ocjena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                noFGrade = false;
            }


            fGrade5counter = 0;
            fGrade4counter = 0;
            fGrade3counter = 0;
            fGrade2counter = 0;
            fGrade1counter = 0;
            foreach (ListViewItem subject in subjectList.Items)
            {
                if (subject.SubItems[2].Text == "1")
                {
                    fGrade1counter += 1;
                }
                else if (subject.SubItems[2].Text == "2")
                {
                    fGrade2counter += 1;
                }
                else if (subject.SubItems[2].Text == "3")
                {
                    fGrade3counter += 1;
                }
                else if (subject.SubItems[2].Text == "4")
                {
                    fGrade4counter += 1;
                }
                else if (subject.SubItems[2].Text == "5")
                {
                    fGrade5counter += 1;
                }
            }

            barChart.Series[0].Points.Clear();
            barChart.Series[0].Points.AddXY(1, fGrade1counter);
            barChart.Series[0].Points.AddXY(2, fGrade2counter);
            barChart.Series[0].Points.AddXY(3, fGrade3counter);
            barChart.Series[0].Points.AddXY(4, fGrade4counter);
            barChart.Series[0].Points.AddXY(5, fGrade5counter);

            fGrade1Label.Text = "Broj nedovoljnih zaključnih ocjena: " + fGrade1counter.ToString();
            fGrade2Label.Text = "Broj dovoljnih zaključnih ocjena: " + fGrade2counter.ToString();
            fGrade3Label.Text = "Broj dobrih zaključnih ocjena: " + fGrade3counter.ToString();
            fGrade4Label.Text = "Broj vrlo dobrih zaključnih ocjena: " + fGrade4counter.ToString();
            fGrade5Label.Text = "Broj odličnih zaključnih ocjena: " + fGrade5counter.ToString();

            gradeSum = fGrade1counter + fGrade2counter * 2 + fGrade3counter * 3 + fGrade4counter * 4 + fGrade5counter * 5;
            totalAverage = Decimal.Round((decimal)gradeSum / (decimal)subjectList.Items.Count, 2, MidpointRounding.AwayFromZero);
            totalAvgLabel.Text = "Ukupni prosjek: " + totalAverage.ToString();

        }

        void recentGrades(int range = 5)
        {
            recentGradesList.Items.Clear();
            DateTime todayDate = DateTime.Today.Date;
            foreach (WebBrowser wb in mf.mainContainerPanel.Controls)
            {
                foreach (HtmlElement elem in wb.Document.All)
                {
                    if (elem.GetAttribute("className") == "ocjena")
                    {
                        if (elem.InnerHtml != null)
                        {
                            var recentGradeArray = elem.Parent.OuterHtml.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                            if (!recentGradeArray[2].Contains("Ocjena"))
                            {

                                ListViewItem newRecentGrade = new ListViewItem();
                                string rGradeSubject = null;
                                string rGrade = gradeRegex.Match(recentGradeArray[2]).Value;
                                string rGradeNote = noteRegex.Match(recentGradeArray[1]).Groups[1].Value;
                                string rGradeDate = gradeDateRegex.Match(recentGradeArray[0]).Groups[1].Value;
                                int rGradeDateDiff = 0;

                                DateTime rGradeRealDate = Convert.ToDateTime(rGradeDate);
                                rGradeDateDiff = todayDate.Subtract(rGradeRealDate).Days;

                                foreach (HtmlElement subj in wb.Document.GetElementById("content").All)
                                {
                                    if (subj.GetAttribute("className") == "course-name")
                                    {
                                        rGradeSubject = subj.InnerText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)[0];
                                        break;
                                    }
                                }
                                newRecentGrade.Text = rGradeSubject;
                                newRecentGrade.SubItems.Add(rGrade);
                                newRecentGrade.SubItems.Add(rGradeNote);
                                newRecentGrade.SubItems.Add(rGradeDate);
                                if (rGradeDateDiff == 1)
                                {
                                    newRecentGrade.SubItems.Add("Jučer");
                                }
                                else if(rGradeDateDiff == 0)
                                {
                                    newRecentGrade.SubItems.Add("Danas");
                                }
                                else
                                {
                                    if (rGradeDateDiff.ToString().EndsWith("1") && rGradeDateDiff != 11)
                                    {
                                        newRecentGrade.SubItems.Add("Prije " + rGradeDateDiff.ToString() + " dan");
                                    }
                                    else
                                    {
                                        newRecentGrade.SubItems.Add("Prije " + rGradeDateDiff.ToString() + " dana");
                                    }
                                }
                                
                                if (rGradeDateDiff <= range)
                                {
                                    recentGradesList.Items.Add(newRecentGrade);
                                }
                            }
                        }
                    }

                }
            }
            recentGradesStatsLabel.Text = "Dobio si " + recentGradesList.Items.Count.ToString() + " ocjena u posljednih ";
            if (range > 364)
            {
                recentGradesStatsLabel.Text += "godinu dana.";
            }
            else
            {
                recentGradesStatsLabel.Text += range.ToString() + " dana.";
            }
        }

        void upcomingTests(int range = 15)
        {
            upcomingTestsListView.Items.Clear();
            DateTime todayDate = DateTime.Today.Date;
            foreach(HtmlElement uTest in mf.utWb.Document.GetElementById("content").All)
            {
                if(uTest.GetAttribute("className") == "datum")
                {
                    string[] upcomingTestArray = uTest.Parent.InnerHtml.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    string utNote = noteRegex.Match(upcomingTestArray[1]).Groups[1].Value;
                    string utDate = testDateRegex.Match(upcomingTestArray[2]).Groups[1].Value;
                    string utSubject = noteRegex.Match(upcomingTestArray[0]).Groups[1].Value;
                    int utDateDiff = Convert.ToDateTime(utDate).Subtract(todayDate).Days;

                    ListViewItem newUpcomingTest = new ListViewItem();
                    newUpcomingTest.Text = utSubject;
                    newUpcomingTest.SubItems.Add(utNote);
                    newUpcomingTest.SubItems.Add(utDate);
                    if (utDateDiff == 1)
                    {
                        newUpcomingTest.SubItems.Add("Sutra");
                    }
                    else if (utDateDiff == 0)
                    {
                        newUpcomingTest.SubItems.Add("Danas");
                    }
                    else
                    {
                        if (utDateDiff.ToString().EndsWith("1") && utDateDiff != 11)
                        {
                            newUpcomingTest.SubItems.Add("Za " + utDateDiff.ToString() + " dan");
                        }
                        else
                        {
                            newUpcomingTest.SubItems.Add("Za " + utDateDiff.ToString() + " dana");
                        }
                        
                    }
                    if (utDateDiff <= range)
                    {
                        upcomingTestsListView.Items.Add(newUpcomingTest);
                    }
                }
            }
            upcomingnTestsStatsLabel.Text = "Imaš " + upcomingTestsListView.Items.Count.ToString() + " nadolazećih ispita ";
            if (range > 364)
            {
                upcomingnTestsStatsLabel.Text += "do kraja školske godine.";
            }
            else
            {
                upcomingnTestsStatsLabel.Text += "u sljedećih " + range.ToString() + " dana.";
            }

        }



        private void selectorButton_Click(object sender, EventArgs e)
        {
            Button cBtn = (Button)sender;
            foreach (Control btn in leftPanel.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    if (btn == cBtn)
                    {
                        btn.BackColor = SystemColors.GradientInactiveCaption;
                    }
                    else
                    {
                        btn.BackColor = SystemColors.GradientActiveCaption;
                    }
                }
            }
            foreach (Panel pnl in mainContainerPanel.Controls)
            {
                if (pnl.Tag.ToString() == cBtn.Tag.ToString())
                {
                    pnl.Visible = true;
                    pnl.Location = new Point(3, 3);
                    pnl.Size = new Size(806, 462);
                }
                else
                {
                    pnl.Visible = false;
                    pnl.Location = new Point(0, 0);
                    pnl.Size = new Size(0, 0);
                }
            }
        }

        private void changeGradeRangeBtn_Click(object sender, EventArgs e)
        {
            changeRangeForm crf = new changeRangeForm(this);
            crf.ShowDialog();
            if (crf.result != null)
            {
                recentGrades(Convert.ToInt32(crf.result));
            }
        }

        private void recentGradesStatsBtn_Click(object sender, EventArgs e)
        {
            int r1c = 0;
            int r2c = 0;
            int r3c = 0;
            int r4c = 0;
            int r5c = 0;
            List<string> subList = new List<string>();
            string subListString = "";
            foreach (ListViewItem lItem in recentGradesList.Items)
            {
                subList.Add(lItem.Text);
                if (lItem.SubItems[1].Text == "1")
                {
                    r1c++;
                }
                else if (lItem.SubItems[1].Text == "2")
                {
                    r2c++;
                }
                else if (lItem.SubItems[1].Text == "3")
                {
                    r3c++;
                }
                else if (lItem.SubItems[1].Text == "4")
                {
                    r4c++;
                }
                else if (lItem.SubItems[1].Text == "5")
                {
                    r5c++;
                }
            }
            foreach (string item in subList)
            {

                if (!subListString.Contains(item))
                {

                    subListString += item + "\n";
                }
                else
                {
                    int numofocurs = 0;
                    while (subList[subList.IndexOf(item) + numofocurs] == item)
                    {
                        numofocurs++;
                        if (subList.IndexOf(item) + numofocurs + 1 > subList.Count)
                        {
                            break;
                        }
                    }
                    if (!subListString.Contains(item + " —"))
                    {
                        subListString = subListString.Replace(item, item + " — " + numofocurs.ToString() + " ocjene");
                    }

                }
            }

            MessageBox.Show(recentGradesStatsLabel.Text + "\n\nOd toga " +
                r5c.ToString() + " odličnih,\n" +
                r4c.ToString() + " vrlo dobrih,\n" +
                r3c.ToString() + " dobrih,\n" +
                r2c.ToString() + " dovoljnih i\n" +
                r1c.ToString() + " nedovoljnih.\n\n" +
            "Predmeti iz kojih si dobio ocjene: \n" + subListString, "Statistika nedavnih ocjena", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tellfGrade_Click(object sender, EventArgs e)
        {
            Button sBtn = (Button)sender;
            string cGradeSubjectList = "";
            string[] fGradeListString = { "Nedovoljan (1)", "Dovoljan (2)", "Dobar (3)", "Vrlo Dobar (4)", "Odličan (5)" };
            foreach (ListViewItem subject in subjectList.Items)
            {
                if (subject.SubItems[2].Text == sBtn.Tag.ToString())
                {
                    cGradeSubjectList += (subject.Text + "\n");
                }
            }
            if (cGradeSubjectList.Length > 0)
            {
                MessageBox.Show("Predmeti s zaključnom ocjenom '" + fGradeListString[Convert.ToInt32(sBtn.Tag.ToString()) - 1] + "':\n\n" + cGradeSubjectList, "Prikaz predmeta s određenom zaključnom ocjenom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ne postoji ni jedan predmet s zaključnom ocjenom '" + fGradeListString[Convert.ToInt32(sBtn.Tag.ToString()) - 1] + "'.", "Nije pronađen ni jedan predmet.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void subjectList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (subjectList.SelectedItems.Count == 1)
            {
                fGradeDialog fgd = new fGradeDialog();
                fgd.ShowDialog();
                if (fgd.result != null)
                {
                    subjectList.SelectedItems[0].SubItems[2].Text = fgd.result;
                    gradeCount_totalAverage_fGradesByAverage();
                    generateAddInfo();
                }
            }
        }

        private void changeTestRangeBtn_Click(object sender, EventArgs e)
        {
            changeRangeForm crf = new changeRangeForm(this);
            crf.ShowDialog();
            if (crf.result != null)
            {
                upcomingTests(Convert.ToInt32(crf.result));
            }
        }

        private void missingPerMonthBtn_Click(object sender, EventArgs e)
        {
            int septMissing = 0;
            int octMissing = 0;
            int novMissing = 0;
            int decMissing = 0;
            int janMissing = 0;
            int febMissing = 0;
            int marchMissing = 0;
            int aprilMissing = 0;
            int mayMissing = 0;
            int juneMissing = 0;
            int ukupnoMissing = 0;

            Regex missingDateRegex = new Regex(@".+\s\d{2}\.(\d{2})\.\d{4}\.");
            string message = "Broj izostanaka po mjesecima:\n\n";

            foreach (TreeNode missingDate in missingTreeView.Nodes)
            {
                if (missingDateRegex.IsMatch(missingDate.Text))
                {
                    int month = Convert.ToInt16(missingDateRegex.Match(missingDate.Text).Groups[1].Value);
                    int hourCount = missingDate.Nodes.Count;

                    if(month == 9)
                    {
                        septMissing+=hourCount;
                    }
                    else if (month == 10)
                    {
                        octMissing+=hourCount;
                    }
                    else if (month == 11)
                    {
                        novMissing+=hourCount;
                    }
                    else if (month == 12)
                    {
                        decMissing+=hourCount;
                    }
                    else if (month == 1)
                    {
                        janMissing+=hourCount;
                    }
                    else if (month == 2)
                    {
                        febMissing+=hourCount;
                    }
                    else if (month == 3)
                    {
                        marchMissing+=hourCount;
                    }
                    else if (month == 4)
                    {
                        aprilMissing+=hourCount;
                    }
                    else if (month == 5)
                    {
                        mayMissing+=hourCount;
                    }
                    else if (month == 6)
                    {
                        juneMissing+=hourCount;
                    }
                    ukupnoMissing += hourCount;
                }
            }
            message += "Rujan: " + septMissing.ToString() + "\n";
            message += "Listopad: " + octMissing.ToString() + "\n";
            message += "Studeni: " + novMissing.ToString() + "\n";
            message += "Prosinac: " + decMissing.ToString() + "\n";
            message += "Siječanj: " + janMissing.ToString() + "\n";
            message += "Veljača: " + febMissing.ToString() + "\n";
            message += "Ožujak: " + marchMissing.ToString() + "\n";
            message += "Travanj: " + aprilMissing.ToString() + "\n";
            message += "Svibanj: " + mayMissing.ToString() + "\n";
            message += "Lipanj: " + juneMissing.ToString() + "\n\n";
            message += "Ukupno svih izostanaka: " + ukupnoMissing.ToString();

            MessageBox.Show(message, "Izostanci po mjesecima", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void missingPerSubjectBtn_Click(object sender, EventArgs e)
        {
            string message = "Broj izostanaka po predmetima:\n\n";
            int ukupnoMissing = 0;
            for (int i = mf.subjectContainerPanel.Controls.Count - 1; i >= 0; i--)
            {
                Button cBtn = (Button)mf.subjectContainerPanel.Controls[i];
                string curSubject = cBtn.Text;
                int misCounter = 0;
                foreach (TreeNode date in missingTreeView.Nodes)
                {
                    foreach (TreeNode mSubject in date.Nodes)
                    {
                        if (mSubject.Text.Contains(cBtn.Text.Replace(" (izborni)","")))
                        {
                            misCounter++;
                            ukupnoMissing++;
                        }
                    }
                }
                message += curSubject + ": " + misCounter.ToString() + "\n";
            }
            message+="\nUkupno svih izostanaka: " + ukupnoMissing.ToString();
            MessageBox.Show(message, "Izostanci po predmetima", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void statsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.Show();
        }

        private void allGradesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gradeStatsForm gform = new gradeStatsForm(this);
            gform.ShowDialog();
        }

        private void fGradeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tell5fGrade.Text = String.Format("Iz čega imam zaključnu ocjenu \"{0}\"", fGradeCombo.Text);
            tell5fGrade.Tag = (fGradeCombo.SelectedIndex + 1).ToString();
        }
    }
}
