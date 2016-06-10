using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gradudate_project.Entities;
using Gradudate_project.Infrastructure.Repositories.Abstract;

namespace Gradudate_project.Infrastructure.Repositories
{
    public class CardRepository: EntityBaseRepository<Card>, ICardRepository
    {
        public CardRepository(GreetingCardContext context)
            : base(context)
        { }
    }
}
