using Gradudate_project.Infrastructure;
using Gradudate_project.Infrastructure.Repositories;
using Gradudate_project.Entities;
using Gradudate_project.Infrastructure.Repositories.Abstract;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class UserRoleRepository: EntityBaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(GreetingCardContext context) : base(context) { }
    }
   
}
