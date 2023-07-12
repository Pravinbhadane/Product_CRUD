using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
  
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class ProductCRUD
    {

        private List<Product> productList;
        public ProductCRUD()
        {
            productList = new List<Product>();
        }
        
        public void AddProduct(Product prod)
        {
            productList.Add(prod);
        }


        public List<Product> GetProducts()
        {
            return productList;
        }

        public void UpdateProduct(Product prod)
        {
            foreach (Product p in productList)
            {
                if (p.Id == prod.Id)
                {
                   
                    p.Name = prod.Name;
                    p.Price = prod.Price;
                    break;
                }
            }
        }

        public void DeleteProduct(int id)
        {
            foreach (Product p in productList)
            {
                if (p.Id == id)
                {
                    productList.Remove(p);
                    break;
                }
            }
        }
    }

}
