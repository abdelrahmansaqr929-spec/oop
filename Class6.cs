using System;
using System.Collections.Generic;
using System.Text;

namespace oop_03
{
 
        public class Driver
        {
            private string driverId;
            private string fullName;
            private string phoneNumber;

            public string DriverId
            {
                get { return driverId; }
                private set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        driverId = value;
                }
            }

            public string FullName
            {
                get { return fullName; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        fullName = value;
                }
            }

            public string PhoneNumber
            {
                get { return phoneNumber; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        phoneNumber = value;
                }
            }

            public Driver(string driverId, string fullName, string phoneNumber)
            {
                DriverId = driverId;
                FullName = fullName;
                PhoneNumber = phoneNumber;
            }

            public override string ToString()
            {
                return $"Driver ID: {DriverId}, Name: {FullName}, Phone: {PhoneNumber}";
            }
        }
    
}
