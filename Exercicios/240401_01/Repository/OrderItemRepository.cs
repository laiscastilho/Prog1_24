using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class OrderItemRepository
    {
       public void Save(OrderItem orderitem)
        {
            DataSet.OrderItems.Add(orderitem);        
        }

        public OrderItem Retrieve(int id)
        {
            foreach(var item in DataSet.OrderItems)
            {
                if(item.Id == id )
                    return item;
            }

            return null;
        }

        public bool Validate()
        {
            return true;
        }
    }
}