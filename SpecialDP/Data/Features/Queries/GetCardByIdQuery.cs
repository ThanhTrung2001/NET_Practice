using MediatR;
using SpecialDP.Data.UnitOfWork;
using SpecialDP.Models;

namespace SpecialDP.Data.Features.Queries
{
    public class GetCardByIdQuery : IRequest<Card>
    {
        public string Id { get; set; }
        public class GetCardByIdQueryHandler : IRequestHandler<GetCardByIdQuery, Card>
        {
            private readonly IUnitOfWork unitOfWork;

            public GetCardByIdQueryHandler(IUnitOfWork unitOfWork)
            {
                this.unitOfWork = unitOfWork;
            }

            public Task<Card> Handle(GetCardByIdQuery request, CancellationToken cancellationToken)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return null;
                }
                return Task.FromResult(this.unitOfWork.GetCardRepository().GetById(request.Id));
            }
        }
    }
}
