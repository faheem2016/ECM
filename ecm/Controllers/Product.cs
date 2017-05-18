using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ecm.Models;

namespace ecm.Controllers
{
    public class Product
    {
        private item prod = new item();
        private int quantity;

        public Product()
        {

        }

        public Product(item product, int quantity)
        {
            this.prod = product;
            this.Quantity = quantity;
        }

        public item Prod
        {
            get
            {
                return prod;
            }

            set
            {
                prod = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}