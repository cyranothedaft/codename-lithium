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

namespace lithium.gui_wpf.net45 {
   /// <summary>
   /// Interaction logic for EntryPage.xaml
   /// </summary>
   public partial class EntryPage : Page {
      public EntryPage() {
         InitializeComponent();
         txtProgress.Text = "";
      }

      private void btnNewDevice_Checked(object sender, RoutedEventArgs e) {
         dataEntryUiGrid.ColumnDefinitions[0].Width = new GridLength(20);
         dataEntryUiGrid.ColumnDefinitions[1].Width = new GridLength(150);
         txtProgress.Text += "New device...\r\n";
      }

      private void btnNewDeviceByMac_Click(object sender, RoutedEventArgs e) {
         dataEntryUiGrid.ColumnDefinitions[1].Width = new GridLength(20);
         dataEntryUiGrid.ColumnDefinitions[2].Width = new GridLength(150);
         txtProgress.Text += "MAC address\r\n";
      }


      private void txtMac_TextChanged(object sender, TextChangedEventArgs e) {
         if ( lblMacValue != null && txtMac != null )
            lblMacValue.Content = txtMac.Text;
      }
   }
}
