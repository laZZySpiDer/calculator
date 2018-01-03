using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcSpidey
{
    public partial class ScientificCalc : Form
    {
        public ScientificCalc()
        {
            InitializeComponent();
        }
        String userInput = null; // to show as when a number is pressed
        bool opert = false; //to check whether the operator is selected or not
        int perform = 0; //which function is to performed
        private void btn9_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "9";
                lbl1.Text = userInput;
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "8";
                lbl1.Text = userInput;
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "7";
                lbl1.Text = userInput;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "6";
                lbl1.Text = userInput;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "5";
                lbl1.Text = userInput;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "4";
                lbl1.Text = userInput;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "3";
                lbl1.Text = userInput;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "2";
                lbl1.Text = userInput;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "1";
                lbl1.Text = userInput;
            }
        }

        private void btndeci_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (opert == false && string.IsNullOrEmpty(lblAnswer.Text))
            {
                userInput = userInput + "0";
                lbl1.Text = userInput;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            userInput = null;
            perform = 0;
            opert = false;
            lbl1.Text = null;
            lblAnswer.Text = null;
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            if (opert == true)
            {
                double num1 = Convert.ToDouble(userInput);
                switch (perform)
                {
                    case 1: //performing sin function
                        lbl1.Text = Convert.ToString(Math.Sin(num1));
                        userInput = lbl1.Text;
                        lblAnswer.Text = "Answer";
                        opert = false;
                        perform = 0;
                        break;
                    case 2: //performing cos function
                        lbl1.Text = Convert.ToString(Math.Cos(num1));
                        userInput = lbl1.Text;
                        lblAnswer.Text = "Answer";
                        opert = false;
                        perform = 0;
                        break;
                    case 3: //performing tan function
                        lbl1.Text = Convert.ToString(Math.Tan(num1));
                        userInput = lbl1.Text;
                        lblAnswer.Text = "Answer";
                        opert = false;
                        perform = 0;
                        break;
                    case 4: //performing square root function
                        lbl1.Text = Convert.ToString(Math.Sqrt(num1));
                        userInput = lbl1.Text;
                        lblAnswer.Text = "Answer";
                        opert = false;
                        perform = 0;
                        break;
                    case 5: //performing log function
                        lbl1.Text = Convert.ToString(Math.Log10(num1));
                        userInput = lbl1.Text;
                        lblAnswer.Text = "Answer";
                        opert = false;
                        perform = 0;
                        break;
                    case 6: //performing sin function
                        lbl1.Text = Convert.ToString(Math.Sinh(num1));
                        userInput = lbl1.Text;
                        lblAnswer.Text = "Answer";
                        opert = false;
                        perform = 0;
                        break;
                    case 7: //performing sin function
                        lbl1.Text = Convert.ToString(Math.Cosh(num1));
                        userInput = lbl1.Text;
                        lblAnswer.Text = "Answer";
                        opert = false;
                        perform = 0;
                        break;
                    case 8: //performing sin function
                        lbl1.Text = Convert.ToString(Math.Tanh(num1));
                        userInput = lbl1.Text;
                        lblAnswer.Text = "Answer";
                        opert = false;
                        perform = 0;
                        break;
                    case 9: //performing sin function
                        lbl1.Text = Convert.ToString(Math.Asin(num1));
                        userInput = lbl1.Text;
                        lblAnswer.Text = "Answer";
                        opert = false;
                        perform = 0;
                        break;
                }
            }
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                lbl1.Text = "Please enter any number";
            }
            else
            {
                lbl1.Text = "sqrt(" + userInput + ")";
                opert = true;
                perform = 4;
            }
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                lbl1.Text = "Please enter any number";
            }
            else
            {
                lbl1.Text = "tan(" + userInput + ")";
                opert = true;
                perform = 3;
            }
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                lbl1.Text = "Please enter any number";
            }
            else
            {
                lbl1.Text = "cos(" + userInput + ")";
                opert = true;
                perform = 2;
            }
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                lbl1.Text = "Please enter any number";
            }
            else
            {
                lbl1.Text = "sin(" + userInput + ")";
                opert = true;
                perform = 1;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnScientific_Click(object sender, EventArgs e)
        {

        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                lbl1.Text = "Please enter any number";
            }
            else
            {
                lbl1.Text = "log(" + userInput + ")";
                opert = true;
                perform = 5;
            }
        }
        private void btnsinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                lbl1.Text = "Please enter any number";
            }
            else
            {
                lbl1.Text = "sinh(" + userInput + ")";
                opert = true;
                perform = 6;
            }
        }
        private void btncosh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                lbl1.Text = "Please enter any number";
            }
            else
            {
                lbl1.Text = "cosh(" + userInput + ")";
                opert = true;
                perform = 7;
            }
        }
        private void btntanh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                lbl1.Text = "Please enter any number";
            }
            else
            {
                lbl1.Text = "tanh(" + userInput + ")";
                opert = true;
                perform = 8;
            }
        }

        private void Asin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                lbl1.Text = "Please enter any number";
            }
            else
            {
                lbl1.Text = "Asin(" + userInput + ")";
                opert = true;
                perform = 9;
            }
        }

        private void btnLngth_Click(object sender, EventArgs e)
        {
            lenconver obj2 = new lenconver();
            obj2.Show();
            this.Hide();
        }

        private void btnVol_Click(object sender, EventArgs e)
        {
            volconver obj3 = new volconver();
            obj3.Show();
            this.Hide();
        }
    }
}
