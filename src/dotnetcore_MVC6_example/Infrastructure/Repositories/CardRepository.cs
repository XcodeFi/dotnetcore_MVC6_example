using dotnetcore_MVC6_example.Entities;
using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class CardRepository: EntityBaseRepository<Card>, ICardRepository
    {
        public CardRepository(GreetingCardContext context)
            : base(context)
        { }
    }
}
