
using System;

namespace oop_03
{
    public class DeliveryCenter
    {
        private Shipment[] shipments;
        private int count;

        public string CenterName { get; set; }


        public Driver Driver { get; set; }

        public DeliveryCenter(string centerName, int capacity = 20)
        {
            CenterName = centerName;
            shipments = new Shipment[capacity];
            count = 0;
        }

        public Shipment this[int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= count)
                    return null;

                return shipments[index];
            }
            set
            {
                if (shipments != null && index >= 0 && index < count)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments == null) return null;

                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }
                return null;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null)
                shipments = new Shipment[20];

            if (count < shipments.Length)
            {
                shipments[count] = shipment;
                count++;
                return true;
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            if (shipments == null) return false;

            for (int i = 0; i < count; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }
                    shipments[count - 1] = null;
                    count--;
                    return true;
                }
            }
            return false;
        }


        public void PrintAllShipments()
        {
            Console.WriteLine($"Driver : {Driver?.FullName}");
            Console.WriteLine();
            Console.WriteLine(new string('-', 44));

            for (int i = 0; i < count; i++)
            {
                Shipment s = shipments[i];
                if (s == null) continue;

                Console.WriteLine();
                Console.WriteLine(GetFriendlyTypeName(s));
                Console.WriteLine();
                s.PrintShipment();
                Console.WriteLine();
                Console.WriteLine(new string('-', 44));
            }
        }

        internal static string GetFriendlyTypeName(object obj)
        {
            string name = obj.GetType().Name;
            return System.Text.RegularExpressions.Regex.Replace(name, "(\\B[A-Z])", " $1");
        }
    }
}