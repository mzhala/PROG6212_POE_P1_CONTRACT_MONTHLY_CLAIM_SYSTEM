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

namespace Contract_Monthly_Claim_System
{
    /// <summary>
    /// Interaction logic for Claim_Review_Historical_Page.xaml
    /// </summary>
    public partial class Claim_Review_Historical_Page : Window
    {
        public Claim_Review_Historical_Page()
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

        private void btn_back_click(object sender, RoutedEventArgs e)
        {
            Claim_Review_Page obj = new Claim_Review_Page();
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
    }
}
