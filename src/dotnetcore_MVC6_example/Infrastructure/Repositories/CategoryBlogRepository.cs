using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;
using dotnetcore_MVC6_example.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class CategoryBlogRepository:EntityBaseRepository<CategoryBlog>, ICateBlogRepository
    {
        public CategoryBlogRepository(GreetingCardContext context) : base(context) { }
    }
}
