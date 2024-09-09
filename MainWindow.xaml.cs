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

namespace Contract_Monthly_Claim_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_lecture_click(object sender, RoutedEventArgs e)
        {
            Lecturer_Claim_Page obj = new Lecturer_Claim_Page();
            this.Visibility = Visibility.Hidden;
            obj.Show();
        }

        private void btn_management_click(object sender, RoutedEventArgs e)
        {
            Claim_Review_Page obj = new Claim_Review_Page();
            this.Visibility = Visibility.Hidden;
            obj.Show();
        }
    }
}