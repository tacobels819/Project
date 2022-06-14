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
using LC;

namespace Podgotov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Avtorizaciya.xaml
    /// </summary>
    public partial class Avtorizaciya : Page
    {
        public Avtorizaciya()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginBox.Text;
            var pasword = Paswordbox.Password;
            var result = neznayu.Avtoriz (login, pasword);
            if (result == 1) NavigationService.Navigate(new Uri("Pages/Page1.xaml", UriKind.Relative));
            else if (result == 2) MessageBox.Show("PaswordnoVerniy");
            else MessageBox.Show("net");

        }
    }
}
