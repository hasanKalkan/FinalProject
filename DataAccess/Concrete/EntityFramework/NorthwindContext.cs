using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlar.
    public class NorthwindContext:DbContext//entity framework kurulumu ile birlikte gelir.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true"); // @\\ @ işareti slaş işaretini ters slaş olarak ayarlar.
            //veri tabanı isminde büyük küçük harf farketmez.
        }
    }
}
