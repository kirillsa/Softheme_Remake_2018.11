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

namespace Task03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sign_Up(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firstName.Text == "" || firstName.Text.Length > 255 || int.TryParse(firstName.Text, out var n))
                {
                    MessageBox.Show("Wrong Name format!");
                }
                else if (lastName.Text == "" || lastName.Text.Length > 255 || int.TryParse(lastName.Text, out n))
                {
                    MessageBox.Show("Wrong LastName format!");
                }
                else if (year.Text == "" || !int.TryParse(year.Text, out n) || int.Parse(year.Text) < 1900 || int.Parse(year.Text) > DateTime.Today.Year)
                {
                    MessageBox.Show("Wrong Year of Birth format!");
                }
                else if (month.Text == "" || !int.TryParse(month.Text, out n) || int.Parse(month.Text) < 1 || int.Parse(month.Text) > 12)
                {
                    MessageBox.Show("Wrong Month of Birth format!");
                }
                else if (day.Text == "" || !int.TryParse(day.Text, out n) || int.Parse(day.Text) < 1 || int.Parse(day.Text) > DateTime.DaysInMonth(int.Parse(year.Text), int.Parse(month.Text)))
                {
                    MessageBox.Show("Wrong Day of Birth format!");
                }
                else if (emailText.Text == "" || !emailText.Text.Contains('@'))
                {
                    MessageBox.Show("Wrong email format!");
                }
                else if (phoneNumberText.Text == "" || !double.TryParse(phoneNumberText.Text, out var m) || phoneNumberText.Text.Length != 12)
                {
                    MessageBox.Show("Wrong phone format!");
                }
                else if (infoText.Text.Length > 2000)
                {
                    MessageBox.Show("Too long info");
                }
                else
                {
                    MessageBox.Show("Registration complete");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
