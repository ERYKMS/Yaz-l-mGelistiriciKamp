// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
foreach (var category in categoryManager.GettAll())
{
    Console.WriteLine(category.CategoryName);
    
}
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    var result = productManager.GetProductDetails();
    if (result.Succes)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/ " + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}
