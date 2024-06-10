using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlModels
{
    public class BLAllPhotographer
    {
        public BLAllPhotographer(string? firstName, string lastName, BLPrice priceCodeNavigation, ICollection<Customer> customers)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PriceCodeNavigation = priceCodeNavigation;
            this.Customers = customers;
        }
        public string? FirstName { get; set; }

        public string LastName { get; set; } = null!;

        public virtual BLPrice PriceCodeNavigation { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();


    }
}

