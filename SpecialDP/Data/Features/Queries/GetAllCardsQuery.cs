using MediatR;
using SpecialDP.Data.UnitOfWork;
using SpecialDP.Models;

namespace SpecialDP.Data.Features.Queries
{
    public class GetAllCardsQuery : IRequest<IEnumerable<Card>>
    {
        public class GetAllCardsQueryHandler : IRequestHandler<GetAllCardsQuery, IEnumerable<Card>>
        {

            private readonly IUnitOfWork unitOfWork;

            public GetAllCardsQueryHandler(IUnitOfWork unitOfWork)
            {
                this.unitOfWork = unitOfWork;
            }

            public Task<IEnumerable<Card>> Handle(GetAllCardsQuery request, CancellationToken cancellationToken)
            {

                return Task.FromResult(this.unitOfWork.GetCardRepository().GetAll());
            }
        }
    }
}
