
using System;

namespace oop_03
{
    public static class DeliveryHelper
    {

        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment == null) return;

            shipment.PrintShipment();
            Console.WriteLine($"{DeliveryCenter.GetFriendlyTypeName(shipment)} Printed Successfully.");
            Console.WriteLine();
        }
    }
}