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

namespace VerificaGIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Biblioteca b = new Biblioteca();
        }

        private void btnLibro_Click(object sender, RoutedEventArgs e)
        {
            Libro l = new Libro("Gianni", "casa", 2012, "mondadori", 1000);
            Libro l2 = new Libro("Leo", "grattacielo", 2013, "mondadori", 300);
            lblLibro.Content=l;
            lblLibro.Content = l2;

        }
    }
}
