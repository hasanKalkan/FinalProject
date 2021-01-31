using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrede
{
    public class ProductManager : IProductService
    {
        InMemoryProductDal _productDal;

        public ProductManager(InMemoryProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GetAll()
        {
            //İş Kodları : bir iş sınıfı başka sınıfı new lemez
            //yetkisi var mı_

            return _productDal.GetAll();
        }
    }
}
