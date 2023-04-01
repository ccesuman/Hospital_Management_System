using HealthcareBLL;
using HelthCareExcaptionLibrary;
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
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : PageFunction<String>
    {
        private static InsertPage singletonInstance = CreateSingleton();

        public static InsertPage CreateSingleton()
        {
            if (singletonInstance == null)
            {
                singletonInstance = new InsertPage();

            }
            return singletonInstance;

        }
        public static InsertPage Getinstance
        {
            get
            {
                return singletonInstance;

            }
        }
        public InsertPage()
        {
            InitializeComponent();
            getCity();
            getState();
            getCountry();
        }

       public void getCity()
        {
            City c = new City();
            CitycodeBOX.ItemsSource = c.GetCity();
            CitycodeBOX.DisplayMemberPath = "CityName";
            CitycodeBOX.SelectedValuePath = "CityCode";
        }
        public void getState()
        {
            State s = new State();
            StateCodeBOX.ItemsSource = s.GetState();
            StateCodeBOX.DisplayMemberPath = "StateName";
            StateCodeBOX.SelectedValuePath = "StateCode";
        }
        public void getCountry()
        {
            Country c = new Country();
            CountryCodeBOX.ItemsSource = c.GetCountries();
            CountryCodeBOX.DisplayMemberPath = "CountryName";
            CountryCodeBOX.SelectedValuePath = "CountryCode";
        }
        public void InsertMathod()
            {
            InsertHospital inserthospitalinfo = new InsertHospital();
            try{
                if (string.IsNullOrEmpty(HoapitalNameTX.Text))
                {
                    throw new NameIsEmptyException("Hospital Name is Empty try again after entring the name");
                }
                else
                {
                    inserthospitalinfo.HospitalName = HoapitalNameTX.Text;
                }
                if (string.IsNullOrEmpty(PrimaryAddressTX.Text))
                {
                    throw new NameIsEmptyException("Primary Address  is Empty try again after entring the Address");
                }
                else
                {
                    inserthospitalinfo.PrimaryAddress = PrimaryAddressTX.Text;
                }
                if (string.IsNullOrEmpty(SecondaryAddressTX.Text))
                {
                    throw new NameIsEmptyException("Secondary Address is Empty try again after entring the Secondary Address");
                }
                else
                {
                    inserthospitalinfo.SecondaryAddress = SecondaryAddressTX.Text;
                }
                inserthospitalinfo.PinCode = int.Parse(PinCodeTX.Text);
                inserthospitalinfo.Departments = int.Parse(DepartmentTX.Text);
                inserthospitalinfo.TotalRoom = int.Parse(TotalRoomTX.Text);
                inserthospitalinfo.CityCode = int.Parse(CitycodeBOX.SelectedValue.ToString());
                inserthospitalinfo.StateCode = int.Parse(StateCodeBOX.SelectedValue.ToString());
                inserthospitalinfo.CountryCode = int.Parse(CitycodeBOX.SelectedValue.ToString());
               int result= inserthospitalinfo.InsertHospitalMethod();
                if(result==1)
                {
                    MessageBox.Show("Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Inserted failed try again");
                }
            }
            catch(ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InsertMathod();
        }

        private void StateCodeTX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
