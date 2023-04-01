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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        private static Delete singletonInstance = CreateSingleton();
        public Delete()
        {
            InitializeComponent();
        }
        public static Delete CreateSingleton()
        {
            if (singletonInstance == null)
            {
                singletonInstance = new Delete();
            }
            return singletonInstance;
        }
        public static Delete Getinstance
        { 
            get
            {
                return singletonInstance;

            }
        }
        public void DeleteMethod(int Hospitalid)
        {
            DeleteHospital h = new DeleteHospital();
            int result = 0;
            result = h.DeleteHospitalMethod( Hospitalid);
            if(result==1)
            {
                MessageBox.Show("Delete successfully");
            }
            else
            {
                MessageBox.Show("Delete failed try again");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DeleteMethod(int.Parse(DeleteTX.Text));


        }
    }
}
