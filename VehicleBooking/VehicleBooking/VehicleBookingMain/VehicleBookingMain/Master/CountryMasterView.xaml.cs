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
    /// Interaction logic for CountryMasterView.xaml
    /// </summary>
    public partial class CountryMasterView : UserControl
    {
        DataGrid dataGrid1;
        public CountryMasterView()
        {
            InitializeComponent();
            dataGrid1 = new DataGrid();
            dataGrid1.AutoGenerateColumns = true;
            dataGrid1.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            dataGrid1.Margin = new Thickness(10);
            dataGrid1.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            grdField.Children.Add(dataGrid1);
            Grid.SetColumn(dataGrid1, 1);
            //BindGrid();
            loadField();
        }
        void loadField()
        {
            StackPanel st = new StackPanel();
            Xceed.Wpf.Toolkit.WatermarkTextBox water = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            water.Width = 200;
            water.Margin = new Thickness(0, 10, 0,10);
            water.Watermark = "Country Code";
            st.Children.Add(water);
            Xceed.Wpf.Toolkit.WatermarkTextBox water2 = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            water2.Width = 200;
            water2.Watermark = "Country Name";
            water2.Margin = new Thickness(0, 10,0,10);
            st.Children.Add(water2);
            Xceed.Wpf.Toolkit.WatermarkTextBox water3 = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            water3.Width = 200;
            water3.Watermark = "ISD Code";
            water3.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(water3);
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

            btcncle.Margin = new Thickness(30,0 , 0,0);
            stpanal.Children.Add(bt);
            stpanal.Children.Add(btcncle);
           
            st.Children.Add(stpanal);


            grdField.Children.Add(st);
        }

        void bt_Click(object sender, RoutedEventArgs e)
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
        private void button1_Click(object sender, RoutedEventArgs e)
        {
           
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
