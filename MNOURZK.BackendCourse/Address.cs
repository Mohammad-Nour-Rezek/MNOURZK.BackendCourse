using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics
{
    internal class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }

        public Address()
        {
            
        }

        public Address(string country, string city, string postalCode, string streetName, string streetNumber, float longitude = 0, float latitude = 0)
        {
            Country = country;
            City = city;
            PostalCode = postalCode;
            StreetName = streetName;
            StreetNumber = streetNumber;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
