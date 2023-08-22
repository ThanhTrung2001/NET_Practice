using MediatR;
using Microsoft.EntityFrameworkCore;
using SpecialDP.Models;

namespace SpecialDP.Data.Features.Queries
{
    public class GetAllCardsQuery : IRequest<IEnumerable<Card>>
    {
        public class GetAllCardsQueryHandler : IRequestHandler<GetAllCardsQuery, IEnumerable<Card>>
        {

            private readonly ApplicationDbContext context;

            public GetAllCardsQueryHandler(ApplicationDbContext context)
            {
                this.context = context;
            }

            public async Task<IEnumerable<Card>> Handle(GetAllCardsQuery request, CancellationToken cancellationToken)
            {

                var result = await this.context.Set<Card>().ToListAsync();
                if (result == null)
                {
                    return null;
                }
                return result;
            }
        }
    }
}
