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

namespace BeachStores_Float_Calculator
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double safe = double.Parse(txtbxSafe.Text);
            double fiftyCentPot = double.Parse(txtbxPots.Text);
            double baggedCoins = double.Parse(txtbxBaggedCoins.Text);
            double book = double.Parse(txtbxBook.Text);

            //Use number of notes * their value
            double fiftyNotes = (double.Parse(txtbx50E.Text) * 50);
            double twentyNotes = (double.Parse(txtbx20E.Text) * 20);
            double tenNotes = (double.Parse(txtbx10E.Text) * 10);
            double fiveNotes = (double.Parse(txtbx5E.Text) * 5);


            double twoEuro = double.Parse(txtbx2E.Text);
            double oneEuro = double.Parse(txtbx1E.Text);
            double fiftyCent = double.Parse(txtbx50C.Text);
            double twentyCent = double.Parse(txtbx20C.Text);
            double tenCent = double.Parse(txtbx10C.Text);
            double fiveCent = double.Parse(txtbx5C.Text);
            double twoCent = double.Parse(txtbx2C.Text);
            double oneCent = double.Parse(txtbx1C.Text);
            double voucher = double.Parse(txtbxVoucher.Text);
            double PrintedTickets = double.Parse(txtbxPrintedTicket.Text);
            double roulette = double.Parse(txtbxRoulette.Text);
            double sterling = double.Parse(txtbxSterling.Text);

            double total = (safe+fiftyCentPot+baggedCoins+book+fiftyNotes+twentyNotes+tenNotes+fiveNotes+twoEuro+oneEuro+fiftyCent+twentyCent+tenCent+fiveCent+twoCent+oneCent+voucher+PrintedTickets+roulette+sterling);

            txtblTotal.Text = $"{total:C}";


        }
    }
}
