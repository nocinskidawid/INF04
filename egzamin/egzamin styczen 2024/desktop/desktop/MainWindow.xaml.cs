using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace desktop
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imie = Imie.Text;
            string nazwisko = Nazwisko.Text;
            string numer = Numer.Text;
            string kolor;
            if (Niebieski.IsChecked == true) {
                kolor = "niebieski";
            } else if (Brazowy.IsChecked == true) {
                kolor = "brazowy";
            } else if (Zielony.IsChecked == true) {
                kolor = "zielony";
            }
            else {
                kolor = "";
            }
            
            if (imie == "" || nazwisko == "" || numer == ""|| kolor=="")
            {
                MessageBox.Show("Wprowadź dane");
            }
            else {
                MessageBox.Show($"{imie} {nazwisko} kolor oczu {kolor}");
            }

        }

        private void Numer_TextChanged(object sender, TextChangedEventArgs e)
        {
            string numer = Numer.Text;

            if (File.Exists($"C:/Users/HP/Desktop/egzamin/egzamin styczen 2024/desktop/{numer}.jpg")) {
                Obrazek1.Source = BitmapFrame.Create(new Uri($"C:/Users/HP/Desktop/egzamin/egzamin styczen 2024/desktop/{numer}.jpg", UriKind.Relative));
                Obrazek2.Source = BitmapFrame.Create(new Uri($"C:/Users/HP/Desktop/egzamin/egzamin styczen 2024/desktop/{numer}.jpg", UriKind.Relative));
            }
               
            
        }
    }
}