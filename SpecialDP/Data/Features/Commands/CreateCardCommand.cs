using MediatR;
using SpecialDP.Models;

namespace SpecialDP.Data.Features.Commands
{
    public class CreateCardCommand : IRequest<Card>
    {
        public string Id { get; set; }
        public int Stars { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public class CreateCardCommandHandler : IRequestHandler<CreateCardCommand, Card>
        {
            private readonly ApplicationDbContext context;

            public CreateCardCommandHandler(ApplicationDbContext context)
            {
                this.context = context;
            }

            public async Task<Card> Handle(CreateCardCommand request, CancellationToken cancellationToken)
            {
                var card = new Card();
                card.Id = request.Id;
                card.Stars = request.Stars;
                card.Name = request.Name;
                card.Description = request.Description;
                card.Type = request.Type;
                card.Price = request.Price;
                context.Set<Card>().Add(card);
                await context.SaveChangesAsync();
                return card;
            }
        }
    }
}
