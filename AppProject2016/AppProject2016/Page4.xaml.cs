using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppProject2016
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page4 : Page
    {
        public Page4()
        {
            this.InitializeComponent();
        }

        string opration;
        double num1, num2, result;

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "+";
                TextBox.Text = "";
                ValuText.Text = num1 + "+";
            }
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "-";
                TextBox.Text = "";
                ValuText.Text = num1 + "-";
            }
        }

        private void BtnMulti_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "*";
                TextBox.Text = "";
                ValuText.Text = num1 + "*";
            }
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "/";
                TextBox.Text = "";
                ValuText.Text = num1 + "/";
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "6";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "8";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "9";
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "0";
        }

        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Contains("."))
            {
                TextBox.Text = TextBox.Text;
            }
            else
            {
                TextBox.Text = TextBox.Text + ".";
            }
        }

        private void BtnCan_Click(object sender, RoutedEventArgs e)
        {
            int length = TextBox.Text.Length;
            if (length > 0)
            {
                TextBox.Text = TextBox.Text.Remove(length - 1);
            }
            else
            {
                TextBox.Text = TextBox.Text;
            }
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            ValuText.Text = "";
        }

        private void BtnPer_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "%";
                TextBox.Text = "";
                ValuText.Text = num1 + "%";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num2 = double.Parse(TextBox.Text);
                ValuText.Text = "";
                switch (opration)
                {
                    case "+":
                        result = num1 + num2;
                        TextBox.Text = result.ToString();
                        break;
                    case "-":
                        result = num1 - num2;
                        TextBox.Text = result.ToString();
                        break;
                    case "*":
                        result = num1 * num2;
                        TextBox.Text = result.ToString();
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            ValuText.Text = "Cannot divide by zero";
                            break;
                        }
                        else
                        {
                            result = num1 / num2;
                            TextBox.Text = result.ToString();
                            break;
                        }
                    case "%":
                        num1 = num1 * num2;
                        result = num1 / 100;
                        TextBox.Text = result.ToString();
                        break;
                }
            }
        }
    }
}
