using HealthcareBLL;
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

namespace HealthcareWpf
{
    /// <summary>
    /// Interaction logic for View.xaml 
    /// </summary>
    public partial class View : Page
    {
        private static View singletonInstance = CreateSingleton();
        
        public static View CreateSingleton()
        {
            if (singletonInstance == null)
            {
                singletonInstance = new View();

            }
            return singletonInstance;

        }
        public static View Getinstance
        {
            get
            {
                return singletonInstance;

            }
        }
        public View()
        {
            InitializeComponent();
            Hospital hospital = new Hospital();
            dataGrid.ItemsSource = hospital.ViewHospitalInfo();
        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
