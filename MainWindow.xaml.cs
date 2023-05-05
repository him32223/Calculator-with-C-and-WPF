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
        string output = "";
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        
        //This show a message box when the button is click
        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            String name = ((Button)sender).Name;
            switch(name){
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
    }
}
