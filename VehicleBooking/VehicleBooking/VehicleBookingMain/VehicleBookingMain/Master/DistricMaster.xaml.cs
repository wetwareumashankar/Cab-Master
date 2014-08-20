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
    /// Interaction logic for DistricMaster.xaml
    /// </summary>
    public partial class DistricMaster : UserControl
    {
        Xceed.Wpf.Toolkit.WatermarkTextBox txbDistrictId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbStateId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbStateName;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbDistrictName;
        DataGrid dataGrid1;
        public DistricMaster()
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
            txbStateId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbStateId.Width = 200;
            txbStateId.Margin = new Thickness(0, 10, 0, 10);
            txbStateId.Watermark = "State ID";
            st.Children.Add(txbStateId);
            txbDistrictId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbDistrictId.Width = 200;
            txbDistrictId.Watermark = "District ID";
            txbDistrictId.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbDistrictId);
            txbStateName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbStateName.Width = 200;
            txbStateName.Watermark = "State Name";
            txbStateName.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbStateName);

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
