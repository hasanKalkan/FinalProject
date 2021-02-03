using Business.Concrede;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
    //SOLID
    //O: open closed principle
{
    class Program
    {
        static void Main(string[] args)
        {
          //  ProductManager productManager = new ProductManager(new InMemoryProductDal());
            ProductManager productManager = new ProductManager(new EfProductDal());
          //  foreach (var product in productManager.GetAllByCategoryId(2))
            foreach (var product in productManager.GetByUnitPrice(20,100))
                {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
