using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Xceed.Wpf.Toolkit;
using lithium.core.lib.net45.Data;



namespace lithium.gui_wpf.net45 {
   /// <summary>
   /// Interaction logic for EntryPage.xaml
   /// </summary>
   public partial class EntryPage : Page {
      public EntryPage() {
         InitializeComponent();
         entryElementsPanel.Visibility = Visibility.Hidden;
         entryDetailPanelMac.Visibility = Visibility.Hidden;
         entryDetailPanelModel.Visibility = Visibility.Hidden;
         entryDetailPanelOwner.Visibility = Visibility.Hidden;
         entryDetailPanelName.Visibility = Visibility.Hidden;
         btnSaveNewDevice.IsEnabled = false;

         entryElementsPanel.Visibility = Visibility.Visible;


         // initialize device mfgr list
         initMfgrList();
      }


      private void initMfgrList() {
         using ( var db = new NetDbContext() ) {
//            foreach ( var item in db.Mfgrs ) {
//               cboNewDeviceMfgr.Items.Add(new ComboBoxItem() { Content = item.Name });
//               cboNewDeviceModelMfgr.Items.Add(new ComboBoxItem() { Content = item.Name });
//            }
         }
      }


      //
//      private void btnNewDevice_Checked(object sender, RoutedEventArgs e) {
//         //dataEntryUiGrid.ColumnDefinitions[0].Width = new GridLength(20);
//         //dataEntryUiGrid.ColumnDefinitions[1].Width = new GridLength(150);
//
//         entryElementsPanel.Visibility = Visibility.Visible;
//      }


      private void btnDeviceValueMac_Click(object sender, RoutedEventArgs e) {
         //dataEntryUiGrid.ColumnDefinitions[1].Width = new GridLength(20);
         //dataEntryUiGrid.ColumnDefinitions[2].Width = new GridLength(150);

         btnDeviceValueMac.IsEnabled = false;
         btnAcceptEntryMac.IsEnabled = false;
         entryDetailPanelMac.Visibility = Visibility.Visible;
         txtMac.Focus();
      }


      private void btnDeviceValueMfgr_Click(object sender, RoutedEventArgs e) {
         btnDeviceValueMfgr.IsEnabled = false;
         btnAcceptEntryMfgr.IsEnabled = true;
         entryDetailPanelMfgr.Visibility = Visibility.Visible;
      }


      private void btnNewMfgr_Click(object sender, RoutedEventArgs e) {
         //===
      }


      private void btnDeviceValueModel_Click(object sender, RoutedEventArgs e) {
         btnDeviceValueModel.IsEnabled = false;
         btnAcceptEntryModel.IsEnabled = true;
         entryDetailPanelModel.Visibility = Visibility.Visible;
      }


      private void btnDeviceValueOwner_Click(object sender, RoutedEventArgs e) {
         btnDeviceValueOwner.IsEnabled = false;
         btnAcceptEntryOwner.IsEnabled = true;
         entryDetailPanelOwner.Visibility = Visibility.Visible;
      }


      private void btnDeviceValueName_Click(object sender, RoutedEventArgs e) {
         btnDeviceValueName.IsEnabled = false;
         btnAcceptEntryName.IsEnabled = true;
         entryDetailPanelName.Visibility = Visibility.Visible;
      }


      private void txtMac_TextChanged(object sender, TextChangedEventArgs e) {
         if ( lblMacValue != null && txtMac != null ) {
            if ( !txtMac.IsMaskCompleted ) {
               lblMacValue.Content = "- incomplete -";
               btnAcceptEntryMac.IsEnabled = false;
            }
            else if ( !isValidMac(txtMac) ) {
               lblMacValue.Content = "- invalid -";
               btnAcceptEntryMac.IsEnabled = false;
            }
            else {
               lblMacValue.Content = txtMac.Text;
               btnAcceptEntryMac.IsEnabled = true;
            }
         }
      }


      private bool isValidMac(MaskedTextBox maskedTextBox) {
         bool isValid = maskedTextBox.IsMaskCompleted;
         if ( isValid ) {
            isValid = !maskedTextBox.Text.Any(c => ( c > 'F' && c <= 'Z' || c > 'f' && c <= 'z' ));
         }
         return isValid;
      }


      private void btnAcceptEntryMac_Click(object sender, RoutedEventArgs e) {
         entryDetailPanelMac.Visibility = Visibility.Hidden;
         btnDeviceValueMac.Content = lblMacValue.Content;
         btnDeviceValueMac.IsEnabled = true;
      }

      private void btnAcceptEntryMfgr_Click(object sender, RoutedEventArgs e) {
         entryDetailPanelMfgr.Visibility = Visibility.Hidden;
         btnDeviceValueMfgr.Content = lblMfgrValue.Content;
         btnDeviceValueMfgr.IsEnabled = true;
      }

      private void btnAcceptEntryModel_Click(object sender, RoutedEventArgs e) {
         entryDetailPanelModel.Visibility = Visibility.Hidden;
         btnDeviceValueModel.Content = lblModelValue.Content;
         btnDeviceValueModel.IsEnabled = true;
      }

      private void btnAcceptEntryOwner_Click(object sender, RoutedEventArgs e) {
         entryDetailPanelName.Visibility = Visibility.Hidden;
         btnDeviceValueName.Content = lblNameValue.Content;
         btnDeviceValueName.IsEnabled = true;
      }

      private void btnAcceptEntryName_Click(object sender, RoutedEventArgs e) {
         entryDetailPanelName.Visibility = Visibility.Hidden;
         btnDeviceValueName.Content = lblNameValue.Content;
         btnDeviceValueName.IsEnabled = true;
      }

      private void btnSaveNewDevice_Click(object sender, RoutedEventArgs e) {

      }

      private void cboNewDeviceMfgr_SelectionChanged(object sender, SelectionChangedEventArgs e) {
         Debug.WriteLine("cboNewDeviceMfgr_SelectionChanged : ({0}) \"{1}\"", cboNewDeviceMfgr.SelectedIndex, cboNewDeviceMfgr.Text, "===..." );
      }
   }
}
