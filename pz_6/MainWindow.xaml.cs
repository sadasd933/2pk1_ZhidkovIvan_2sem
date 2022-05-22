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
using System.Text.RegularExpressions;

namespace pz_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void press7Button_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "7";
        }
        
        private void press8Button_Click_1(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "8";
        }

        private void press9Button_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "9";
        }

        private void presslButton_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "+";
        }

        private void press4Button_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "4";
        }

        private void press5Button_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "5";
        }

        private void press6Button_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "6";
        }

        private void pressoButton_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "-";
        }

        private void press1Button_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "1";
        }

        private void press2Button_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "2";
        }

        private void press3Button_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "3";
        }

        private void pressdButton_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "*";
        }

        private void press0Button_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "0";
        }

        private void pressqButton_Click(object sender, RoutedEventArgs e)
        {

            Regex r = new Regex(@"[-+*/]+");
            Match tel = r.Match(iputTextBlock.Text);
            string znak = "0";
            while (tel.Success)
            {
                znak = Convert.ToString(tel);
                tel = tel.NextMatch();
            }
            string text = iputTextBlock.Text;
            string[] newText = Regex.Split(text, "[-+/*]+");
            if (znak == "+")
                iputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) + Convert.ToDouble(newText[1]))}";
            else if (znak == "-")
                iputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) - Convert.ToDouble(newText[1]))}";
            else if (znak == "*")
                iputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) * Convert.ToDouble(newText[1]))}";
            else if (znak == "/")
                iputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) / Convert.ToDouble(newText[1]))}";
            else
                iputTextBlock.Text = "ERROR";

        }

        private void presskButton_Click(object sender, RoutedEventArgs e)
        {
            iputTextBlock.Text += "/";
        }

    }
}
