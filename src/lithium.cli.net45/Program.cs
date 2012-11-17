using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lithium.cli.net45 {
   class Program {
      static void Main(string[] args) {
         try {
            using ( var db = new NetDbContext() ) {
               Console.Write("Enter a name for a new entry: ");
               var name = Console.ReadLine();
               var person = new Person
                               {
                                  PersonId = Guid.NewGuid(),
                                  Name = name,
                               };
               db.Persons.Add(person);
               db.SaveChanges();
               Console.WriteLine("Saved.");

               var query = from p in db.Persons
                           orderby p.Name
                           select p;

               Console.WriteLine("All persons in the database:");
               foreach ( var item in query ) {
                  Console.WriteLine(item.Name);
               }
            }
         }
         catch ( Exception ex ) {
            Console.WriteLine("==============================");
            Console.WriteLine(ex);
         }

         Console.WriteLine("Press any key to exit...");
         Console.ReadKey();
      }
   }
}
