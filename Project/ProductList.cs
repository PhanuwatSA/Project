using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ProductList
    {
        Product product;
        List<Product> products = new List<Product>();
        private string name;
        private int quantity;
        private double price;

        public void addperson2Class(Product p)
        {
            this.products.Add(p);
        }
    }
}
