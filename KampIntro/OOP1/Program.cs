﻿// See https://aka.ms/new-console-template for more information
using OOP1;
ProductManager productManager = new ProductManager();

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 2;

Product product2 = new Product { Id=2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=35};


