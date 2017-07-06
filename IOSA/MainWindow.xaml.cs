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

namespace IOSA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ribbon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ribbonButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RibbonButton_Click_1(object sender, RoutedEventArgs e)
        {
            //LIMPIAR VENTANA
            Ventana_oficial.Children.Clear();
            //AGREGAR NUEVA VISTA HIJA
            Ventana_oficial.Children.Add(new Paginas.UserControl1());
        }

        private void RibbonButton_Click_2(object sender, RoutedEventArgs e)
        {
            //LIMPIAR VENTANA
            Ventana_oficial.Children.Clear();
            //AGREGAR VENTANA VISTA HIJA
            Ventana_oficial.Children.Add(new Paginas.UserControl2());
        }
    }
}
