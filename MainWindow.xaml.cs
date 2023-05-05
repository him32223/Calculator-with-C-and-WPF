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
        String output = "";
        public MainWindow()
        {
            InitializeComponent();
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

            }
        }
    }
}
