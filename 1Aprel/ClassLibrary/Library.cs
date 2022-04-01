using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        public Product[] Products;
        public void AddProduct(Product product) 
        {
            Product[] Products = new Product[0];
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
            

        }
        public Product[] GetProductsByPrice(double MinPrice, double MaxPrice) 
        { 

            Product[] ProductForPrice = new Product[0];
            foreach (var product in Products)
            {

                if (product.Price > MinPrice && product.Price < MaxPrice)
                {
                    Array.Resize(ref ProductForPrice, ProductForPrice.Length + 1);
                    ProductForPrice[ProductForPrice.Length - 1] = product;
                }
            }
            return ProductForPrice;

        }

        public Product[] GetProductsByName(string ProductName) 
        {
            Product[] ProductForName = new Product[0];
            foreach (var product in Products)
            {
                
                if (product.Name == ProductName)
                {
                    Array.Resize(ref ProductForName, ProductForName.Length + 1);
                    ProductForName[ProductForName.Length - 1] = product;
                }
            }
            return ProductForName;

        }
    }
}
