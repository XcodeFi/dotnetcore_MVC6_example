using Gradudate_project.Infrastructure.Repositories.Abstract;
using Gradudate_project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gradudate_project.Infrastructure.Repositories
{
    public class CategoryBlogRepository:EntityBaseRepository<CategoryBlog>, ICateBlogRepository
    {
        public CategoryBlogRepository(GreetingCardContext context) : base(context) { }
    }
}
