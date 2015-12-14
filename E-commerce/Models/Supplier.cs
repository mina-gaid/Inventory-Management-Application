using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models
{
    public class Supplier
    {
        private ICollection<Product> _product;

        public Supplier()
        {
            _product = new List<Product>();
        }

        public string SupplierId { get; set; }
        public string Name { get; set; }
        public string ProductId { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Product> Product
        {
            get { return _product; }
            set { _product = value; }
        }
    }
}