using MediatR;
using SpecialDP.Models;

namespace SpecialDP.Data.Features.Queries
{
    public class GetCardByIdQuery : IRequest<Card>
    {
        public string Id { get; set; }
        public class GetCardByIdQueryHandler : IRequestHandler<GetCardByIdQuery, Card>
        {
            private readonly ApplicationDbContext context;

            public GetCardByIdQueryHandler(ApplicationDbContext context)
            {
                this.context = context;
            }

            public async Task<Card> Handle(GetCardByIdQuery request, CancellationToken cancellationToken)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return null;
                }
                var card = this.context.Set<Card>().FirstOrDefault(x => x.Id == request.Id);
                if (card == null)
                {
                    return null;
                }
                return card;
            }
        }
    }
}
