using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calulator_Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double number1 = 0, number2 = 0;
        string operations = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {


            if (operations == "")
            {
                number1 = (number1 * 10) + 1;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 1;
                textDisplay.Text = number2.ToString();
            }
        }



        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 2;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 2;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 3;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 3;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 4;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 4;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 5;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 5;
                textDisplay.Text = number2.ToString();
            }
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 6;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 6;
                textDisplay.Text = number2.ToString();
            }
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 7;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 7;
                textDisplay.Text = number2.ToString();
            }
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 8;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 8;
                textDisplay.Text = number2.ToString();
            }
        }



        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 9;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 9;
                textDisplay.Text = number2.ToString();
            }
        }



        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10);
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10);
                textDisplay.Text = number2.ToString();
            }
        }

        private void btnNegative_Click(object sender, RoutedEventArgs e)
        {
            operations = "-";
            textDisplay.Text = "0";
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            operations = "*";
            textDisplay.Text = "0";
        }
        
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operations = "/";
            textDisplay.Text = "0";
        }



        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operations = "+";
            textDisplay.Text = "0";
        }



        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operations)
            {
                case "+":
                    textDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    textDisplay.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    textDisplay.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    textDisplay.Text = (number1 / number2).ToString();
                    break;

            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operations = "";
            textDisplay.Text = "0";
         }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 / 10);
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 / 10);
                textDisplay.Text = number2.ToString();
            }
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
          

        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 9;
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 10) + 9;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btnInch_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 0.39370);
                textDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = (number2 * 0.39370);
                textDisplay.Text = number2.ToString();
            }
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = 0;

            }
            else
            {
                number2 = 0;

            }
            textDisplay.Text = "0";
        }

    }
}
