using System;
using System.Collections.Generic;
using System.Text;

namespace oop_03
{

        public class Shipment
        {
            private string trackingCode;
            private string description;
            private decimal weight;
            private decimal deliveryFee;

            public DeliveryAddress Destination { get; set; }

            public string TrackingCode
            {
                get { return trackingCode; }
                private set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        trackingCode = value;
                }
            }

            public string Description
            {
                get { return description; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        description = value;
                }
            }

            public decimal Weight
            {
                get { return weight; }
                set
                {
                    if (value > 0)
                        weight = value;
                }
            }

            public decimal DeliveryFee
            {
                get { return deliveryFee; }
                private set
                {
                    if (value > 0)
                        deliveryFee = value;
                }
            }

            public virtual decimal EstimatedCost
            {
                get { return DeliveryFee + (Weight * 5); }
            }

            public Shipment(string trackingCode)
            {
                this.trackingCode = "DEFAULT";
                this.description = "Unknown";
                this.weight = 1;
                this.deliveryFee = 50;
                Destination = new DeliveryAddress();
                TrackingCode = trackingCode;
            }

            public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            {
                this.trackingCode = "DEFAULT";
                this.description = "Unknown";
                this.weight = 1;
                this.deliveryFee = 50;

                TrackingCode = trackingCode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;
                Destination = destination;
            }

            // Overload 1
            public void UpdateWeight(decimal newWeight)
            {
                if (newWeight > 0)
                {
                    Weight = newWeight;
                }
            }

            // Overload 2
            public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
            {
                if (newWeight > 0 && extraPackingWeight >= 0)
                {
                    Weight = newWeight + extraPackingWeight;
                }
            }

            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                {
                    DeliveryFee = newFee;
                }
            }

            public virtual void PrintShipment()
            {
                Console.WriteLine($"Tracking Code : {TrackingCode}");
                Console.WriteLine($"Description   : {Description}");
                Console.WriteLine($"Weight        : {Weight} KG");
                Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
                Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
}      
    }
}

