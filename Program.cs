// See https://aka.ms/new-console-template for more information

using Inventory_Management_System_Inventory;
using Inventory_Management_System_Product;

Console.WriteLine("Hello, World!");
Product product1 = new Product("table", 600, 2);
Product product2 = new Product("chair", 344, 4);
Inventory x = new Inventory();
x.AddProduct();
x.AddProduct();

x.ShowAllProducts();
x.SearchForProduct();
x.EditProduct();
x.ShowAllProducts();
x.SearchForProduct();
x.DeleteProduct();
x.ShowAllProducts();
