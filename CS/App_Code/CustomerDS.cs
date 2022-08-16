using System;
using System.Web;
using System.Linq;
using NorthwindModel;
using System.Collections.Generic;

public class CustomerDS
{
    public List<Customer> GetCustomers(int startIndex, int maxRows)
    {
        using (NorthwindEntities entities = new NorthwindEntities())
        {
            return (from customer in entities.Customers
                    select customer)
                        .OrderBy(customer => customer.CustomerID)
                        .Skip(startIndex)
                        .Take(maxRows).ToList();
        }
    }

    public int GetCustomersCount()
    {
        using (NorthwindEntities entities = new NorthwindEntities())
        {
            return entities.Customers.Count();
        }
    }
}