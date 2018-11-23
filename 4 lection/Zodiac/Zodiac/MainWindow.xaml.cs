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

namespace Registration_form
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

        private BitmapImage Get_Image(string s, UriKind uk)
        {
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(s, uk);
            bi3.EndInit();
            return bi3;
        }

        private void showSign_Click(object sender, RoutedEventArgs e)
        {
            string[] sourseImages = {
                "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/Aries.svg/40px-Aries.svg.png",//овен
                "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Taurus.svg/40px-Taurus.svg.png",//телец
                "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Gemini.svg/40px-Gemini.svg.png",//близнецы
                "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Cancer.svg/40px-Cancer.svg.png",//рак
                "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Leo.svg/40px-Leo.svg.png",//лев
                "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Virgo.svg/40px-Virgo.svg.png",//дева
                "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/Libra.svg/40px-Libra.svg.png",//весы
                "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Scorpio.svg/40px-Scorpio.svg.png",//скорпион
                "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Sagittarius.svg/40px-Sagittarius.svg.png",//стрелец
                "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Capricorn.svg/40px-Capricorn.svg.png",//козерог
                "https://upload.wikimedia.org/wikipedia/commons/thumb/2/24/Aquarius.svg/40px-Aquarius.svg.png",//водолей
                "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Pisces.svg/40px-Pisces.svg.png"//рыбы
            };
            try
            {
                var date = DateTime.Parse(dateField.Text);
                if (date.Month == 3 && date.Day >= 21 || date.Month == 4 && date.Day <= 20)
                {//овен
                    imageOfSign.Source = Get_Image(sourseImages[0], UriKind.Absolute);
                }
                else if (date.Month == 4 && date.Day >= 21 || date.Month == 5 && date.Day <= 21)
                {//телец
                    imageOfSign.Source = Get_Image(sourseImages[1], UriKind.Absolute);
                }
                else if (date.Month == 5 && date.Day >= 22 || date.Month == 6 && date.Day <= 21)
                {//близнецы
                    imageOfSign.Source = Get_Image(sourseImages[2], UriKind.Absolute);
                }
                else if (date.Month == 6 && date.Day >= 22 || date.Month == 7 && date.Day <= 22)
                {//рак
                    imageOfSign.Source = Get_Image(sourseImages[3], UriKind.Absolute);
                }
                else if (date.Month == 7 && date.Day >= 23 || date.Month == 8 && date.Day <= 23)
                {//лев
                    imageOfSign.Source = Get_Image(sourseImages[4], UriKind.Absolute);
                }
                else if (date.Month == 8 && date.Day >= 24 || date.Month == 9 && date.Day <= 23)
                {//дева
                    imageOfSign.Source = Get_Image(sourseImages[5], UriKind.Absolute);
                }
                else if (date.Month == 9 && date.Day >= 24 || date.Month == 10 && date.Day <= 23)
                {//весы
                    imageOfSign.Source = Get_Image(sourseImages[6], UriKind.Absolute);
                }
                else if (date.Month == 10 && date.Day >= 24 || date.Month == 11 && date.Day <= 22)
                {//скорпион
                    imageOfSign.Source = Get_Image(sourseImages[7], UriKind.Absolute);
                }
                else if (date.Month == 11 && date.Day >= 23 || date.Month == 12 && date.Day <= 21)
                {//стрелец
                    imageOfSign.Source = Get_Image(sourseImages[8], UriKind.Absolute);
                }
                else if (date.Month == 12 && date.Day >= 22 || date.Month == 1 && date.Day <= 20)
                {//козерог
                    imageOfSign.Source = Get_Image(sourseImages[9], UriKind.Absolute);
                }
                else if (date.Month == 1 && date.Day >= 21 || date.Month == 2 && date.Day <= 18)
                {//водолей 
                    imageOfSign.Source = Get_Image(sourseImages[10], UriKind.Absolute);
                }
                else if (date.Month == 2 && date.Day >= 19 || date.Month == 3 && date.Day <= 20)
                {//рыбы
                    imageOfSign.Source = Get_Image(sourseImages[11], UriKind.Absolute);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}