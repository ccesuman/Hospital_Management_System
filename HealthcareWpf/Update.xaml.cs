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
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Page
    {
        private static Update singletonInstance = CreateSingleton();

        public Update()
        {
            InitializeComponent();
        }
        public static Update CreateSingleton()
        {

            if (singletonInstance == null)
            {
                singletonInstance = new Update();

            }
            return singletonInstance;
        }
        public Update Getinstance
        {
            get
            {

                return singletonInstance;
            }
        }
    }
}
