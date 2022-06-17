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
using System.Windows.Forms.DataVisualization.Charting;

namespace EasySchool
{
    public partial class gradeStatsForm : Form
    {

        statsForm sf;

        public gradeStatsForm(statsForm sform)
        {
            sf = sform;
            InitializeComponent();
        }

        private void graphForm_Load(object sender, EventArgs e)
        {
            string grades = sf.allGradesListView.SelectedItems[0].SubItems[1].Text;
            if (grades.Length > 0)
            {
                char[] allowed = { '1', '2', '3', '4', '5' };
                int gradeCounter = 0;
                for (int i = 0; i < grades.Length; i++)
                {
                    if (allowed.Contains(grades[i]))
                    {
                        lineChart.Series[0].Points.AddXY(gradeCounter, Convert.ToInt16(grades[i].ToString()));
                        gradeCounter++;
                    }
                }

                int grade1c = 0;
                int grade2c = 0;
                int grade3c = 0;
                int grade4c = 0;
                int grade5c = 0;
                int gradeTotal = 0;

                this.Text += "'" + sf.allGradesListView.SelectedItems[0].Text.TrimEnd() + "'";

                MatchCollection gradesMCol = new Regex(@"\d").Matches(grades);
                foreach (Match gradeMatch in gradesMCol)
                {
                    if (gradeMatch.Value == "1")
                    {
                        grade1c++;
                    }
                    else if (gradeMatch.Value == "2")
                    {
                        grade2c++;
                    }
                    else if (gradeMatch.Value == "3")
                    {
                        grade3c++;
                    }
                    else if (gradeMatch.Value == "4")
                    {
                        grade4c++;
                    }
                    else if (gradeMatch.Value == "5")
                    {
                        grade5c++;
                    }
                    gradeTotal++;
                }
                barChart.Series[0].Points.AddXY(1, grade1c);
                barChart.Series[0].Points.AddXY(2, grade2c);
                barChart.Series[0].Points.AddXY(3, grade3c);
                barChart.Series[0].Points.AddXY(4, grade4c);
                barChart.Series[0].Points.AddXY(5, grade5c);

                grade5Count.Text = "Broj Odličnih (5): " + grade5c.ToString();
                grade4Count.Text = "Broj Vrlo Dobrih (4): " + grade4c.ToString();
                grade3Count.Text = "Broj Dobrih (3): " + grade3c.ToString();
                grade2Count.Text = "Broj Dovoljnih (2): " + grade2c.ToString();
                grade1Count.Text = "Broj Nedovoljnih (1): " + grade1c.ToString();
                grade5Perc.Text = "Postotak Odličnih (5): " + Decimal.Round(Decimal.Round((decimal)grade5c / gradeTotal, 4) * 100, 2).ToString() + "%";
                grade4Perc.Text = "Postotak Vrlo Dobrih (4): " + Decimal.Round(Decimal.Round((decimal)grade4c / gradeTotal, 4) * 100, 2).ToString() + "%";
                grade3Perc.Text = "Postotak Dobrih (3): " + Decimal.Round(Decimal.Round((decimal)grade3c / gradeTotal, 4) * 100, 2).ToString() + "%";
                grade2Perc.Text = "Postotak Dovoljnih (2): " + Decimal.Round(Decimal.Round((decimal)grade2c / gradeTotal, 4) * 100, 2).ToString() + "%";
                grade1Perc.Text = "Postotak Nedovoljnih (1): " + Decimal.Round(Decimal.Round((decimal)grade1c / gradeTotal, 4) * 100, 2).ToString() + "%";
                gradeCountLabel.Text = "Ukupan broj ocjena: " + gradeTotal.ToString();

                foreach (ListViewItem subject in sf.subjectList.Items)
                {
                    if (subject.Text == sf.allGradesListView.SelectedItems[0].Text)
                    {
                        averageLabel.Text = "Prosjek: " + subject.SubItems[1].Text;
                        finalLabel.Text = "Zaključna ocjena: " + subject.SubItems[2].Text;
                        break;
                    }
                }
                this.Opacity = 1;
            }
            else
            {
                MessageBox.Show("Nije moguće prikazati statistiku ocjena iz odabranog predmeta. Iz predmeta '" + sf.allGradesListView.SelectedItems[0].Text + "' još uvijek nemaš niti jednu ocjenu.", "Nije moguće prikazati statistiku", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }


    }
}
