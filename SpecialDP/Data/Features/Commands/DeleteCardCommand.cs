using MediatR;
using SpecialDP.Models;

namespace SpecialDP.Data.Features.Commands
{
    public class DeleteCardCommand : IRequest<Card>
    {
        public string Id { get; set; }
        public class DeleteCardCommandHandler : IRequestHandler<DeleteCardCommand, Card>
        {
            private readonly ApplicationDbContext context;

            public DeleteCardCommandHandler(ApplicationDbContext context)
            {
                this.context = context;
            }

            public async Task<Card> Handle(DeleteCardCommand request, CancellationToken cancellationToken)
            {
                var card = context.Set<Card>().FirstOrDefault(x => x.Id == request.Id);
                if (card == null)
                {
                    return null;
                }
                context.Set<Card>().Remove(card);
                await context.SaveChangesAsync();
                return card;
            }
        }
    }
}
