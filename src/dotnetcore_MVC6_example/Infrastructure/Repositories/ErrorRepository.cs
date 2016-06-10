using Gradudate_project.Entities;
using Gradudate_project.Infrastructure.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gradudate_project.Infrastructure.Repositories
{
    public class ErrorRepository:EntityBaseRepository<Error>,IErrorRepository
    {
        public ErrorRepository(GreetingCardContext context) : base(context) { }
    }
}
