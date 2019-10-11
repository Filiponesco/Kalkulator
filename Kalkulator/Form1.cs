using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int maxLength = 15;

        public static string previousEquation = "", previousOperation = "", operation = "";

        public static double answer = 0;

        public Boolean dzielPrzezZero = false;
        public Boolean moduloPrzezZero = false;
        public Boolean wrongSqrt = false;


        private void AllBtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ChangeEnabledBtn(true);
            dzielPrzezZero = false;
            moduloPrzezZero = false;
            switch (btn.Name)
            {
                case "btnDelete":
                    {
                        if(txtBoxEkranGlowny.TextLength > 1)
                        {
                            txtBoxEkranGlowny.Text = txtBoxEkranGlowny.Text.Substring(0, txtBoxEkranGlowny.Text.Length - 1);
                        }
                        else
                        {
                            ResetMainDisplay();
                        }
                    break;
                    }
                case "btnC":
                    {
                        operation = "";
                        txtBoxEkranMaly.ResetText();
                        ResetMainDisplay();
                    }
                    break;
                case "btnCE":
                    {
                        ResetMainDisplay();
                    }
                    break;
                case "btnPlusMinus":
                    {
                        if (txtBoxEkranGlowny.Text != "0")
                        {
                            if (!txtBoxEkranGlowny.Text.Contains("-"))
                            {
                                txtBoxEkranGlowny.Text = "-" + txtBoxEkranGlowny.Text;
                            }
                            else if (txtBoxEkranGlowny.Text.Contains("-"))
                            {
                                txtBoxEkranGlowny.Text = txtBoxEkranGlowny.Text.Substring(1, txtBoxEkranGlowny.Text.Length - 1);
                            }
                        }
                        break;
                    }
                case "btnPierwiastek":
                    {
                        if (Double.Parse(txtBoxEkranGlowny.Text) > 0)
                        {
                                double wynik = Double.Parse(txtBoxEkranGlowny.Text);
                                wynik = Math.Sqrt(wynik);
                                txtBoxEkranGlowny.Text = wynik.ToString();
                        }
                        else
                        {
                            wrongSqrt = true;
                            txtBoxEkranGlowny.Text = "Błędne dane";
                            ChangeEnabledBtn(false);
                        }
                        break;
                    }
                case "btnKwadrat":
                    {
                        if (txtBoxEkranGlowny.Text != "0")
                        {
                            double wynik = Double.Parse(txtBoxEkranGlowny.Text);
                            wynik = Math.Pow(wynik,2);
                            txtBoxEkranGlowny.Text = wynik.ToString();
                        }
                        break;
                    }
                case "btnPrzecinek":
                    {
                        if(!txtBoxEkranGlowny.Text.Contains(","))
                        {
                            txtBoxEkranGlowny.Text += ",";
                        }
                        break;
                    }
                default:
                    {
                        if(operation == "=" || wrongSqrt) //rozpoczecie nowego liczenia
                        {
                            wrongSqrt = false;
                            operation = "";
                            txtBoxEkranGlowny.Text = btn.Text;
                        }
                        else if(txtBoxEkranGlowny.Text == "0")
                        {
                            txtBoxEkranGlowny.Text = btn.Text;
                        }
                        else if(!IsMaxLength(txtBoxEkranGlowny.Text))
                        {
                            txtBoxEkranGlowny.Text += btn.Text;
                        }
                    }
                    break;
            }
        }
        private void SaveOperation(string znak)
        {
            if (operation == "" || operation == "=")
            {
                operation = znak;
                previousOperation = operation;
                previousEquation = txtBoxEkranGlowny.Text;
                txtBoxEkranMaly.Text = previousEquation + operation;
                ResetMainDisplay();
            }
            else
            {
                operation = znak;
                multiEquations();
                txtBoxEkranMaly.Text += txtBoxEkranGlowny.Text + operation;
                ResetMainDisplay();
            }
        }
        private void Operation_Click(Object Sender, EventArgs e)
        {
            Button opr = Sender as Button;
            switch (opr.Text)
            {
                default:
                    {
                        SaveOperation(opr.Text);          
                    }
                    break;
                case "=":
                    {
                            operation = "=";
                            multiEquations();
                            txtBoxEkranMaly.ResetText();
                            if (!dzielPrzezZero && !moduloPrzezZero && !wrongSqrt)
                            {
                                if(!IsMaxLength(answer.ToString()))
                                {
                                    txtBoxEkranGlowny.Text = answer.ToString();
                                }
                                else
                                {
                                     txtBoxEkranGlowny.Text = "Przepełnienie";
                                     ChangeEnabledBtn(false);
                                }
                            }
                            if(dzielPrzezZero)
                            {
                                txtBoxEkranGlowny.Text = "Nie dziel przez 0";
                                ChangeEnabledBtn(false);
                            }
                        if (moduloPrzezZero)
                        {
                            txtBoxEkranGlowny.Text = "Nie moduluj przez 0";
                            ChangeEnabledBtn(false);
                        }
                        break;
                    }
            }
        }
        private void multiEquations()
        {
            switch (previousOperation)
            {
                case "+":
                    {
                        previousOperation = operation;
                        answer = Convert.ToDouble(previousEquation) + Convert.ToDouble(txtBoxEkranGlowny.Text);
                        previousEquation = answer.ToString();
                    }
                    break;
                case "-":
                    {
                        previousOperation = operation;
                        answer = Convert.ToDouble(previousEquation) - Convert.ToDouble(txtBoxEkranGlowny.Text);
                        previousEquation = answer.ToString();
                    }
                    break;
                case "x":
                    {
                        previousOperation = operation;
                        answer = Convert.ToDouble(previousEquation) * Convert.ToDouble(txtBoxEkranGlowny.Text);
                        previousEquation = answer.ToString();
                    }
                    break;
                case @"/":
                    {
                        previousOperation = operation;

                        if (Double.Parse(txtBoxEkranGlowny.Text) == 0)
                        {
                            dzielPrzezZero = true;
                        }
                        else
                        {
                            answer = Convert.ToDouble(previousEquation) / Convert.ToDouble(txtBoxEkranGlowny.Text);

                            previousEquation = answer.ToString();
                        }
                    }
                    break;
                case "Mod":
                    {
                        previousOperation = operation;

                        if (Double.Parse(txtBoxEkranGlowny.Text) == 0)
                        {
                            moduloPrzezZero = true;
                        }
                        else
                        {
                            answer = Convert.ToDouble(previousEquation) % Convert.ToDouble(txtBoxEkranGlowny.Text);

                            previousEquation = answer.ToString();
                        }
                    }
                    break;
            }
        }
        private void ChangeEnabledBtn(Boolean b)
        {
            btnDziel.Enabled = b;
            btnRazy.Enabled = b;
            btnMinus.Enabled = b;
            btnPlus.Enabled = b;
            btnPrzecinek.Enabled = b;
            btnPlusMinus.Enabled = b;
            btnDelete.Enabled = b;
            btnPierwiastek.Enabled = b;
            btnModulo.Enabled = b;
            btnKwadrat.Enabled = b;
        }
        private bool IsMaxLength(String s)
        {
            if (s.Length >= maxLength)
            {
                return true;
            }
            else
                return false;
        }
        private void ResetMainDisplay()
        {
            txtBoxEkranGlowny.Text = "0";
        }
    }
}
