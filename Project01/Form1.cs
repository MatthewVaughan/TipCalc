using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Project01
// Date: 01/23/2015 12:30:27 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Project01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Vaughan\nCS1400\nProject01");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Tip Handler will take Meal Total and return tip plus the total bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtMealAmount_Leave(object sender, EventArgs e)
        {
            const double goodPercent = 0.20;
            const double avgPercent = 0.15;
            const double badPercent = 0.10;
            double mealAmount = double.Parse(txtMealAmount.Text);
            double goodTip = mealAmount * goodPercent;
            double avgTip = mealAmount * avgPercent;
            double badTip = mealAmount * badPercent;
            string goodBill = $"{mealAmount + goodTip:C}";
            string avgBill = $"{mealAmount + avgTip:C}";
            string badBill = $"{mealAmount + badTip:C}";
            txtExcellent.Text = goodBill;
            txtAverage.Text = avgBill;
            txtPoor.Text = badBill;
            txtExcellentTip.Text = $"+{goodTip:C}";
            txtAverageTip.Text = $"+{avgTip:C}";
            txtPoorTip.Text = $"+{badTip:C}";

        }
    }
}
