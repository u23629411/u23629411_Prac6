using System.Collections.Generic;

namespace ProductList.Models
    {
    public class ProductRepository
        {//create and add your list of suppliers
        public static List<Supplier> GetSuppliers()
        {
            return new List<Supplier>
            {
                new Supplier{ID=1,Name="Destiny's Sipplies"},
                new Supplier{ID=2,Name="Karabo's Sipplies"},
                new Supplier{ID=3,Name="Nomvuyo's Sipplies"},
                new Supplier{ID=4,Name="Shirley's Sipplies"},
      
            };
        }
        public static List<Category> GetCategories()
            {
            return new List<Category>
    {
        new Category { Id = 1, Name = "Category 1",SupplierID=1 },
        new Category { Id = 2, Name = "Category 2",SupplierID=2 },
        new Category { Id = 3, Name = "Category 3" , SupplierID = 3},
        new Category { Id = 4, Name = "Category 4",SupplierID = 4 },
        new Category { Id = 5, Name = "Category 5" , SupplierID = 3},
    };
            }

        public static List<Product> GetProducts()
            {
            return new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", CategoryId = 1 },
        new Product { Id = 2, Name = "Product 2", CategoryId = 1 },
        new Product { Id = 3, Name = "Product 3", CategoryId = 2 },
        new Product { Id = 4, Name = "Product 4", CategoryId = 3 },
        new Product { Id = 5, Name = "Product 5", CategoryId = 3 },
        new Product { Id = 6, Name = "Product 6", CategoryId = 4 },
        new Product { Id = 7, Name = "Product 7", CategoryId = 4 },
        new Product { Id = 8, Name = "Product 8", CategoryId = 4 },
        new Product { Id = 9, Name = "Product 9", CategoryId = 5 },
        new Product { Id = 10, Name = "Product 10", CategoryId = 5 },
        new Product { Id = 11, Name = "Product 11", CategoryId = 5 },
    };
            }
        }
    }