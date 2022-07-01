using AutoMapper;
using BusinessObject;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        FStore2Context db = new FStore2Context();
        public List<ProductObject> getProductObjectsByOrderId(int OrderId)
        {
           List<ProductObject> productObjects = new List<ProductObject>();

            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Product, ProductObject>()
            );
            //Using AutoMapper
            var mapper = new Mapper(config);

            List<OrderDetail> orderDetails = db.OrderDetails.Where(x => x.OrderId == OrderId).ToList();

            foreach (OrderDetail orderDetail in orderDetails)
            {
                Product p = db.Products.Where(x => x.ProductId == orderDetail.ProductId).SingleOrDefault();
                ProductObject productObject = mapper.Map<ProductObject>(p);
                productObjects.Add(productObject);
            }
            return productObjects;
            
        }

        public List<ProductObject> GetProductObjects()
        {
            List<ProductObject> reusltList = new List<ProductObject>();

            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Product, ProductObject>()
            );
            //Using AutoMapper
            var mapper = new Mapper(config);
            foreach (Product p in db.Products)
            {
                ProductObject product = mapper.Map<ProductObject>(p);
                reusltList.Add(product);
            }
            return reusltList;
        }
    }
}
