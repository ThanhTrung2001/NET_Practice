using MediatR;
using SpecialDP.Models;

namespace SpecialDP.Data.Features.Commands
{
    public class EditCardCommand : IRequest<Card>
    {
        public string Id { get; set; }
        public int Stars { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public class EditCardCommandHandler : IRequestHandler<EditCardCommand, Card>
        {
            private readonly ApplicationDbContext context;

            public EditCardCommandHandler(ApplicationDbContext context)
            {
                this.context = context;
            }

            public async Task<Card> Handle(EditCardCommand request, CancellationToken cancellationToken)
            {
                var card = context.Set<Card>().FirstOrDefault(x => x.Id == request.Id);
                if (card == null)
                {
                    return null;
                }
                card.Id = request.Id;
                card.Stars = request.Stars;
                card.Name = request.Name;
                card.Description = request.Description;
                card.Type = request.Type;
                card.Price = request.Price;
                context.Set<Card>().Update(card);
                await context.SaveChangesAsync();
                return card;
            }
        }
    }
}
