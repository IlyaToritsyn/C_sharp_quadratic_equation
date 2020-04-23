using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Quadratic_equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Проверка числа на валидность.
        /// </summary>
        /// <param name="textBox">Обрабатываемый текстбокс.</param>
        /// <param name="coefficient">Коэффициент из текстбокса.</param>
        /// <returns>true - валидно, false - невалидно</returns>
        private bool IsValidNumber(TextBox textBox, ref double coefficient)
        {
            try
            {
                coefficient = Convert.ToDouble(textBox.Text);

                return true;
            }

            catch
            {
                textBox.BackColor = Color.LightCoral;

                return false;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            bool isOK = true; //Переменная-флаг для проверки ввода.

            //Проверяем, валидные ли значения введены.
            isOK = IsValidNumber(textBox_a, ref a) && isOK;
            isOK = IsValidNumber(textBox_b, ref b) && isOK;
            isOK = IsValidNumber(textBox_c, ref c) && isOK;

            //Если ввод верный, решаем уравнение.
            if (isOK)
            {
                if (a != 0)
                {
                    double discriminant = b * b - 4 * a * c;

                    if (discriminant < 0)
                    {
                        label_answer.Text = "Корней нет.";
                        label_answer.Visible = true;
                    }

                    else if (discriminant == 0)
                    {
                        double x = (-b / (2 * a));

                        label_answer.Text = "Корень равен " + x + ".";
                        label_answer.Visible = true;
                    }

                    else if (discriminant > 0)
                    {
                        double x1 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                        double x2 = ((-b + Math.Sqrt(discriminant)) / (2 * a));

                        label_answer.Text = "1 корень равен " + x1 + ". " +
                        "2 корень равен " + x2 + ".";
                        label_answer.Visible = true;
                    }
                }

                else
                {
                    if (b != 0)
                    {
                        label_answer.Text = $"Ответ: x = {-c / b}.";
                        label_answer.Visible = true;
                    }

                    else if (c != 0)
                    {
                        textBox_c.BackColor = Color.LightCoral;

                        label_answer.Text = $"{c} = 0 - неверное равенство.";
                        label_answer.Visible = true;
                    }

                    else if (c == 0)
                    {
                        label_answer.Text = $"x - любое число.";
                        label_answer.Visible = true;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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

            //Разрешаем печатать цифры.
            else
            {

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

        private void TextBox_c_Enter(object sender, EventArgs e)
        {
            textBox_c.BackColor = Color.White;
            label_answer.Visible = false; //Скрываем сообщение об ошибке.
        }

        private void TextBox_a_Enter(object sender, EventArgs e)
        {
            textBox_a.BackColor = Color.White;
        }

        private void TextBox_b_Enter(object sender, EventArgs e)
        {
            textBox_b.BackColor = Color.White;
        }

        private void TextBox_c_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
