using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using E_commerce.Models;

namespace E_commerce
{
    /// <summary>
    /// Summary description for EcomService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]

    public class EcomService : System.Web.Services.WebService
    {
        private EcommerceContext db = new EcommerceContext();

        [WebMethod]
        public string[] GetSuppliersByName(string namePart)
        {
            List<string> suppliers = new List<string>();
            if (namePart !="")
            {
                foreach (var supplier in db.Suppliers
                                           .Where(a => a.Name.Contains(namePart))
                                           .ToList())
                {
                    suppliers.Add(supplier.Name);
                }
            }

            return suppliers.ToArray();
        }

        [WebMethod]
        public string[] GetSuppliersByProductId(string idPart)
        {
            List<string> suppliers = new List<string>();
            if (idPart != "")
            {
                foreach (var supplier in db.Suppliers
                                           .Where(a => a.ProductId.Contains(idPart))
                                           .ToList())
                {
                    suppliers.Add(supplier.ProductId);
                }
            }

            return suppliers.ToArray();
        }

        [WebMethod]
        public string[] GetProductByName(string namePart)
        {
            List<string> products = new List<string>();
            if (namePart != "")
            {
                foreach (var product in db.Products
                                           .Where(a => a.Name.Contains(namePart))
                                           .ToList())
                {
                    products.Add(product.Name);
                }
            }

            return products.ToArray();
        }

        [WebMethod]
        public string[] GetProductById(string idPart)
        {
            List<string> products = new List<string>();
            if (idPart != "")
            {
                foreach (var product in db.Products
                                           .Where(a => a.ProductId.Contains(idPart))
                                           .ToList())
                {
                    products.Add(product.ProductId);
                }
            }

            return products.ToArray();
        }

        [WebMethod]
        public string[] GetCustomerById(string idPart)
        {
            List<string> customers = new List<string>();
            if (idPart != "")
            {
                foreach (var customer in db.Customers
                                           .Where(a => a.CustomerId.Contains(idPart))
                                           .ToList())
                {
                    customers.Add(customer.CustomerId);
                }
            }

            return customers.ToArray();
        }
    }
}
