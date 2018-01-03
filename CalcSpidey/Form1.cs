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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String userInput = null; // to show as when a number is pressed
        bool opert = false; //to check whether the operator is selected or not
        int perform = 0; //which function is to performed

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnScientific_Click(object sender, EventArgs e)
        {
            ScientificCalc obj1 = new ScientificCalc();
            obj1.Show();
            this.Hide();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            userInput = userInput + "9";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            userInput = userInput + "8";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            userInput = userInput + "7";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            userInput = userInput + "6";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            userInput = userInput + "5";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            userInput = userInput + "4";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            userInput = userInput + "3";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            userInput = userInput + "2";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            userInput = userInput + "1";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btndeci_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            userInput = userInput + "0";
            if (lbloperation.Text == "Answer")
            {
                lbl2.Text = lbl1.Text;
            }
            lbl1.Text = userInput;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //this will assign null to all the labels and strings
            lbl1.Text = null;
            lbl2.Text = null;
            perform = 0;
            opert = false;
            userInput = null;
            lbloperation.Text = "OPERATION";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl1.Text))
            {
                opert = true;
                lbl2.Text = lbl1.Text;
                userInput = null;
                lbl1.Text = null;
                perform = 1;
                lbloperation.Text = "+";
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl1.Text))
            {
                opert = true;
                lbl2.Text = lbl1.Text;
                userInput = null;
                lbl1.Text = null;
                perform = 2; //2 is for subtraction
                lbloperation.Text = "-";
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl1.Text))
            {
                opert = true;
                lbl2.Text = lbl1.Text;
                userInput = null;
                lbl1.Text = null;
                perform = 3;   //3 is for multiplication
                lbloperation.Text = "*";
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl1.Text))
            {
                opert = true;
                lbl2.Text = lbl1.Text;
                userInput = null;
                lbl1.Text = null;
                perform = 4; // 4 is for division
                lbloperation.Text = "/";
            }
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            if (opert == true)
            {
                double num1 = Convert.ToDouble(lbl1.Text);
                double num2 = Convert.ToDouble(lbl2.Text);
                lbloperation.Text = "Answer";
                switch (perform)
                {
                    case 1:
                        lbl2.Text = null;    //1 is for addition
                        lbl1.Text = Convert.ToString(num1 + num2);
                        perform = 0;
                        userInput = null;
                        break;
                    case 2:
                        lbl2.Text = null;    //2 is for subtraction
                        lbl1.Text = Convert.ToString(num2 - num1);
                        userInput = null;
                        perform = 0;
                        break;
                    case 3:
                        lbl2.Text = null;
                        userInput = null; //3 is for multiply
                        lbl1.Text = Convert.ToString(num1 * num2);
                        perform = 0;
                        break;
                    case 4:
                        lbl2.Text = null;
                        userInput = null; //4 is for divide
                        lbl1.Text = Convert.ToString(num2 / num1);
                        perform = 0;
                        break;
                    case 5:
                        lbl2.Text = null;
                        userInput = null; //4 is for divide
                        lbl1.Text = Convert.ToString(num2 % num1);
                        perform = 0;
                        break;

                }

            }
            else
            {

                lbl1.Text = "Please choose a operator.";
            }


            //manually removing the operator
            opert = false;

        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl1.Text))
            {
                opert = true;
                lbl2.Text = lbl1.Text;
                userInput = null;
                lbl1.Text = null;
                perform = 5; // 5 is for mod
                lbloperation.Text = "%";
            }
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {

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
