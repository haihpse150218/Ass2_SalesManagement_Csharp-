using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public MemberObject Login(string email, string password, out string msg);
        public bool ValidateEmail(string email);
    }
}
