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

namespace Procapita
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentState=0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwitchState(int newState) {
            switch (newState) {
                case 0: // just logged on. Mina Sidor is displaying
                    break;
                case 1: // after selecting Mina Brukare
                    break;
                case 2: // successfully sought someone. Their info is displaying
                    break;
                default:
                    break;
            }

            currentState = newState;
        }

        private void btnSearchByPersonalNumber_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string pNumber = txtPersonNr.Text;
                if (pNumber.Length==11) pNumber = txtYear.Text.ToString() + pNumber;
                if (pNumber.Equals("19391025-7246"))
                {
                    this.Title = "Procapita VoO " + pNumber + " - Kundsson, Kund";
                }
                else
                {
                    //MessageBox.Show("Brukare hittades inte!", "Inga Resultat");
                }
                tvUsers.Items.Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            };
        }

        private void tglMyUsers_Checked(object sender, RoutedEventArgs e)
        {
            tglMyPages.IsChecked = false;
            tglMyCases.IsChecked = false;
            
            
        }

        private void tglMyPages_Checked(object sender, RoutedEventArgs e)
        {
            tglMyUsers.IsChecked = false;
            tglMyCases.IsChecked = false;
        }

        private void tglMyCases_Checked(object sender, RoutedEventArgs e)
        {
            tglMyPages.IsChecked = false;
            tglMyUsers.IsChecked = false;
        }
    }
}
