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
using System.Windows.Shapes;
using VehicleBookingMain.Master;

namespace VehicleBookingMain
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
            grdMaster.Children.Add(new CountryMasterView());
         //   Countrymaster.Visibility = System.Windows.Visibility.Visible;
         //   Statemaster.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void brdGeoMaster_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grdMaster.Children.Clear();
            grdMaster.Children.Add(new CountryMasterView());
          //  Countrymaster.Visibility = System.Windows.Visibility.Visible;
            //Statemaster.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void brdUserMater_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grdMaster.Children.Clear();
            grdMaster.Children.Add(new StateMater());
          //  Countrymaster.Visibility = System.Windows.Visibility.Visible;
            //Statemaster.Visibility = System.Windows.Visibility.Collapsed;
        }
        
        private void brdCabMaster_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grdMaster.Children.Clear();
            grdMaster.Children.Add(new DistricMaster());
        }

        private void brdDriverMater_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grdMaster.Children.Clear();

            grdMaster.Children.Add(new Citymaster());
        }

        private void brdBookingMaster_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grdMaster.Children.Clear();
            grdMaster.Children.Add(new AreaMaster());
        }

        private void brdInvoiceMaster_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grdMaster.Children.Clear();
            grdMaster.Children.Add(new CompanyMaster());
        }
    }
}
