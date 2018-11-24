using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Random_Number
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int count = 0;
        public int rnd = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            Generate_Random();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (!Guess())
            {
                count ++;
                if (count == 1)
                {
                    ResultText("This time unlucky. Try more");
                }
                else if (count == 2)
                {
                    ResultText("Hmmmm... No. The last chance");
                }
                else
                {
                    ResultText("Not your day. You lost:(\nWanna more?");
                    Generate_Random();
                }
            }
            else
            {
                ResultText("You win");
                Generate_Random();
            }
        }

        private void ResultText(string msg)
        {
            MessageBox.Show(msg);
            EnteredNumber.Text = "";
        }

        private void Generate_Random()
        {
            count = 0;
            Random rand = new Random();
            rnd = rand.Next(1, 11);
        }

        private bool Guess()
        {
            try
            {
                return (rnd == int.Parse(EnteredNumber.Text)) ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
