// See https://aka.ms/new-console-template for more information
using OOP1;

Console.WriteLine("Hello, World!");
Product product1= new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "sandalye";
product1.UnitPrice = 10;
product1.UnitInStock = 12;

//farklı bir kullanım asagıda
Product product2 = new Product { Id = 2, ProductName = "dolap", 
    UnitPrice = 5,UnitInStock=3,CategoryId=9};

ProductManager productManager=new ProductManager();
productManager.Add(product2);
