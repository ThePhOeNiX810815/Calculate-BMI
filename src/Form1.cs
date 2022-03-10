using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculateBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            double selectedWeight_In_KG = (double)numericUpDown_Weight.Value;
            double selectedHeight_In_CM = (double)numericUpDown_Height.Value;
            double selectedHeight_In_M = selectedHeight_In_CM / 100;

            double calculatedBMI = selectedWeight_In_KG / (selectedHeight_In_M * selectedHeight_In_M);

            label_BMI_Result.Text = "Your BMI is " + Math.Round(calculatedBMI, 2);

            if (calculatedBMI <= 18.5)
            {
                label_Overall_Result.BackColor = Color.DeepSkyBlue;
                label_Overall_Result.Text = "You are UNDERWEIGHT";
            }
            else if (calculatedBMI <= 25)
            {
                label_Overall_Result.BackColor = Color.LimeGreen;
                label_Overall_Result.Text = "Your weight is NORMAL";
            }
            else if (calculatedBMI <= 30)
            {
                label_Overall_Result.BackColor = Color.Gold;
                label_Overall_Result.Text = "You are OVERWEIGHT";
            }
            else if (calculatedBMI > 30)
            {
                label_Overall_Result.BackColor = Color.Red;
                label_Overall_Result.Text = "You are OBESE";
            }
        }
    }
}
