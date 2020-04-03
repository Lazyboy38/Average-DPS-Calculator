using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace Average_DPS_Calculator
{
    public partial class Form1 : Form
    {
        public string language = Properties.Settings.Default.language;
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            InitializeComponent();
            lbWeapon1.Text = "0 TtlDmg/s";
            lbWeapon2.Text = "0 TtlDmg/s";
            radioDPS.Checked = true;
            radioDPS2.Checked = true;
            CheckRadio();
        }

        #region variables
        string inDMG;
        string inROF;
        string inMAG;
        string inRLD;
        string inDMG2;
        string inROF2;
        string inMAG2;
        string inRLD2;
        #endregion

        #region funtions

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (radioDPS.Checked)
            {
                inDMG = inputDMG.Text;
                inROF = inputROF.Text;
                try
                {
                    double dbDMG = double.Parse(inDMG);
                    double dbROF = double.Parse(inROF);
                    double result = CalcDPS(dbDMG, dbROF);
                    lbWeapon1.Text = result.ToString() + " TtlDmg/s";
                }
                catch
                {
                    MessageBox.Show("You didn't input all necessary information, or they were not a number!",
                                    "Error trying to Calculate Weapon 1",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (radioADPS.Checked)
            {
                inDMG = inputDMG.Text;
                inROF = inputROF.Text;
                inMAG = inputMAG.Text;
                inRLD = inputRLD.Text;
                try
                {
                    double dbDMG = double.Parse(inDMG);
                    double dbROF = double.Parse(inROF);
                    int dbMAG = Int32.Parse(inMAG);
                    double dbRLD = double.Parse(inRLD);
                    double result = CalcAvgDPS(dbDMG, dbROF, dbMAG, dbRLD);
                    lbWeapon1.Text = result.ToString() + " AvgDmg/s";
                }
                catch
                {
                    MessageBox.Show("One or more inputs are not a Number",
                                    "Error trying to Calculate Weapon 1",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You didnt check what calculation you want to do!",
                                "Error: Unchecked Radio Button!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnCalc2_Click(object sender, EventArgs e)
        {
            if (radioDPS2.Checked)
            {
                inDMG = inputDMG2.Text;
                inROF = inputROF2.Text;
                try
                {
                    double dbDMG = double.Parse(inDMG);
                    double dbROF = double.Parse(inROF);
                    double result = CalcDPS(dbDMG, dbROF);
                    lbWeapon2.Text = result.ToString() + "TtlDmg/s";
                }
                catch
                {
                    MessageBox.Show("Either your input of Damage or Rate of Fire are not a Number",
                                    "Error trying to Calculate Weapon 2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (radioADPS2.Checked)
            {
                inDMG = inputDMG2.Text;
                inROF = inputROF2.Text;
                inMAG = inputMAG2.Text;
                inRLD = inputRLD2.Text;
                try
                {
                    double dbDMG = double.Parse(inDMG);
                    double dbROF = double.Parse(inROF);
                    int dbMAG = Int32.Parse(inMAG);
                    double dbRLD = double.Parse(inRLD);
                    double result = CalcAvgDPS(dbDMG, dbROF, dbMAG, dbRLD);
                    lbWeapon2.Text = result.ToString() + " AvgDmg/s";
                }
                catch
                {
                    MessageBox.Show("One or more inputs are not a Number",
                                    "Error trying to Calculate Weapon 2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You didnt check what calculation you want to do!",
                                "Error: Unchecked Radio Button!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnCalcBoth_Click(object sender, EventArgs e)
        {
            if (radioComAvg.Checked)
            {
                inDMG = inputDMG.Text;
                inROF = inputROF.Text;
                inMAG = inputMAG.Text;
                inRLD = inputRLD.Text;
                inDMG2 = inputDMG2.Text;
                inROF2 = inputROF2.Text;
                inMAG2 = inputMAG2.Text;
                inRLD2 = inputRLD2.Text;
                try
                {
                    double dbDMG1 = double.Parse(inDMG);
                    double dbROF1 = double.Parse(inROF);
                    int dbMAG1 = Int32.Parse(inMAG);
                    double dbRLD1 = double.Parse(inRLD);

                    double dbDMG2 = double.Parse(inDMG2);
                    double dbROF2 = double.Parse(inROF2);
                    int dbMAG2 = Int32.Parse(inMAG2);
                    double dbRLD2 = double.Parse(inRLD2);

                    double resultWeapon1 = CalcAvgDPS(dbDMG1, dbROF1, dbMAG1, dbRLD1);
                    double resultWeapon2 = CalcAvgDPS(dbDMG2, dbROF2, dbMAG2, dbRLD2);

                    lbWeapon1.Text = resultWeapon1.ToString() + " AvgDps/s";
                    lbWeapon2.Text = resultWeapon2.ToString() + " AvgDps/s";

                    int caseSwitch = Compare(resultWeapon1, resultWeapon2);
                    switch (caseSwitch)
                    {
                        case 1:
                            lbWeapon1.BackColor = Color.LimeGreen;
                            lbWeapon2.BackColor = Color.Red;
                            MessageBox.Show(
                            "Weapon 1 has a higher average damage!",
                            "Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                            break;
                        case 2:
                            lbWeapon2.BackColor = Color.LimeGreen;
                            lbWeapon1.BackColor = Color.Red;
                            MessageBox.Show(
                            "Weapon 2 has a higher average damage!",
                            "Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                            break;
                        default:
                            MessageBox.Show(
                            "No weapon has a higher damage. No idea how you got so lucky! ... Unless it was intended.",
                            "Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                            break;
                    }
                    radioComAvg.Checked = false;
                    ClearAll();
                    CheckRadio();
                }
                catch
                {
                    MessageBox.Show("Something went wrong, are all inputs a Number?",
                                    "Error: could not calculate",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (radioComTtl.Checked)
            {
                inDMG = inputDMG.Text;
                inROF = inputROF.Text;
                inDMG2 = inputDMG2.Text;
                inROF2 = inputROF2.Text;
                try
                {
                    double dbDMG1 = double.Parse(inDMG);
                    double dbROF1 = double.Parse(inROF);

                    double dbDMG2 = double.Parse(inDMG2);
                    double dbROF2 = double.Parse(inROF2);

                    double resultWeapon1 = CalcDPS(dbDMG1, dbROF1);
                    double resultWeapon2 = CalcDPS(dbDMG2, dbROF2);

                    lbWeapon1.Text = resultWeapon1.ToString() + " TtlDmg/s";
                    lbWeapon2.Text = resultWeapon2.ToString() + " TtlDmg/s";

                    int caseSwitch = Compare(resultWeapon1, resultWeapon2);
                    switch (caseSwitch)
                    {
                        case 1:
                            lbWeapon1.BackColor = Color.LimeGreen;
                            lbWeapon2.BackColor = Color.Red;
                            MessageBox.Show(
                            "Weapon 1 has a higher total damage!",
                            "Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                            break;
                        case 2:
                            lbWeapon2.BackColor = Color.LimeGreen;
                            lbWeapon1.BackColor = Color.Red;
                            MessageBox.Show(
                            "Weapon 2 has a higher total damage!",
                            "Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                            break;
                        default:
                            MessageBox.Show(
                            "No weapon has a higher damage. No idea how you got so lucky! ... Unless it was intended.",
                            "Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Either your input of Damage or Rate of Fire are not a Number",
                                    "Error trying to Calculate Weapon 2",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                ClearAll();
                CheckRadio();
            }
            else
            {
                MessageBox.Show("You didnt check what calculation you want to do!",
                                "Error: Unchecked Radio Button!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();  
        }

        private void BtnClearW1_Click(object sender, EventArgs e)
        {
            lbWeapon1.Text = "0 TtlDmg/s";
            inputDMG.Text = "";
            inputROF.Text = "";
            inputMAG.Text = "";
            inputRLD.Text = "";
            lbWeapon1.BackColor = Color.White;
        }

        private void BtnClearW2_Click(object sender, EventArgs e)
        {
            lbWeapon2.Text = "0 TtlDmg/s";
            inputDMG2.Text = "";
            inputROF2.Text = "";
            inputMAG2.Text = "";
            inputRLD2.Text = "";
            lbWeapon2.BackColor = Color.White;
        }

        private void RadioDPS_CheckedChanged(object sender, EventArgs e)
        {
            inputMAG.Enabled = false;
            inputRLD.Enabled = false;
        }

        private void RadioADPS_CheckedChanged(object sender, EventArgs e)
        {
            inputMAG.Enabled = true;
            inputRLD.Enabled = true;
        }

        private void RadioDPS2_CheckedChanged(object sender, EventArgs e)
        {
            inputMAG2.Enabled = false;
            inputRLD2.Enabled = false;
        }

        private void RadioADPS2_CheckedChanged(object sender, EventArgs e)
        {
            inputMAG2.Enabled = true;
            inputRLD2.Enabled = true;
        }

        private void RadioComAvg_CheckedChanged(object sender, EventArgs e)
        {
            inputMAG.Enabled = true;
            inputMAG2.Enabled = true;
            inputRLD.Enabled = true;
            inputRLD2.Enabled = true;
        }

        private void RadioComTtl_CheckedChanged(object sender, EventArgs e)
        {
            inputMAG.Enabled = false;
            inputMAG2.Enabled = false;
            inputRLD.Enabled = false;
            inputRLD2.Enabled = false;
        }

        public double CalcAvgDPS(double Dmg, double RoF, int Mag, double Rld)
        {
            try
            {
                double numerator = Dmg * RoF * Mag;
                double denominator = Rld * RoF + Mag;
                double resultUnround = numerator / denominator;
                double result = Math.Round(resultUnround, 3);
                return result;
            }
            catch
            {
                MessageBox.Show("Something went wrong, are all inputs a Number?", "Error: could not calculate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public double CalcDPS(double Dmg, double RoF)
        {
            try
            {
                double resultUnround = Dmg * RoF;
                double result = Math.Round(resultUnround, 3);
                return result;
            }
            catch
            {
                MessageBox.Show("Something went wrong, are all inputs a Number?", "Error: could not calculate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int Compare(double w1, double w2)
        {
            if (w1 > w2)
            {
                return 1;
            }
            else if (w2 > w1)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public void CheckRadio()
        {
            if (radioDPS.Checked)
            {
                inputMAG.Enabled = false;
                inputRLD.Enabled = false;
            }
            else
            {
                inputMAG.Enabled = true;
                inputRLD.Enabled = true;
            }
            if (radioDPS2.Checked)
            {
                inputMAG2.Enabled = false;
                inputRLD2.Enabled = false;
            }
            else
            {
                inputMAG2.Enabled = true;
                inputRLD2.Enabled = true;
            }
            if (radioComAvg.Checked)
            {
                inputMAG.Enabled = true;
                inputRLD.Enabled = true;
                inputMAG2.Enabled = true;
                inputRLD2.Enabled = true;
            }
            else
            {
                inputMAG.Enabled = false;
                inputRLD.Enabled = false;
                inputMAG2.Enabled = false;
                inputRLD2.Enabled = false;
            }
        }

        public void ClearAll()
        {
            lbWeapon1.Text = "0 TtlDmg/s";
            lbWeapon2.Text = "0 TtlDmg/s";
            inputDMG.Text = "";
            inputROF.Text = "";
            inputMAG.Text = "";
            inputRLD.Text = "";
            inputDMG2.Text = "";
            inputROF2.Text = "";
            inputMAG2.Text = "";
            inputRLD2.Text = "";
            lbWeapon1.BackColor = Color.White;
            lbWeapon2.BackColor = Color.White;
            radioComTtl.Checked = false;
            radioComAvg.Checked = false;
            CheckRadio();
        }

        /*private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }*/

        #endregion

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = "en-US";
            englishToolStripMenuItem.Checked = true;
            deutschToolStripMenuItem.Checked = false;

            Properties.Settings.Default.language = "en-US";
            Properties.Settings.Default.Save();

            DialogResult result = MessageBox.Show("You need to restart the application for the languagechange to take effect! Do you want to restart now?",
                                                  "Change Language",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            language = "de-DE";
            englishToolStripMenuItem.Checked = false;
            deutschToolStripMenuItem.Checked = true;

            Properties.Settings.Default.language = "de-DE";
            Properties.Settings.Default.Save();

            DialogResult result = MessageBox.Show("Das Programm muss neu gestartet werden damit die Sprache geändert wird! Möchtest du das Programm jetzt neustarten?",
                                                  "Sprache ändern",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
