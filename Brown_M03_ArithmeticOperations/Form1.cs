/** =========================================================

 Wes Brown
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 ArithmeticOperations
 Program Description: Display the use of the different numeric operations.
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brown_M03_ArithmeticOperations
{
    public partial class ArithmeticOperations : Form
    {
        public ArithmeticOperations()
        {
            InitializeComponent();
        }

        private void showAnswers_button_Click(object sender, EventArgs e)
        {
            int additionResult = 4 + 5;
            additionResult_label.Text = additionResult.ToString();

            int subtractionResult = 10 - 4;
            subtractResult_label.Text = subtractionResult.ToString();

            int multipleResult = 8 * 4;
            multiplyResult_label.Text = multipleResult.ToString();

            int divideResult = 15 / 3;
            divideResult_label.Text = divideResult.ToString();

            int modulusResult = 23 % 3;
            modulusResult_label.Text = modulusResult.ToString();

            int incrementResult = 1;
            incrementResult++;
            incrementResult_label.Text = incrementResult.ToString();

            int decrementResult = 5;
            decrementResult--;
            decrementResult_label.Text = decrementResult.ToString();

        }

        private void clearAnswers_button_Click(object sender, EventArgs e)
        {
            additionResult_label.Text = "";
            subtractResult_label.Text = "";
            multiplyResult_label.Text = "";
            divideResult_label.Text = "";
            modulusResult_label.Text = "";
            incrementResult_label.Text = "";
            decrementResult_label.Text = "";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
