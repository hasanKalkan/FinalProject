using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Category:IEntity
    {
        //Çıplak Class Kalmasın: Interface almayan çıplak kalır.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
