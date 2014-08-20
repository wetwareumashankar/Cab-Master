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
    /// Interaction logic for CompanyMaster.xaml
    /// </summary>
    public partial class CompanyMaster : UserControl
    {
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCompanyId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCompanyName;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCompanyCode;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCountryId;

        Xceed.Wpf.Toolkit.WatermarkTextBox txbStateId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCityId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbDistrictId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbOwnerName;

        Xceed.Wpf.Toolkit.WatermarkTextBox txbOwnerEmailId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbOwnerPhone;

        Xceed.Wpf.Toolkit.WatermarkTextBox txbCompanyEmailId;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCompanyPhoneNo;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCompanyWebsite;
        Xceed.Wpf.Toolkit.WatermarkTextBox txbCompanyAddress;

        DataGrid dataGrid1;
        public CompanyMaster()
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
            txbCompanyId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCompanyId.Width = 200;
            txbCompanyId.Watermark = "Company ID";
            txbCompanyId.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbCompanyId);
            txbCompanyName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCompanyName.Width = 200;
            txbCompanyName.Watermark = "Company Name";
            txbCompanyName.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbCompanyName);

            txbCompanyCode = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCompanyCode.Width = 200;
            txbCompanyCode.Margin = new Thickness(0, 10, 0, 10);
            txbCompanyCode.Watermark = "Company Code";
            st.Children.Add(txbCompanyCode);

            txbCountryId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCountryId.Width = 200;
            txbCountryId.Margin = new Thickness(0, 10, 0, 10);
            txbCountryId.Watermark = "Country Id";
            st.Children.Add(txbCountryId);
            txbStateId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbStateId.Width = 200;
            txbStateId.Watermark = "State Id";
            txbStateId.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbStateId);
            txbDistrictId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbDistrictId.Width = 200;
            txbDistrictId.Watermark = "District Id";
            txbDistrictId.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbDistrictId);

            txbOwnerName = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbOwnerName.Width = 200;
            txbOwnerName.Margin = new Thickness(0, 10, 0, 10);
            txbOwnerName.Watermark = "Owner Name";
            st.Children.Add(txbOwnerName);

            txbOwnerEmailId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbOwnerEmailId.Width = 200;
            txbOwnerEmailId.Margin = new Thickness(0, 10, 0, 10);
            txbOwnerEmailId.Watermark = "Owner Email";
            st.Children.Add(txbOwnerEmailId);
            txbOwnerPhone = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbOwnerPhone.Width = 200;
            txbOwnerPhone.Watermark = "Owner Phone";
            txbOwnerPhone.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbOwnerPhone);
            txbCompanyEmailId = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCompanyEmailId.Width = 200;
            txbCompanyEmailId.Watermark = "Company Email Id";
            txbCompanyEmailId.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbCompanyEmailId);

            txbCompanyAddress = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCompanyAddress.Width = 200;
            txbCompanyAddress.Margin = new Thickness(0, 10, 0, 10);
            txbCompanyAddress.Watermark = "Company Address";
            st.Children.Add(txbCompanyAddress);

            txbCompanyPhoneNo = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCompanyPhoneNo.Width = 200;
            txbCompanyPhoneNo.Watermark = "Company Phone Number";
            txbCompanyPhoneNo.Margin = new Thickness(0, 10, 0, 10);
            st.Children.Add(txbCompanyPhoneNo);

            txbCompanyWebsite = new Xceed.Wpf.Toolkit.WatermarkTextBox();
            txbCompanyWebsite.Width = 200;
            txbCompanyWebsite.Margin = new Thickness(0, 10, 0, 10);
            txbCompanyWebsite.Watermark = "Company Website";
            st.Children.Add(txbCompanyWebsite);

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
