using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class BMICalculator : Form
    {
        public decimal Bmi;
        public BMICalculator()
        {
            InitializeComponent();
        }

        public void multilineoutput(decimal calculatedbmi)
        {
            decimal result = calculatedbmi;
            if (Bmi < (decimal)18.50)
            {
                multilinetextbox.Text = "Result: According to BMI, you are underweight. ";
            }
            else if (Bmi >= (decimal)18.50 && Bmi <= (decimal)24.9)
            {
                multilinetextbox.Text = "Result: According to BMI, you are normal. ";
            }
            else if (Bmi >= 25 && Bmi <= (decimal)29.9)
            {
                multilinetextbox.Text = "Result: According to BMI, you are overweight. ";
            }
            else if (Bmi >= 30)
            {
                multilinetextbox.Text = "Result: According to BMI, you are obese. ";
            }
        }
        private void calculatebutton_Click(object sender, EventArgs e)
        {
            decimal wt = weight.Value;
            decimal ht = height.Value;
            if (metricradiobutton.Checked)
            {
                Bmi = wt / ((ht/100) * (ht/100));
                calculatedbmi.Text = "Your BMI is " + Bmi.ToString("N2");
                multilineoutput(Bmi);
            }

            if (imperialradiobutton.Checked)
            {
                Bmi = (wt *703)/ (ht * ht);
                calculatedbmi.Text = "Your BMI is " + Bmi.ToString("N2");
                multilineoutput(Bmi);
            }
        }

        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
