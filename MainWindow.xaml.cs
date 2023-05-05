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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        double temp = 0;
        string operation = "";
        string output = "";
        public MainWindow()
        {
            InitializeComponent();


            this.DataContext = this;
            DivideBtn.Content = "\u00F7";
            OutputTextBlock.Foreground = Brushes.White;
        }




        //This show a message box when the button is click
        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            String name = ((Button)sender).Name;
            switch (name)
            {
                case "SevenBtn":
                    output += "7";
                    OutputTextBlock.Text = output;

                    break;

                case "NineBtn":
                    output += "9";
                    OutputTextBlock.Text = output;

                    break;


                case "EightBtn":
                    output += "8";
                    OutputTextBlock.Text = output;

                    break;

                case "SixthBtn":
                    output += "6";
                    OutputTextBlock.Text = output;

                    break;

                case "FithBtn":
                    output += "5";
                    OutputTextBlock.Text = output;

                    break;

                case "FourthBtn":
                    output += "4";
                    OutputTextBlock.Text = output;

                    break;

                case "ThirdBtn":
                    output += "3";
                    OutputTextBlock.Text = output;

                    break;

                case "SecondBtn":
                    output += "2";
                    OutputTextBlock.Text = output;

                    break;

                case "FirstBtn":
                    output += "1";
                    OutputTextBlock.Text = output;

                    break;

                case "ZeroBtn":
                    output += "0";
                    OutputTextBlock.Text = output;

                    break;









            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Minus";
            }
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "Minus":
                    double outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Plus":
                    double plusTemp = temp + double.Parse(output);
                    output = plusTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Divide":
                    double DivideTemp = temp / double.Parse(output);
                    output = DivideTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;
            }


        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Plus";
            }
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Divide";
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Clear";
                OutputTextBlock.Text = output;
            }

    }
    }
}
    
    


