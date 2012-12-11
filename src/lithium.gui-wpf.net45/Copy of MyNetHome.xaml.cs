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
   /// Interaction logic for MyNetHome.xaml
   /// </summary>
   public partial class MyNetHome_old : Page {
      public MyNetHome_old() {
         InitializeComponent();
      }

      private void Button_Click_1(object sender, RoutedEventArgs e) {
         // View data entry page
         EntryPage entryPage = new EntryPage();
         this.NavigationService.Navigate(entryPage);
      }

      private void Button_Click_2(object sender, RoutedEventArgs e) {
         // View data entry page
         EntryPage entryPage = new EntryPage();
         this.NavigationService.Navigate(entryPage);
      }
   }
}
