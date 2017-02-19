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
            try
            {
                if (dataValidation())
                {
                    //calculate the answer
                    int num = Convert.ToInt32(txtNumber.Text); //num is the integer the user entered
                    long fac = 1; //starting number

                    for (int i = num; i > 0; i--)
                    {
                        fac = fac * i;//should be num* num-- etc until num=0

                    }

                    string factorial = String.Format("{0:n0}", fac);//convert fac to string with thousand separators
                    txtFactorial.Text = factorial;//display formatted string
                    btnAC.Focus(); //prepare for the user to click All Clear
                }
            }
            catch (FormatException) { MessageBox.Show("A format exception has occured.", "Format Exception"); }
            catch (Exception) { MessageBox.Show("An exception has occured.", "Exception"); }
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
        private bool dataValidation()
        {
            string n = "Number";
            return IsPresent(txtNumber, n) && IsNumber(txtNumber, n) && IsInRange(txtNumber, n, 1, 20);
        }
        public bool IsPresent(TextBox textBox, string name) //is there data in the text box?
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public bool IsNumber(TextBox textBox, string name) //is the data numeric?
        {
            decimal numdec = 0m;
            if (Decimal.TryParse(textBox.Text, out numdec))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        public bool IsInRange(TextBox textBox, string name, decimal min, decimal max) //is the number in the right range?
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

    }
}
