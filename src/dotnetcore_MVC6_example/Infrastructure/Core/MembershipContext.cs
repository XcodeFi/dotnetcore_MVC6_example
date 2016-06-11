using dotnetcore_MVC6_example.Entities;
using System.Security.Principal;

namespace dotnetcore_MVC6_example.Infrastructure
{
    public class MembershipContext
    {
        public IPrincipal Principal { get; set; }
        public User User { get; set; }
        public bool IsValid()
        {
            return Principal != null;
        }
    }
}
