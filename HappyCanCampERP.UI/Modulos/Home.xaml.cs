using System.Configuration;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace HappyCanCampERP.UI.Modulos
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void PhoneButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start(ConfigurationManager.AppSettings["GitHub"]);
        }

        private void TwitterButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://twitter.com/happycancamp");
        }

        private void GoogleButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://google.com");
        }

        private void EmailButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("mailto://eduardo@zerecero.com");
        }

        //private void DonateButton_OnClick(object sender, RoutedEventArgs e)
        //{
        //    Process.Start("https://pledgie.com/campaigns/31029");
        //}
    }
}
