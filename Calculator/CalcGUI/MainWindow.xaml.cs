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
using Calculator;

namespace CalcGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int number1 = 0;
        int number2 = 0;
        string operation = "";
        bool printed = false;
        int result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Number Buttons
        private void BOne_Click(object sender, RoutedEventArgs e)
        {
            if(operation == ""){
                number1 = (number1 * 10) + 1;
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                Resultbox.Text = number2.ToString();
            }
        }

        private void BTwo_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Resultbox.Text = number2.ToString();
            }
        }

        private void BThree_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Resultbox.Text = number2.ToString();
            }
        }

        private void BFour_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Resultbox.Text = number2.ToString();
            }
        }

        private void BFive_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Resultbox.Text = number2.ToString();
            }
        }

        private void BSix_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Resultbox.Text = number2.ToString();
            }
        }

        private void BSeven_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Resultbox.Text = number2.ToString();
            }
        }

        private void BEight_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Resultbox.Text = number2.ToString();
            }
        }

        private void BNine_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Resultbox.Text = number2.ToString();
            }
        }

        private void BZero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                Resultbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                Resultbox.Text = number2.ToString();
            }
        }


        //Operation Buttons
        private void BAddition_Click(object sender, RoutedEventArgs e)
        {
            operation = "+"; //this also ensures that the else statements run for the num buttons
            Resultbox.Text = "0"; //this way you are ready to add the second number
            FullText.Text += $"{number1} {operation}";

        }

        private void BSubtraction_Click(object sender, RoutedEventArgs e)
        {
            operation = "-"; //this also ensures that the else statements run for the num buttons
            Resultbox.Text = "0"; //this way you are ready to add the second number
            FullText.Text += $"{number1} {operation}";

        }

        private void BMultiplication_Click(object sender, RoutedEventArgs e)
        {
            operation = "*"; //this also ensures that the else statements run for the num buttons
            Resultbox.Text = "0"; //this way you are ready to add the second number
            FullText.Text += $"{number1} {operation}";

        }

        private void BDivision_Click(object sender, RoutedEventArgs e)
        {

            operation = "/"; //this also ensures that the else statements run for the num buttons
            Resultbox.Text = "0"; //this way you are ready to add the second number
            FullText.Text += $"{number1} {operation}";

        }
        private void BModulus_Click(object sender, RoutedEventArgs e)
        {
            operation = "%"; //this also ensures that the else statements run for the num buttons
            Resultbox.Text = "0"; //this way you are ready to add the second number
            FullText.Text += $"{number1} {operation}";
        }

        private void BPow_Click(object sender, RoutedEventArgs e)
        {
            operation = "^"; //this also ensures that the else statements run for the num buttons
            Resultbox.Text = "0"; //this way you are ready to add the second number
            FullText.Text += $"{number1} {operation}";
        }
        private void BPowTwo_Click(object sender, RoutedEventArgs e)
        {
            operation = "^2";
            FullText.Text += $"{number1} {operation}";
            Resultbox.Text = "2"; //this way you are ready to add the second number
            number2 = 2;
        }
        private void BSqrt_Click(object sender, RoutedEventArgs e)
        {
            if(number1 > 0)
            {
                result = Calculators.Root(number1);

                Resultbox.Text = $"sqrt({number1}) = {result}"; //this way you are ready to add the second number
                FullText.Text = $"sqrt({number1}) = {result}";
                printed = true;
            }
            else
            {
                operation = "sqrt(0)"; //this also ensures that the else statements run for the num buttons
                Resultbox.Text = "sqrt(0)"; //this way you are ready to add the second number
                FullText.Text = "sqrt(0)";
            }
            
        }

        //Print Button 
        private void BEqual_Click(object sender, RoutedEventArgs e)
        {
            if (printed == true) { } // if has been printed dont print again

            else if (operation == "+")
            {
                 result = (Calculators.Add(number1, number2));
                Resultbox.Text = result.ToString();
                FullText.Text += $" {number2} = {result}";
            }
            else if (operation == "-")
            {
                
                 result = (Calculators.Subtract(number1, number2));
                Resultbox.Text = result.ToString();
                FullText.Text += $" {number2} = {result}";
            }
            else if (operation == "*")
            {
                 result = (Calculators.Multiply(number1, number2));
                Resultbox.Text = result.ToString();
                FullText.Text += $" {number2} = {result}";
            }
            else if (operation == "/")
            {
                if (number2 == 0)
                {
                    Resultbox.Text = "Cannot divide by 0"; //this way you are ready to add the second number

                }
                else
                {
                    result = (Calculators.Divide(number1, number2));
                    Resultbox.Text = result.ToString();
                    FullText.Text += $" {number2} = {result}";
                }
                
            }
            else if (operation == "%")
            {
                 result = (Calculators.Modulus(number1, number2));
                Resultbox.Text = result.ToString();
                FullText.Text += $" {number2} = {result}";

            }
            else if (operation == "^")
            {
                result = (Calculators.PowerOf(number1, number2));
                Resultbox.Text = result.ToString();
                FullText.Text += $" {number2} = {result}";

            }
            else if (operation == "^ 2")
            {
                 result = Calculators.PowerOfTwo(number1);
                Resultbox.Text = result.ToString();
                FullText.Text += $" = {result}";

            }
            else if (operation == "sqrt(0)")
            {
                result = Calculators.Root(number2);
                Resultbox.Text = $"sqrt({number2}) = {result}";
                FullText.Text = $"sqrt({number2}) = {result}";

            }

            printed = true;
        }

        //Clear Button
        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            operation = "";
            number1 = 0;
            number2 = 0;
            Resultbox.Text = "0";
            FullText.Text = "";
            printed = false;
        }

        
    }
}
