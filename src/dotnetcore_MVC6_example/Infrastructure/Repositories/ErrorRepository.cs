using dotnetcore_MVC6_example.Entities;
using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class LoggingRepository:EntityBaseRepository<Error>,ILoggingRepository
    {
        public LoggingRepository(GreetingCardContext context) : base(context) { }
    }
}
