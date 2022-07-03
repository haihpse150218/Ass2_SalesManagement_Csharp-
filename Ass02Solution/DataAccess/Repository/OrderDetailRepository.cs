
﻿using AutoMapper;
using BusinessObject;

using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private static Object LockInstance = new Object();
        
        private OrderDetailRepository() { }
        private static OrderDetailRepository instance = null;
        public static OrderDetailRepository Instance { 
            get 
            { 
                lock (LockInstance)
                {
                    if(instance == null)
                    {
                        instance = new OrderDetailRepository();
                    }
                    return instance;
                }
            } 
        }

        
        public List<OrderDetailObjec> GetOrderDetails()
        {
            FStore2Context db = new FStore2Context();
            List<OrderDetailObjec> listResult = new List<OrderDetailObjec>();
            var config = new MapperConfiguration(cfg =>
               cfg.CreateMap<OrderDetail, OrderDetailObjec>()
           );
            //Using AutoMapper
            var mapper = new Mapper(config);
           foreach(OrderDetail od in db.OrderDetails.ToList())
            {
                OrderDetailObjec orderDetail = mapper.Map<OrderDetailObjec>(od);
                listResult.Add(orderDetail);
            }
            return listResult;
        }

        public List<OrderDetailObjec> GetOrderDetailObjecstByOrderId(int orderId)
        {
            FStore2Context db = new FStore2Context();
            List<OrderDetailObjec> listResult = new List<OrderDetailObjec>();
            listResult = GetOrderDetails().Where(o => o.OrderId == orderId).ToList();
            return listResult;
        }

        public void saveOrderDetail(List<OrderDetailObjec> list)
        {

        }
       



    }
}
