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
using WpfApp2.DataModel;

namespace WpfApp2.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для PrognosisWeather.xaml
    /// </summary>
    public partial class PrognosisWeather : UserControl
    {
        private Prognosis _thisprognosis;
        public Prognosis prognosis
        {
            get { return _thisprognosis; }
            set
            {
                _thisprognosis = value
                    ?? throw new ArgumentNullException(nameof(_thisprognosis));
            }
        }
        public PrognosisWeather(Prognosis progn)
        {
            InitializeComponent();
            prognosis = progn;

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonShowWeather_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void PrognosisWeatherControl_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
