using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lithium.cli.net45.EF6;



namespace lithium.cli.net45 {
   class DataEntryPoc {
      public static void Simple1() {
         try {
            using ( var db = new Model1Container() ) {
               Console.Write("Enter a new Entity1 name: ");
               var newValue = Console.ReadLine();

               Entity1 newEntity1= new Entity1()
                               {
                                  Id = Guid.NewGuid(),
                                  Name = newValue,
                               };
               db.Entity1.Add(newEntity1);
               db.SaveChanges();
               Console.WriteLine("Saved.");

               var query = from e in db.Entity1
                           orderby e.Name
                           select e;

               Console.WriteLine("All Entity1's in the database:");
               foreach ( var item in query ) {
                  Console.WriteLine(item.Name);
               }
            }
         }
         catch ( Exception ex ) {
            Console.WriteLine("==============================");
            Console.WriteLine(ex);
         }
      }
   }
}
