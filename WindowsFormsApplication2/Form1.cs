using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region ClearMethod
        private void btnCE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }
        private void btnCE_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Yo");
        }
        /// <summary>
        /// Clear the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnC_Click(object sender, EventArgs e)
        {
            this.userInput.Text = string.Empty;
            FocusInputText();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region NumberMethod
        private void btn7_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
        }
        #endregion

        #region OperationMethod
        private void btnMul_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }
        
        private void BtnDot_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
        }
        #endregion

        private void CalculateEquation()
        {
            throw new NotImplementedException();
        }

        #region Private Helpers
        private void FocusInputText()
        {
            this.userInput.Focus();
        }
        /// <summary>
        /// Insert the user input into the user input rext box
        /// </summary>
        /// <param name="value"></param>
        private void InsertTextValue(string value)
        {
            this.userInput.Text = this.userInput.Text.Insert(this.userInput.SelectionStart, value);
        }
        #endregion

    }
}
