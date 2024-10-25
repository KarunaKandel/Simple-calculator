using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UPFAPP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private string _currentInput = "";
        private string _pendingOperation = "";
        private double _result = 0;

        public string Result
        {
            get { return _currentInput; }
            set { _currentInput = value; }
           
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            double n1 = (double)Convert.ToInt64(Num1.Text);
            double n2 = (double)Convert.ToInt64(Num2.Text);
           
            double resultValue = n1 + n2;
            result.Text = resultValue.ToString(); // Display result
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            double n1 = (double)Convert.ToInt64(Num1.Text);
            double n2 = (double)Convert.ToInt64(Num2.Text);
            double resultValue = n1 - n2;
            result.Text = resultValue.ToString(); // Display result
            
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            double n1 = (double)Convert.ToInt64(Num1.Text);
            double n2 = (double)Convert.ToInt64(Num2.Text);
            double resultValue = n1 * n2;
            result.Text = resultValue.ToString(); // Display result
           
        }

        private void div_btn_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            double n1 = Convert.ToDouble(Num1.Text);
            double n2 = Convert.ToDouble(Num2.Text);

            if (n2 != 0) // Check for division by zero
            {
                double resultValue = n1 / n2;
                result.Text = resultValue.ToString();  // Display result
            }
            else
            {
                result.Text = "Cannot divide by zero";  // Error message
            }
        }

        private void UpdateResult()
        {
            double number;
            if (double.TryParse(_currentInput, out number))
            {
                _currentInput = number.ToString(); // 
            }
            else
            {
                _currentInput = "Error";
            }
        }

    }
}
