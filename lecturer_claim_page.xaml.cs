using Contract_Monthly_Claim_System.Models;
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
using System.Windows.Shapes;
using Contract_Monthly_Claim_System.Models; // Import the namespace where your model is located


namespace Contract_Monthly_Claim_System
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Lecturer_Claim_Page : Window
    {
        public Lecturer_Claim_Page()
        {
            InitializeComponent();
            // Bind data to the DataGrid on startup
            MyDataGrid.ItemsSource = GetData();
        }

        private void btn_logout_click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            this.Visibility = Visibility.Hidden;
            obj.Show();
        }

        // Method to return data
        public List<MyDataRow> GetData()
        {
            return new List<MyDataRow>
            {
                new MyDataRow { Column1 = "", Column2 = "", Column3 = "", Column4 = "", Column5 = "", Column6 = "", Column7 = "", Column8 = ""},
                new MyDataRow { Column1 = "", Column2 = "", Column3 = "", Column4 = "", Column5 = "", Column6 = "", Column7 = "", Column8 = ""}
            };
        }

        private void btn_historical_claims_click(object sender, RoutedEventArgs e)
        {
            lecturer_historical_claims_page obj = new lecturer_historical_claims_page();
            this.Visibility = Visibility.Hidden;
            obj.Show();
        }
    }
}
