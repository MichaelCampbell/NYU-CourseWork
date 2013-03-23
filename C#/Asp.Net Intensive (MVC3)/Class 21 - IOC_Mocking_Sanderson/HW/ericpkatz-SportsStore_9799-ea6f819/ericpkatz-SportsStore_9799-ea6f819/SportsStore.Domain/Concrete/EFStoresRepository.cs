using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportsStore.Domain.Abstract;

namespace SportsStore.Domain.Concrete
{
    public class EFStoresRepository : IStoreRepository
    {
        private EFDbContext ctx = new EFDbContext();

        public IQueryable<Entities.Store> Stores
        {
            get { return ctx.Stores; }
        }
    }
}
