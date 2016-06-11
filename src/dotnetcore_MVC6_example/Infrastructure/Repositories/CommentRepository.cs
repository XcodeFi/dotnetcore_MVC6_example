using dotnetcore_MVC6_example.Entities;
using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class CommentRepository: EntityBaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(GreetingCardContext context) : base(context) { }
    }
}
