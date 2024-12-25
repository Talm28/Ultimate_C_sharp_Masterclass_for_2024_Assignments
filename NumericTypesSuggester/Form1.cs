using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericTypesSuggester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!KeyValidate(e.KeyChar, textBox))
                e.Handled = true;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAnswer();
        }
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SetMaxValueTextBoxColor();
        }

        private bool KeyValidate(char key, TextBox textBox)
        {
            return char.IsDigit(key)
                || (key == '-' && textBox.SelectionStart == 0)
                || char.IsControl(key);
        }

        private void IntegralOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PreciseLabel.Visible = !PreciseLabel.Visible;
            PreciseCheckBox.Visible = !PreciseCheckBox.Visible;

            CalculateAnswer();
        }

        private void PreciseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAnswer();
        }


        private void SetMaxValueTextBoxColor()
        {

            MaxValueTextBox.BackColor = IsTextBoxValid() ? Color.White : Color.Red;
        }

        private bool IsTextBoxValid()
        {
            if(MinValueTextBox.Text.Count() > 0 && MinValueTextBox.Text != "-"
                && MaxValueTextBox.Text.Count() > 0 && MaxValueTextBox.Text != "-")
            {
                BigInteger min = BigInteger.Parse(MinValueTextBox.Text);
                BigInteger max = BigInteger.Parse(MaxValueTextBox.Text);

                 return min <= max;
            }

            return false;
        }

        private void CalculateAnswer()
        {
            string type = "";
            if (!IsTextBoxValid())
                type = "not enough data";
            else
            {
                BigInteger min = BigInteger.Parse(MinValueTextBox.Text);
                BigInteger max = BigInteger.Parse(MaxValueTextBox.Text);
                type = TypeSuggester.GetType(min, max, IntegralOnlyCheckBox.Checked, PreciseCheckBox.Checked);
            }
            SuggestedTypeLabel.Text = "Suggested type: " + type;
        }
    }
}
