using Gradudate_project.Entities;
using Gradudate_project.Infrastructure;
using Gradudate_project.Infrastructure.Repositories;
using Gradudate_project.Infrastructure.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class CommentRepository: EntityBaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(GreetingCardContext context) : base(context) { }
    }
}
