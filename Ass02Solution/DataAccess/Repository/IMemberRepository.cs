using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public MemberObject Login(string email, string password, out string msg);

        public bool IsValidEmail(string email);
        public List<MemberObject> GetMemberList();
    }
}
