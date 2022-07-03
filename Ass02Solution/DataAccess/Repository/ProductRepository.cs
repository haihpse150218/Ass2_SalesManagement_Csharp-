using DataAccess.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BusinessObject;
using AutoMapper;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private static readonly object instanceLock = new object();
        public static ProductRepository instance = null;
        private ProductRepository() { }
        public static ProductRepository Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductRepository();
                    }
                }
                return instance;
            }
        }
        public List<ProductObject> GetAllProduct()
        {
            FStore2Context db = new FStore2Context();
            List<ProductObject> listResult = new List<ProductObject>();
            List<Product> products = db.Products.ToList();
            var config = new MapperConfiguration(cfg =>
               cfg.CreateMap<Product, ProductObject>()
            );
            var mapper = new Mapper(config);
            foreach (Product pro in products)
            {
                ProductObject product = mapper.Map<ProductObject>(pro);
                listResult.Add(product);
            }
            return listResult;
        }
    }
}
