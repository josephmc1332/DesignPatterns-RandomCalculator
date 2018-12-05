using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCustomer
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        #region Operator Methods
        private void Divide_Click(object sender, EventArgs e)
        {
            InputText("/");
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            InputText("*");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            InputText("-");
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            InputText("+");
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            Result.Text = ParseOperation();
            FocusUserText();
        }
        #endregion
        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEbutton_Click(object sender, EventArgs e)
        {
            this.UserInput.Text = string.Empty;
            FocusUserText();
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            DeleteText();

            FocusUserText();
        }
        #endregion
        #region Numbers
        private void Press0_Click(object sender, EventArgs e)
        {
            InputText("0");
        }

        private void Press1_Click(object sender, EventArgs e)
        {
            InputText("1");
        }

        private void Press2_Click(object sender, EventArgs e)
        {
            InputText("2");
        }

        private void Press3_Click(object sender, EventArgs e)
        {
            InputText("3");
        }

        private void Press4_Click(object sender, EventArgs e)
        {
            InputText("4");
        }

        private void Press5_Click(object sender, EventArgs e)
        {
            InputText("5");
        }

        private void Press6_Click(object sender, EventArgs e)
        {
            InputText("6");
        }

        private void Press7_Click(object sender, EventArgs e)
        {
            InputText("7");
        }

        private void Press8_Click(object sender, EventArgs e)
        {
            InputText("8");
        }

        private void Press9_Click(object sender, EventArgs e)
        {
            InputText("9");
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            InputText(".");
        }
        #endregion
        private void FocusUserText()
        {
            this.UserInput.Focus();
        }
        private void InputText(string value)
        {
            var selectionStart = this.UserInput.SelectionStart;

            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.SelectionStart, value);

            this.UserInput.SelectionStart = selectionStart + value.Length;

            this.UserInput.SelectionLength = 0;
        }
        private void DeleteText()
        {
            if (UserInput.Text.Length < UserInput.SelectionStart + 1)
                return;

            var selectionStart = this.UserInput.SelectionStart;

            this.UserInput.Text = this.UserInput.Text.Remove(this.UserInput.SelectionStart, 1);

            UserInput.SelectionStart = selectionStart;

            UserInput.SelectionLength = 0;
        }
        
        private string ParseOperation()
        {
            try
            {
                var operation = new Operation();
                var input = UserInput.Text;
                input = UserInput.Text.Replace(" ", "");
                var leftSide = true;
                for (int i = 0; i < input.Length; i++)
                {
                    if ($"0123456789.".Any(c => input[i] == c))
                    {
                        if(leftSide)
                        operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                        operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    else if ($"+-*/".Any(c => input[i] == c))
                    {
                       if(!leftSide)
                        {
                            var operatorType = GetOperationType(input[i]);
                        }
                    }
                }
                return string.Empty;

            }
            catch(Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            if(newCharacter == '.' && currentNumber.Contains("."))
            {
                throw new InvalidOperationException($"{currentNumber} already contains a . and cannot use another");
            }
            return currentNumber + newCharacter;
        }
        private OperationType GetOperationType(char newCharacter)
        {
            switch(newCharacter)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"{newCharacter} is not a valid operator");
            }
        }
    }
}
