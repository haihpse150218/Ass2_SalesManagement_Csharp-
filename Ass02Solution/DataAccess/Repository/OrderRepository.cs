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
    public class OrderRepository : IOrderRepository
    {
        private static OrderRepository instance = null;
        public static Object lockInstance = new object();
        public static OrderRepository Instance
        {
            get
            {
                lock (lockInstance)
                {
                    instance = new OrderRepository();
                }
                return instance;
            }

        }
        public List<OrderObject> GetListOrderByRangeDate(DateTime fromDate, DateTime toDate, MemberObject user)
        {
            FStore2Context db = new FStore2Context();
            List<OrderObject> listResult = new List<OrderObject>();
            List<Order> orders = db.Orders.ToList();
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Order, OrderObject>()
           );
            //Using AutoMapper
            var mapper = new Mapper(config);
            
            foreach (Order order in orders)
            {
                order.OrderDetails = db.OrderDetails.Where(x => x.OrderId == order.OrderId).ToList();
                if(DateTime.Compare(order.OrderDate,fromDate) > 0 && DateTime.Compare(order.OrderDate, toDate) < 0)
                {
                    //map data from order to list
                    if (user.Role == 0)
                    {
                        OrderObject ob = mapper.Map<OrderObject>(order);
                        ob.Total = order.OrderDetails.Sum(o => o.Quantity * (1 - o.Discount) * (double)o.UnitPrice);
                        listResult.Add(ob);
                    }
                    else
                    {
                       
                        if (order.MemberId == user.MemberId){
                            OrderObject ob = mapper.Map<OrderObject>(order);
                            ob.Total = order.OrderDetails.Sum(o => o.Quantity * (1 - o.Discount) * (double)o.UnitPrice);
                            listResult.Add(ob);
                        }
                    }
                    
                }  
            }
            return listResult;
        }
        public List<OrderObject> GetOrderObjects()
        {

            FStore2Context db = new FStore2Context();
            List<OrderObject> listResult = new List<OrderObject>();
            List<Order> orders = db.Orders.ToList();

            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Order, OrderObject>()
            );
            //Using AutoMapper
            var mapper = new Mapper(config);

            
            foreach (Order order in orders)
            {
                order.OrderDetails = db.OrderDetails.Where(x => x.OrderId == order.OrderId).ToList();

                OrderObject ob = mapper.Map<OrderObject>(order);
                ob.Total = order.OrderDetails.Sum(o => o.Quantity * (1 - o.Discount) * (double)o.UnitPrice);
                listResult.Add(ob);
            }
            return listResult;
        }

        public List<OrderObject> GetOrderObjectsByUser(MemberObject user)
        {
            List<OrderObject> listResult = new List<OrderObject>();
            // mapp initial config
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Order, OrderObject>()
            );
            //Using AutoMapper
            var mapper = new Mapper(config);
            if (user.Role == 0)
            {
                listResult = GetOrderObjects();
            }
            else
            {
                listResult = GetOrderObjects().Where(o => o.MemberId == user.MemberId).ToList();
            }
            return listResult;
        }

    }
}
