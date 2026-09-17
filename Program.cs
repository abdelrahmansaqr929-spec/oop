
using System.Numerics;
using System.Text;
using System.Timers;
using System.Xml.Linq;

namespace oop_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer_01
            //Overloading: Same method name, different parameters, in the same class. Resolved at compile time.
            //Overriding: Redefining a base class method in a derived class with the same signature, using virtual/override. Resolved at runtime
            //Static Binding: Compiler decides which method to call at compile time (used with normal/overloaded methods).
            // Dynamic Binding: Decided at runtime based on the actual object type(used with overridden/virtual methods
            //Purpose of sealed on a class,Prevents any other class from inheriting from it.
            //Sealed class: No class can inherit from it 
            //Sealed method: A specific overridden method that can't be overridden further by any subclass. It must already be an override method.
            //No. Its whole purpose is to stop the overriding chain at that point — once sealed, no further class can change it.
            #endregion
            #region answer_02
         

                Driver driver = new Driver("D001", "Ahmed Mohamed", "01012345678");

                DeliveryCenter center = new DeliveryCenter("Cairo Main Center");
                center.Driver = driver;
                DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Tahrir St", 12);
                StandardShipment standard = new StandardShipment("SH001", "Laptop", 3, 80, addr1);
                DeliveryAddress addr2 = new DeliveryAddress("Giza", "Haram St", 45);
                ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, addr2, 30);
                DeliveryAddress addr3 = new DeliveryAddress("Berlin", "Alexanderplatz", 7);
                InternationalShipment international = new InternationalShipment("SH003", "Television", 8, 120, addr3, "Germany", 100);
                center.AddShipment(standard);
                center.AddShipment(express);
                center.AddShipment(international);
                center.PrintAllShipments();
                Console.WriteLine(new string('=', 44));
                Console.WriteLine("Printing Using DeliveryHelper...");
                Console.WriteLine();
            DeliveryHelper.PrintShipmentDetails(standard);
                DeliveryHelper.PrintShipmentDetails(express);
                DeliveryHelper.PrintShipmentDetails(international);
                Console.WriteLine(new string('=', 44));
                Console.WriteLine("Updating Weight...");
                Console.WriteLine();
                Console.WriteLine($"Original Weight : {standard.Weight} KG");

                standard.UpdateWeight(5);
                Console.WriteLine($"Updated Weight : {standard.Weight} KG");

                standard.UpdateWeight(5, 0.5m);              
                Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");
                Console.WriteLine();
                Console.WriteLine(new string('=', 44));
                Console.WriteLine("Printing Using Shipment[]...");
                Console.WriteLine();
                Shipment[] mixedShipments = { standard, express, international };
                foreach (Shipment s in mixedShipments)
                {
                    Console.WriteLine($"{DeliveryCenter.GetFriendlyTypeName(s)}...");
                    Console.WriteLine();
                    s.PrintShipment();
                    Console.WriteLine();
                }
                Console.WriteLine(new string('=', 44));
                Console.WriteLine("Sealed Class & Sealed Method Demo...");
                Console.WriteLine();
                CompletedShipment completed = new CompletedShipment("SH001-DONE", "Laptop", 3, 80, addr1, DateTime.Now);
                completed.PrintShipment();
                Console.WriteLine();
                PriorityInternationalShipment priority = new PriorityInternationalShipment(
                    "SH004", "Medical Supplies", 4, 120, addr3, "France", 90);
                priority.GenerateCustomsReport();

                Console.WriteLine();
                Console.WriteLine("Done.");
            #endregion

        }
    }
}

