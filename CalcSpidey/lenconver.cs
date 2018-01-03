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
   
    public partial class lenconver : Form
    {
        public lenconver()
        {
            InitializeComponent();
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void btnScientific_Click(object sender, EventArgs e)
        {
            ScientificCalc obj2 = new ScientificCalc();
            obj2.Show();
            this.Hide();
        }

        private void btnLngth_Click(object sender, EventArgs e)
        {

        }

        private void btnVol_Click(object sender, EventArgs e)
        {
            volconver obj3 = new volconver();
            obj3.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drpdwnlist1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.ForeColor = Color.Black;
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
          
        }
    }
}
