using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EPContext _context;
        public UnitOfWork(EPContext context)
        {
            _context = context;
            Customers = new CustomerRespository(_context);
        }

        public ICustomerRepository Customers { get; private set; }

        public IOrdersRespository Orders { get; private set; }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
