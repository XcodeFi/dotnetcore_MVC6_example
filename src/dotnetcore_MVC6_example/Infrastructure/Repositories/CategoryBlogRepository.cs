using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;
using dotnetcore_MVC6_example.Entities;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class CategoryBlogRepository:EntityBaseRepository<CategoryBlog>, ICateBlogRepository
    {
        public CategoryBlogRepository(GreetingCardContext context) : base(context) { }
    }
}
