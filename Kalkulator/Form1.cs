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


        private void AllBtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ChangeEnabledBtn(true);
            dzielPrzezZero = false;
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
                            txtBoxEkranGlowny.Text = "0";
                        }
                    break;
                    }
                case "btnC":
                    {
                        operation = "";
                        txtBoxEkranMaly.ResetText();
                        txtBoxEkranGlowny.Text = "0";
                    }
                    break;
                case "btnCE":
                    {
                        txtBoxEkranGlowny.Text = "0";
                    }
                    break;
                case "btnPlusMinus":
                    {
                        if(!txtBoxEkranGlowny.Text.Contains("-"))
                        {
                            txtBoxEkranGlowny.Text = "-" + txtBoxEkranGlowny.Text;
                        }
                        else if(txtBoxEkranGlowny.Text.Contains("-"))
                        {
                            txtBoxEkranGlowny.Text = txtBoxEkranGlowny.Text.Substring(1, txtBoxEkranGlowny.Text.Length - 1);
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
                        if(operation == "=") //rozpoczecie nowego liczenia
                        {
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

        private void Operation_Click(Object Sender, EventArgs e)
        {
            Button opr = Sender as Button;
            switch (opr.Text)
            {
                case "+":
                    {
                            if (operation == "" || operation == "=")
                            {
                                operation = "+";
                                previousOperation = operation;
                                previousEquation = txtBoxEkranGlowny.Text;
                                txtBoxEkranMaly.Text = previousEquation + operation;
                                txtBoxEkranGlowny.Text = "0";
                            }
                            else
                            {
                                operation = "+";
                                multiEquations();
                                txtBoxEkranMaly.Text += txtBoxEkranGlowny.Text + operation;
                                txtBoxEkranGlowny.Text = "0";
                            } 
                        break;
                    }
                case "-":
                    {
                            if (operation == "" || operation == "=")
                            {
                                operation = "-";
                                previousOperation = operation;
                                previousEquation = txtBoxEkranGlowny.Text;
                                txtBoxEkranMaly.Text = previousEquation + operation;
                                txtBoxEkranGlowny.Text = "0";
                            }
                            else
                            {
                                operation = "-";
                                multiEquations();
                                txtBoxEkranMaly.Text += txtBoxEkranGlowny.Text + operation;
                                txtBoxEkranGlowny.Text = "0";
                            }
                    }
                    break;

                case "x":
                    {
                            if (operation == "" || operation == "=")
                            {
                                operation = "x";
                                previousOperation = operation;
                                previousEquation = txtBoxEkranGlowny.Text;
                                txtBoxEkranMaly.Text = previousEquation + operation;
                                txtBoxEkranGlowny.Text = "0";
                            }
                            else
                            {
                                operation = "x";
                                multiEquations();
                                txtBoxEkranMaly.Text += txtBoxEkranGlowny.Text + operation;
                                txtBoxEkranGlowny.Text = "0";
                            }
                        break;
                    }

                case "/":
                    {
                            if (operation == "" || operation == "=")
                            {
                                operation = "/";
                                previousOperation = operation;
                                previousEquation = txtBoxEkranGlowny.Text;
                                txtBoxEkranMaly.Text = previousEquation + operation;
                                txtBoxEkranGlowny.Text = "0";
                            }
                            else
                            {
                                operation = "/";
                                multiEquations();
                                txtBoxEkranMaly.Text += txtBoxEkranGlowny.Text + operation;
                                txtBoxEkranGlowny.Text = "0";
                            }
                    }
                    break;

                case "=":
                    {
                            operation = "=";
                            multiEquations();
                            txtBoxEkranMaly.ResetText();
                            if (!dzielPrzezZero)
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
                        break;
                    }
            }
        }

        private void multiEquations()
        {
            if (previousOperation == "+")
            {
                previousOperation = operation;

                answer = Convert.ToDouble(previousEquation) + Convert.ToDouble(txtBoxEkranGlowny.Text);

                previousEquation = answer.ToString();
            }
            else if (previousOperation == "-")
            {
                previousOperation = operation;

                answer = Convert.ToDouble(previousEquation) - Convert.ToDouble(txtBoxEkranGlowny.Text);

                previousEquation = answer.ToString();
            }
            else if (previousOperation == @"/")
            {
                previousOperation = operation;

                if(txtBoxEkranGlowny.Text == "0")
                {
                    dzielPrzezZero = true;
                }
                else
                {
                    answer = Convert.ToDouble(previousEquation) / Convert.ToDouble(txtBoxEkranGlowny.Text);

                    previousEquation = answer.ToString();
                }
            }
            else if (previousOperation == "x")
            {
                previousOperation = operation;

                answer = Convert.ToDouble(previousEquation) * Convert.ToDouble(txtBoxEkranGlowny.Text);

                previousEquation = answer.ToString();
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
    }
}
