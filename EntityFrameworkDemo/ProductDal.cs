using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                return eTradeContext.Products.ToList();
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                eTradeContext.Products.Add(product);
                eTradeContext.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                var entity = eTradeContext.Entry(product);
                entity.State = EntityState.Modified;
                eTradeContext.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                var entity = eTradeContext.Entry(product);
                entity.State = EntityState.Deleted;
                eTradeContext.SaveChanges();
            }
        }
    }
}
