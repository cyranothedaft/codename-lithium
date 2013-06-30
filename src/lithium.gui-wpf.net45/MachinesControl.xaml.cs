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
using lithium.core.lib.net45.Data;



namespace lithium.gui_wpf.net45 {
   /// <summary>
   /// Interaction logic for MachinesControl.xaml
   /// </summary>
   public partial class MachinesControl : UserControl {
      public MachinesControl() {
         InitializeComponent();

         loadMachines();
      }


      private void loadMachines() {
         using ( var db = new NetDbContext() ) {
            foreach ( Machine machine in db.Machines ) {
               MachinesPanel.
            }
         }
      }
   }
}
