using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary;

namespace Quadratic_equation
{
    public partial class QuadraticEquationForm : Form
    {
        public QuadraticEquationForm()
        {
            InitializeComponent();
        }

        private void Button_solve_Click(object sender, EventArgs e)
        {
            try
            {
                QuadraticEquation equation = new QuadraticEquation(textBox_a.Text, textBox_b.Text, textBox_c.Text);

                if (equation.IsXAnyNumber)
                {
                    label_answer.Text = "x - любое число.";
                }

                else if (equation.IsEquationWrong)
                {
                    label_answer.Text = equation.C + " = 0 - неверное равенство.";
                }

                else if (equation.IsXOne)
                {
                    label_answer.Text = "Корень равен " + equation.X1.ToString() + ".";
                }

                else if (equation.NoX)
                {
                    label_answer.Text = "Корней нет.";
                }

                else
                {
                    label_answer.Text = "1 корень равен " + equation.X1 + ". 2 корень равен " + equation.X2 + ".";
                }
            }

            catch (NotParsedException exc)
            {
                if (!exc.IsAParsed)
                {
                    textBox_a.BackColor = Color.LightPink;
                }

                if (!exc.IsBParsed)
                {
                    textBox_b.BackColor = Color.LightPink;
                }

                if (!exc.IsCParsed)
                {
                    textBox_c.BackColor = Color.LightPink;
                }
            }
        }

        private void QuadraticEquationForm_Load(object sender, EventArgs e)
        {
            //Значения коэффициентов по умолчанию.
            textBox_a.Text = "1";
            textBox_b.Text = "1";
            textBox_c.Text = "0";
        }

        /// <summary>
        /// Разрешение ввода лишь цифр, '-' в начале и 1 запятой после цифры.
        /// </summary>
        /// <param name="textBox">Обрабатываемый текстбокс.</param>
        /// <param name="e">Нажатая клавиша.</param>
        private void IsValidKey(TextBox textBox, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char charBeforeCursor; //Символ до курсора.

            try
            {
                charBeforeCursor = textBox.Text[textBox.SelectionStart - 1];
            }

            catch
            {
                charBeforeCursor = ' ';
            }

            //Игнорирование неподходящих символов при вводе коэффициентов.
            if (!Char.IsDigit(number))
            {
                //Разрешаем печатать '-' в начале.
                if (number == '-' && textBox.SelectionStart == 0)
                {

                }

                //Разрешаем печатать лишь 1 запятую и лишь после цифры.
                else if (number == ',' && (Char.IsDigit(charBeforeCursor) && !textBox.Text.Contains(',')))
                {

                }

                //Разрешаем пользоваться Backspace.
                else if (number == 8)
                {

                }

                //Игнорируем все непредусмотренные символы.
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void TextBox_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValidKey(textBox_a, e);
        }

        private void TextBox_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValidKey(textBox_b, e);
        }

        private void TextBox_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValidKey(textBox_c, e);
        }

        private void TextBox_a_Enter(object sender, EventArgs e)
        {
            textBox_a.BackColor = Color.White;
        }

        private void TextBox_b_Enter(object sender, EventArgs e)
        {
            textBox_b.BackColor = Color.White;
        }

        private void TextBox_c_Enter(object sender, EventArgs e)
        {
            textBox_c.BackColor = Color.White;
        }
    }
}
