using Core.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data_Access.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>
        where TEntity:class,IEntity, new()
        where TContext:DbContext
    {
    }
}
