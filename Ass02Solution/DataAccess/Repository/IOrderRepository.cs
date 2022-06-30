using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public List<OrderObject> GetOrderObjects();
        public List<OrderObject> GetListOrderByRangeDate(DateTime fromDate, DateTime toDate, MemberObject user);
    }
}
