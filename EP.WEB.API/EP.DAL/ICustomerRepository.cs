using EP.DTO;
using EP.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DAL
{
    public interface ICustomerRepository : IRepository<Customers>
    {
        IEnumerable<Customers> GetTop5Customers(int count);
        IEnumerable<Customers> GetCustomerOrders(int pageIndex, int pageSize);
    }
}
