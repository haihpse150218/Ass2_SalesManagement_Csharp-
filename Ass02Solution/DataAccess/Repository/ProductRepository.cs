
﻿using DataAccess.Models;
using Microsoft.Extensions.Configuration;

﻿using AutoMapper;
using BusinessObject;
using DataAccess.Models;
using System;
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

        
        public List<ProductObject> getProductObjectsByOrderId(int OrderId)
        {
          FStore2Context db = new FStore2Context();
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
            FStore2Context db = new FStore2Context();
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
