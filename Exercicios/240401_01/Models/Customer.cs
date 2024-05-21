using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace _240401_01.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

        public override string ToString()
        {
            return $"{CustomerId} - {this.Name} - {EmailAddress}";
        }

        public Customer()
        {
            
        }

        public Customer(int id)
        {
            CustomerId = id;
        }

        public bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(Name)) 
                isValid = false;

            return isValid;
        }
    }
}