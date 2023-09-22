﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetByUnitPrice(20,100))
{
    Console.WriteLine(product.ProductName);
}