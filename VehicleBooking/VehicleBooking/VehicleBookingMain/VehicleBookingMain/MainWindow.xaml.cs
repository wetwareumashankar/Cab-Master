using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VehicleDataService.Masters;
using VehicleBL.Masters;

namespace VehicleBookingMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindGrid();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            CountryMasterDataService countryDs = new CountryMasterDataService();
            CountryMaster countryBL = new CountryMaster();
            countryBL.CountryId = -1;
            countryBL.CountryCode = txtCCode.Text;
            countryBL.CountryName = txtCname.Text;
            countryBL.ISDNo = txtISDCode.Text;
            List<CountryMaster> countryList = countryDs.Country_Insert(countryBL);
            dataGrid1.ItemsSource = countryList;
            countryBL = null;
            countryList = null;
            countryDs = null;
        }

        private void BindGrid()
        {
            CountryMasterDataService countryDs = new CountryMasterDataService();
            List<CountryMaster> countryList = countryDs.Country_RetrieveAll();
            dataGrid1.ItemsSource = countryList;
            countryList = null;
            countryDs = null;
        }


    }
}
