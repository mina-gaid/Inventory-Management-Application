using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models
{
    public class Product
    {
        private ICollection<Supplier> _supplier;

        public Product()
        {
            _supplier = new List<Supplier>();
        }

        public string ProductId { get; set; }
        public string SupplierId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Supplier> Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
    }
}