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
    /// Interaction logic for AreaMaster.xaml
    /// </summary>
    public partial class AreaMaster : UserControl
    {
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCityId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbAreaId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbAreaName;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbZipCode;

        Xceed.Wpf.Toolkit.WatermarkTextBox txbLongitude;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbLatitude;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCreatedDate;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCityName;
        DataGrid dataGrid1;
        public AreaMaster()
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
            txbAreaId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbAreaId.Width = 200;
            txbAreaId.Watermark = "Area ID";
            txbAreaId.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbAreaId);
            txbCityName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCityName.Width = 200;
            txbCityName.Watermark = "City Name";
            txbCityName.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbCityName);

            txbAreaName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbAreaName.Width = 200;
            txbAreaName.Margin = new Thickness(0, 10, 0, 10);
            txbAreaName.Watermark = "Area Name";
            st.Children.Add(txbAreaName);

            txbLongitude = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbLongitude.Width = 200;
            txbLongitude.Margin = new Thickness(0, 10, 0, 10);
            txbLongitude.Watermark = "Longitude";
            st.Children.Add(txbLongitude);
            txbLatitude = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbLatitude.Width = 200;
            txbLatitude.Watermark = "Latutude";
            txbLatitude.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbLatitude);
            txbCreatedDate = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCreatedDate.Width = 200;
            txbCreatedDate.Watermark = "Created Date";
            txbCreatedDate.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbCreatedDate);

            txbCityName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCityName.Width = 200;
            txbCityName.Margin = new Thickness(0, 10, 0, 10);
            txbCityName.Watermark = "City Name";
            st.Children.Add(txbCityName);


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
