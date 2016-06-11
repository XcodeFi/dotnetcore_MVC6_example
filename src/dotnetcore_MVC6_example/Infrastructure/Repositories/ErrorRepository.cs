using dotnetcore_MVC6_example.Entities;
using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class ErrorRepository:EntityBaseRepository<Error>,IErrorRepository
    {
        public ErrorRepository(GreetingCardContext context) : base(context) { }
    }
}
