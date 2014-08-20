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
using VehicleBL.Masters;
using VehicleDataService.Masters;

namespace VehicleBookingMain.Master
{
    /// <summary>
    /// Interaction logic for StateMater.xaml
    /// </summary>
    public partial class StateMater : UserControl
    {
        DataGrid dataGrid1;
        public StateMater()
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

        Xceed.Wpf.Toolkit.WatermarkTextBox txbStateId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCountryId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbStateCode;


        Xceed.Wpf.Toolkit.WatermarkTextBox txbStateName;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbSTDCode;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCountryName;
        void loadField()
        {
            StackPanel st = new StackPanel();
            txbStateId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbStateId.Width = 200;
            txbStateId.Margin = new Thickness(0, 10, 0, 10);
            txbStateId.Watermark = "State ID";
            st.Children.Add(txbStateId);
            txbCountryId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCountryId.Width = 200;
            txbCountryId.Watermark = "Country ID";
            txbCountryId.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbCountryId);
            txbStateCode = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbStateCode.Width = 200;
            txbStateCode.Watermark = "State Code";
            txbStateCode.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbStateCode);

            txbStateName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbStateName.Width = 200;
            txbStateName.Margin = new Thickness(0, 10, 0, 10);
            txbStateName.Watermark = "State Name";
            st.Children.Add(txbStateName);
            txbSTDCode = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbSTDCode.Width = 200;
            txbSTDCode.Watermark = "STD Code";
            txbSTDCode.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbSTDCode);
            txbCountryName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCountryName.Width = 200;
            txbCountryName.Watermark = "State Code";
            txbCountryName.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbCountryName);

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
