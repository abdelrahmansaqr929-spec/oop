using System;
using System.Collections.Generic;
using System.Text;

namespace oop_03
{
    public struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BulidingNumber;

        public DeliveryAddress(string city, string street, int bn)
        {
            City = city;
            Street = street;
            BulidingNumber = bn;
        }

        public string GetFullAddress()
        {
            return $"{BulidingNumber} {Street} St., {City}";
        }
    }
}
