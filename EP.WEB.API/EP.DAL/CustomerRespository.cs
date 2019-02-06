using EP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EP.DTO.Models;

namespace EP.DAL
{
    public class CustomerRespository : Repository<Customers>, ICustomerRepository
    {

        public CustomerRespository(EPContext context) : base(context)
        {

        }
      
        public EPContext EPContext
        {
            get { return Context as EPContext; }
        }

        public void Add(Customers entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Customers> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customers> Find(Expression<Func<Customers, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customers> GetCustomerOrders(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customers> GetTop5Customers(int count)
        {
            throw new NotImplementedException();
        }

        public void Remove(Customers entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Customers> entities)
        {
            throw new NotImplementedException();
        }

    
    }
}
