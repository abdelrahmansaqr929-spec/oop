using System;
using System.Collections.Generic;
using System.Text;

namespace oop_03
{
 
        public sealed class CompletedShipment : Shipment
        {
            public DateTime CompletionDate { get; set; }

            public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, DateTime completionDate)
                : base(trackingCode, description, weight, deliveryFee, destination)
            {
                CompletionDate = completionDate;
            }

            public override void PrintShipment()
            {
                Console.WriteLine($"Tracking Code   : {TrackingCode}");
                Console.WriteLine($"Description     : {Description}");
                Console.WriteLine($"Weight          : {Weight} KG");
                Console.WriteLine($"Delivery Fee    : {DeliveryFee} EGP");
                Console.WriteLine($"Estimated Cost  : {EstimatedCost} EGP");
                Console.WriteLine($"Completion Date : {CompletionDate:d}");
            }
        }
    
}
