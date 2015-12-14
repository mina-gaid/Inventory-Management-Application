using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models
{
    public class Customer
    {
        private ICollection<Product> _product;

        public Customer()
        {
            _product = new List<Product>();
        }

        public string CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public DateTime Joined { get; set; }

        public virtual ICollection<Product> Product
        {
            get { return _product; }
            set { _product = value; }
        }
    }
}