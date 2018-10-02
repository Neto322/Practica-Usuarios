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

namespace PracticaUsuarios
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

        private void ComboBreiker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelConfiguracion.Children.Clear();
            switch (ComboBreiker.SelectedIndex)
            {
                case 0:

                    panelConfiguracion.Children.Add(new Alumno());

                    break;
                case 1:

                    panelConfiguracion.Children.Add(new Maestro());

                    break;
                default:



                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           switch(ComboBreiker.SelectedIndex)
            {
                case 0:
                    var control = (Alumno)(panelConfiguracion.Children[0]);
                    string nombre = control.NombreAlumno.ToString();
                    string dirrecion = control.DirrecionAlumno.ToString();
                    string carrera = control.CarreraAlumno.ToString();
                    string prepa = control.PrepaAlumno.ToString();

                    if ( nombre = "")
                    {

                    }
          else
                    {
                        control.NombreAlumno.Foreground = Brushes.Red;
                    }
                    break;
            }

        }
    }
}
