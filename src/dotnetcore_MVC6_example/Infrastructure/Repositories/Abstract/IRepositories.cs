using dotnetcore_MVC6_example.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract
{
    public interface ILoggingRepository : IEntityBaseRepository<Error> { }
    public interface IBlogRepository : IEntityBaseRepository<Blog> { }
    public interface ICardRepository : IEntityBaseRepository<Card> { }
    public interface ICateRepository : IEntityBaseRepository<Category> { }
    public interface ICateBlogRepository : IEntityBaseRepository<CategoryBlog> { }
    public interface ICommentRepository : IEntityBaseRepository<Comment> { }
    public interface IContactRepository : IEntityBaseRepository<Contact> { }
    public interface IRoleRepository : IEntityBaseRepository<Role> { }
    public interface IErrorRepository : IEntityBaseRepository<Error> { }
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        User GetSingleByUsername(string username);
        IEnumerable<Role> GetUserRoles(string username);
    }
    public interface IUserRoleRepository : IEntityBaseRepository<UserRole> { }
}
