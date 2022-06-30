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
       
        FStore2Context db = new FStore2Context();
        
    }
}
