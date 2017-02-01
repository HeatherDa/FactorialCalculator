using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculate the answer
            int num = Convert.ToInt32(txtNumber.Text); //num is the integer the user entered
            long fac = 1; //starting number
                         
            for(int i=num; i>0;i--){
                fac = fac * i;//should be num* num-- etc until num=0

            }

            string factorial = String.Format("{0:n0}", fac);//convert fac to string with thousand separators
            txtFactorial.Text = factorial;//display formatted string
            btnAC.Focus(); //prepare for the user to click All Clear
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            //Clear text boxes
            txtNumber.Text = "";
            txtFactorial.Text = "";
            txtNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit program
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
