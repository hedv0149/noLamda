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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace noLamda
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

        private void buttCFOR_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.CustomersFromOR();
        }

        private void buttPLT1000_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.AllExchangedPricesLessThan();
        }

        private void buttCFGA_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.CustomersFromGAAndTheirPurchases();
        }

        private void buttFiOAC_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.AllFirstNames();
        }

        private void buttFuOAC_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.AllFullNames();
        }

        private void buttS_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.AllStateAbbreviationsThatAreTheSame();
        }

        private void buttFTC_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.FirstThreeCustomers();
        }

        private void buttSCA_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.SortCustomersAlphabeticallyByFirstname();
        }

        private void buttSCBLOL_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.SortCustomersByLengthOfLastname();
        }

        private void buttSCBLOFNATBLN_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Program.SortCustomersFirstByLengthOfFirstNameAndThenByLastNameAlphabetically();
        }
    }
}
