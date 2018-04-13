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

namespace u3Toppings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] strings = new string[10];

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                strings[i] = "Nothing";
            }
        }

        public string list (int i, string t)
        {
            strings[i] = t;
            MessageBox.Show(strings[i]);
            return strings[i];
        }

        public void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            int index = 0;
            int.TryParse(input.Substring(0, 1), out index);
            string Topping = input.Substring(2, input.Length - 2);
            list(index, Topping);
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {

            string output = "Toppings: " + '\n';
            for (int i = 0; i < 10; i++)
            {
                strings[i] = strings[i].Substring(0, 1).ToUpper() + strings[i].Substring(1, strings[i].Length - 1).ToLower();
            }
            for (int i = 0; i< 10; i++)
            {
                if (strings[i] == "Nothing")
                {

                }
                else
                {
                output += strings[i] + '\n';
                }
            }
            MessageBox.Show(output);
        }
    }
}
