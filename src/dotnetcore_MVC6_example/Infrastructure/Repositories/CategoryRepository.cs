using dotnetcore_MVC6_example.Entities;
using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class CategoryRepository:EntityBaseRepository<Category>,ICateRepository
    {
        public CategoryRepository(GreetingCardContext context) : base(context) { }
    }
}
