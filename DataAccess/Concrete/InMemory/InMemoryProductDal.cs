﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global değişkenler _ ile başlar.
        public InMemoryProductDal()
        {
            //Oracle, Sql Server, Postgres, MongoDb veri oluşturdu.
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3 },
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2 },
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65 },
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ-Language Integrated Query: aşağıdaki kodları kısaltır.
            //_products.Remove(product);  bu şekilde çalışmaz, silemez. ProductId kullanmak gerekiyor.
           /* Product productToDelete=null;
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            }*/


            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); //lambda bir nevi foreach yapar. p ismi bize bağlı.
            //SingleOrDefault metot ismidir. sorgu sonucunda iki eleman gelirse hata verir.
            //Using system.linq yazmamız gerekiyor.
            //products ı her p için tek tek dolaşır. => işareti lambda işareti tek tek dolaşır. 
            //Linq kullanınca yukarıdaki kodlara gerek kalmıyor.
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün id sine sahip olan ürünü listeden bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}