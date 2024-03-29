﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductTest();
//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

    var result = productManager.GetProductDetail();

    if (result.Success)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}

//static void CategoryTest()
//{
//    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//    foreach (var category in categoryManager.GetAll())
//    {
//        Console.WriteLine(category.CategoryName);
//    }
//}