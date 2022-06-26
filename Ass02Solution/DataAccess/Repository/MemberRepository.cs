using DataAccess.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BusinessObject;
using AutoMapper;

namespace DataAccess.Repository
{

    public class MemberRepository : IMemberRepository
    {
        
        private static readonly object instanceLock = new object();
        public static MemberRepository instance = null;
        private MemberRepository() { }
        public static MemberRepository Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberRepository();
                    }
                }
                return instance;
            }
        }
        private Dictionary<string,string> GetDefaultAdmin()
        {
            Dictionary<string,string> defaultAdmin = new Dictionary<string,string>();
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            string email = config["admin:email"];
            defaultAdmin.Add("email", email);
            string password = config["admin:password"];
            defaultAdmin.Add("password", password);
            return defaultAdmin;
        }

        FStore2Context db = new FStore2Context();
        public MemberObject Login(string email, string password, out string msg)
        {
            //initializing the mapper
            var config = new MapperConfiguration(cfg =>

                 cfg.CreateMap<Member, MemberObject>()

            );
            
            
            MemberObject memberObject = new MemberObject();
            Dictionary<string,string> defaultAdmin = GetDefaultAdmin();
            string emailAdmin = "";
            string passwordAdmin = "";
            defaultAdmin.TryGetValue("email",out emailAdmin);
            defaultAdmin.TryGetValue("password", out passwordAdmin);
            msg = "Email not found";
            bool flag = false;
            if (email == emailAdmin)
            {
                if (password == passwordAdmin)
                {
                    
                    flag = true;
                    msg = null;
                    memberObject.Email = email;
                    memberObject.Password = password;
                    memberObject.Role = 0;
                }
                msg = "Password Wrong!!!";
            }
            else
            {
                var a = db.Members.ToList();
                foreach (Member mem in db.Members.ToList())
                {
                 if (email == mem.Email)
                    {
                        
                        if (password == mem.Password) ;
                        {
                            flag = true;
                            msg = null;
                            //Using AutoMapper
                            var mapper = new Mapper(config);
                            //map data from mem to memberObject
                            memberObject = mapper.Map<MemberObject>(mem);
                            memberObject.Role = 1;
                            break;
                        }
                        msg = "Password Wrong!!!";
                    }

                }
            }
            
            return memberObject;
        }
    }
}
