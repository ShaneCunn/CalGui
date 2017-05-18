﻿using System;
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

namespace Scientific_Cal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string NumOper = "";
        double num1, num2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "1";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "2";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "2";
            }
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "3";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "3";
            }
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "4";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "4";
            }
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "5";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "6";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "6";
            }
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "7";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "7";
            }
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "8";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "8";
            }
        }


        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "9";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "9";
            }
        }



        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
            {
                textDisplay.Text = "0";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "0";
            }
        }





        private void btnNegative_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textDisplay.Text);
            textDisplay.Text = "0";
            NumOper = "-";
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textDisplay.Text);
            textDisplay.Text = "0";
            NumOper = "*";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {

            if (textDisplay.Text != "0")
            {
                num1 = Convert.ToDouble(textDisplay.Text);
                textDisplay.Text = "0";
                NumOper = "/";
            }
            else
            {
                textDisplay.Text = "Cannot Divide by Zero!!!";
            }
        }




        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textDisplay.Text);
            textDisplay.Text = "0";
            NumOper = "+";
        }



        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {

            num2 = Convert.ToDouble(textDisplay.Text);

            switch (NumOper) // switch on the string that is passed as a parameter. 
            {
                case "+":
                    textDisplay.Text = (num1 + num2).ToString(); /// add function
                    break;
                case "-":
                    textDisplay.Text = (num1 - num2).ToString(); //  minus function
                    break;
                case "*":
                    textDisplay.Text = (num1 * num2).ToString(); //  multp function
                    break;
                case "/":

                    if (num1 == 0) //  divide function with divide by zero error checking
                    {
                        textDisplay.Text = "0";
                        break;
                    }
                    else
                    {
                        textDisplay.Text = (num1 / num2).ToString();
                        break;
                    }
            }



        }


        // Clear Row
        private void btnSpare1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            //num1 = Math.Abs(Convert.ToDouble(textDisplay.ToString()));

            num1 = Convert.ToDouble(textDisplay.Text) * -1;
            textDisplay.Text = num1.ToString();
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                // remove the last letter from the textbox display
                textDisplay.Text = textDisplay.Text.Substring(0, (textDisplay.Text.Length - 1));
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            // clear last entry on screen
            if (NumOper == "")
            {

                num1 = 0;
            }
            else
            {
                num2 = 0;

            }
            textDisplay.Text = "0";

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            NumOper = "";
            textDisplay.Text = "0";
        }

        // End of Clear row


        // SQ root row
        private void btnSqRoot_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnTenX_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnLog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {

        }

        // End of SQ root row


    }
}
