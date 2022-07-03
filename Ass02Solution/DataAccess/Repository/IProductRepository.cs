using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public List<ProductObject> GetAllProduct();
        public List<ProductObject> getProductObjectsByOrderId(int OrderId);
        

    }
}
