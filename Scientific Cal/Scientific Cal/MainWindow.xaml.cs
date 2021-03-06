﻿using System;
using System.Windows;

namespace Scientific_Cal
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double num1, num2;

        private string NumOper = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        // Start of Number buttons
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("1");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("2");
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("3");
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("4");
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("5");
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("6");
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("7");
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("8");
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("9");
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            SetButtonValue("0");
        }
        // End of number buttons

        //  Minus function

        private void btnNegative_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textDisplay.Text);
            textDisplay.Text = "0";
            NumOper = "-";
        }
        // Multiple function
        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textDisplay.Text);
            textDisplay.Text = "0";
            NumOper = "*";
        }
        // Divide function
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

        // Addition function
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textDisplay.Text);
            textDisplay.Text = "0";
            NumOper = "+";
        }

        // Equal button and switch function
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

                case "mod":
                    textDisplayTop.Text = num1 + " Mod ";
                    double result = num1 % num2;
                    textDisplay.Text = result.ToString();
                    break;

                case "EXP":
                    textDisplay.Text = Math.Pow(num1, num2).ToString();
                    textDisplayTop.Text = "";
                    break;

                case "SQx":
                    textDisplay.Text = Math.Pow(num1, num2).ToString();
                    textDisplayTop.Text = "";

                    break;


            }
        }


        // Clear Row
        private void btnSpare1_Click(object sender, RoutedEventArgs e)
        {

            //TODO: assign button/ function
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            //num1 = Math.Abs(Convert.ToDouble(textDisplay.ToString()));

            num1 = Convert.ToDouble(textDisplay.Text) * -1;
            textDisplay.Text = num1.ToString();
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            // remove last letter from text display.
            if (textDisplay.Text.Length > 0)
            {

                textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
            }
        }


        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            // clear last entry on screen
            if (NumOper == "")
                num1 = 0;
            else
                num2 = 0;
            textDisplay.Text = "0";
        }

        // Clear  function
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            NumOper = "";
            textDisplay.Text = "0";
            textDisplayTop.Text = "";
        }

        // End of Clear row


        // SQ root row
        private void btnSqRoot_Click(object sender, RoutedEventArgs e)
        {
            num1 = Math.Sqrt(Convert.ToDouble(textDisplay.Text));
            textDisplay.Text = num1.ToString();
        }

        private void btnTenX_Click(object sender, RoutedEventArgs e)
        {
            // to the power 10 x where x is the power

            num1 = Convert.ToDouble(textDisplay.Text);
            num2 = Math.Pow(10, num1);

            textDisplay.Text = num2.ToString();
        }


        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            //  log function , using log base 10
            num1 = Convert.ToDouble(textDisplay.Text);
            num2 = Math.Log10(num1);
            textDisplay.Text = num2.ToString();
        }

        private void btnExp_Click(object sender, RoutedEventArgs e)
        {
            //TODO: add exp function, fix it to show 10^2 = 1000
            num1 = Convert.ToDouble(textDisplay.Text);

            textDisplayTop.Text = num1.ToString() + " Exp ";
            textDisplay.Text = "";
            NumOper = "EXP";


        }


        // Modulus function
        private void btnMod_Click(object sender, RoutedEventArgs e)
        {

            num1 = Convert.ToDouble(textDisplay.Text);
            textDisplayTop.Text = num1 + " Mod ";


            // num2 = Convert.ToDouble(textDisplay.Text);
            NumOper = "mod";
            textDisplay.Text = "0";
        }

        // End of SQ root row


        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {// add demical to display box
            textDisplay.Text += ".";
        }



        // button value method
        private void SetButtonValue(String value)
        {
            if (textDisplay.Text == "0" && textDisplay.Text != null)
                textDisplay.Text = value;
            else
                textDisplay.Text = textDisplay.Text + value; // take in the string value and add it to the end of the string 
        }

        

        //  second row, to the power of and so on
        private void btnX3_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textDisplay.Text);
            textDisplay.Text = Math.Pow(num1, 3).ToString();
        }

       

        private void btnSqX_Click(object sender, RoutedEventArgs e)
        {
            // to the power of x function 
            num1 = Convert.ToDouble(textDisplay.Text);

            textDisplayTop.Text = num1.ToString() + " ^ ";
            textDisplay.Text = "";
            NumOper = "SQx";

        }
        // sin-1 function
        private void btnSinMinusOne_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(textDisplay.Text);

            textDisplay.Text = (Math.Asin(num1) / Math.PI * 180).ToString();
        }

        private void btnCosMinusOne_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTanMinusOne_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}