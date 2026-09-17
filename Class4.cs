using System;
using System.Collections.Generic;
using System.Text;

namespace oop_03
{
   public class ExpressShipment : Shipment
        {
            private decimal extraFee;

            public decimal ExtraFee
            {
                get { return extraFee; }
                set
                {
                    if (value >= 0)
                        extraFee = value;
                }
            }

            public override decimal EstimatedCost
            {
                get { return DeliveryFee + (Weight * 5) + ExtraFee; }
            }

            public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
                : base(trackingCode, description, weight, deliveryFee, destination)
            {
                ExtraFee = extraFee;
            }

            public override void PrintShipment()
            {
                Console.WriteLine($"Tracking Code : {TrackingCode}");
                Console.WriteLine($"Description   : {Description}");
                Console.WriteLine($"Weight        : {Weight} KG");
                Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
                Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
                Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            }
        }
}  



