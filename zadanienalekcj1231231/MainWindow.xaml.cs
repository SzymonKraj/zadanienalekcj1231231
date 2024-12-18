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

namespace zadanienalekcj1231231
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

        private void sprawdz_Click(object sender, RoutedEventArgs e)
        {
            if(radioPocztowka.IsChecked == true)
            {
                cena.Text = "cena : 1zl";
                listxd.Source = new BitmapImage(new Uri("list.jpg", UriKind.Relative));
            }else if(radioList.IsChecked == true)
            {
                cena.Text = "cena: 1.5zl";
                listxd.Source = new BitmapImage(new Uri("list2.jpg", UriKind.Relative));
            }
            else if(radioPaczka.IsChecked == true)
            {
                cena.Text = "cena: 10zl";
                listxd.Source = new BitmapImage(new Uri("list3.png", UriKind.Relative));
            }
        }

        private void zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            string kodpocztowy = kodpocztowybox.Text;
            if (!int.TryParse(kodpocztowy, out int result))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            if (kodpocztowy.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzi pocztowym");
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
        }
    }
}
