using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class CustomerRepository
    {
        public void Save(Customer customer)
        {
            customer.CustomerId = this.GetNextId();
            DataSet.Customers.Add(customer);        
        }

        public Customer Retrieve(int id)
        {
            foreach(var c in DataSet.Customers)
            {
                if(c.CustomerId == id )
                    return c;
            }

            return null;
        }

        public List<Customer> Retrieve()
        {
            return DataSet.Customers;
        }

        public List<Customer> RetrieveByName(string name)
        {
            List<Customer> retorno = new List<Customer>();
            foreach(var c in DataSet.Customers)
            {
                if(c.Name.Contains(name)) 
                {
                    retorno.Add(c);
                }
            }

            return retorno;
        }

        private int GetNextId()
        {
            int n = 0;
            foreach(var c in DataSet.Customers)
            {
                if(c.CustomerId > n)
                    n = c.CustomerId;
            }

            return ++n;
        }
    }
}