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

namespace VehicleBookingMain.Master
{
    /// <summary>
    /// Interaction logic for Citymaster.xaml
    /// </summary>
    public partial class Citymaster : UserControl
    {
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCityId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbDistrictId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCityName;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbDistrictName;
        DataGrid dataGrid1;
        public Citymaster()
        {
            InitializeComponent();
            dataGrid1 = new DataGrid();
            dataGrid1.AutoGenerateColumns = true;
            dataGrid1.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            dataGrid1.Margin = new Thickness(10);
            dataGrid1.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            grdField.Children.Add(dataGrid1);
            Grid.SetColumn(dataGrid1, 1);
            // BindGrid();
            loadField();
        }
        void loadField()
        {
            StackPanel st = new StackPanel();
            txbCityId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCityId.Width = 200;
            txbCityId.Margin = new Thickness(0, 10, 0, 10);
            txbCityId.Watermark = "City ID";
            st.Children.Add(txbCityId);
            txbDistrictId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbDistrictId.Width = 200;
            txbDistrictId.Watermark = "District ID";
            txbDistrictId.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbDistrictId);
            txbCityName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCityName.Width = 200;
            txbCityName.Watermark = "City Name";
            txbCityName.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbCityName);

            txbDistrictName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbDistrictName.Width = 200;
            txbDistrictName.Margin = new Thickness(0, 10, 0, 10);
            txbDistrictName.Watermark = "District Name";
            st.Children.Add(txbDistrictName);


            StackPanel stpanal = new StackPanel();
            stpanal.Orientation = Orientation.Horizontal;
            stpanal.Margin = new Thickness(20);
            stpanal.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            Button bt = new Button();
            bt.Name = "btnSubmit";
            bt.Click += bt_Click;
            bt.Style = Application.Current.FindResource("MetroButtonSubmit") as Style;

            // bt.Margin = new Thickness(0, 10, 0, 10);
            bt.Margin = new Thickness(0, 0, 10, 0);
            Button btcncle = new Button();
            btcncle.Style = Application.Current.FindResource("MetroButtonClose") as Style;

            btcncle.Margin = new Thickness(30, 0, 0, 0);
            stpanal.Children.Add(bt);
            stpanal.Children.Add(btcncle);

            st.Children.Add(stpanal);


            grdField.Children.Add(st);
        }

        void bt_Click(object sender, RoutedEventArgs e)
        {
            //CountryMasterDataService countryDs = new CountryMasterDataService();
            //CountryMaster countryBL = new CountryMaster();
            //countryBL.CountryId = -1;
            //countryBL.CountryCode = txbCountryCode.Text;
            //countryBL.CountryName = txbCountryName.Text;
            //countryBL.ISDNo = txbISDCode.Text;
            //List<CountryMaster> countryList = countryDs.Country_Insert(countryBL);
            //dataGrid1.ItemsSource = countryList;
            //countryBL = null;
            //countryList = null;
            //countryDs = null;
        }
    }
}
