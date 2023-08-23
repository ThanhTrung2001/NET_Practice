using Microsoft.AspNetCore.Mvc;
using SpecialDP.Data.Repository.Interface;
using SpecialDP.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpecialDP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardRepository cardRepository;

        public CardController(ICardRepository repository)
        {
            this.cardRepository = repository;
        }

        //private readonly IUnitOfWork unitOfWork;
        //private readonly IMediator mediator;
        //public CardController(IUnitOfWork unitOfWork, IMediator mediator)
        //{
        //    this.unitOfWork = unitOfWork;
        //    this.mediator = mediator;
        //}


        // GET: api/<CardController>
        [HttpGet]
        //public IEnumerable<Card> Get()
        public async Task<IEnumerable<Card>> Get()
        {
            //using(TransactionScope scope = new TransactionScope())
            //{

            //}
            return this.cardRepository.GetAll();
            //return unitOfWork.GetCardRepository().GetAll();
            //return await mediator.Send(new GetAllCardsQuery());
        }

        // GET api/<CardController>/5
        [HttpGet("{id}")]
        //public Card Get(int id)
        public async Task<Card> Get(int id)
        {
            return this.cardRepository.GetById(id.ToString());
            //return unitOfWork.GetCardRepository().GetById(id.ToString());
            //return await mediator.Send(new GetCardByIdQuery { Id = id.ToString() });
        }

        // POST api/<CardController>
        [HttpPost]
        //public IEnumerable<Card> Post()  //[FromBody] Card obj
        public async Task<IEnumerable<Card>> Post()
        {
            var card = new Card { Id = "3", Name = "Card 3", Stars = 3, Description = "This is Card Number.3", Type = "High", Price = 300 };
            this.cardRepository.Add(card);
            return cardRepository.GetAll();
            //try
            //{
            //    unitOfWork.CreateTransaction();
            //    unitOfWork.GetCardRepository().Add(card);
            //    unitOfWork.Save();
            //    unitOfWork.Commit();
            //    return unitOfWork.GetCardRepository().GetAll();
            //}
            //catch (Exception e)
            //{
            //    unitOfWork.Rollback();
            //    throw e;
            //}
            //await mediator.Send(new CreateCardCommand { Id = "10", Name = "Card10", Stars = 0, Description = "This is Card.10", Type = "???", Price = 1000 });
            //return await mediator.Send(new GetAllCardsQuery());
        }

        // Patch api/<CardController>/5
        [HttpPut("{id}")]
        public async Task<IEnumerable<Card>> Put(int id)
        {
            var card = this.cardRepository.GetById(id.ToString());
            card.Description = "Edited!";
            this.cardRepository.Update(card);
            return this.cardRepository.GetAll();
            //card.Description = value;

        }

        // DELETE api/<CardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //var card = this.cardRepository.GetById(2.ToString());
            //this.cardRepository.Delete(card);
            //return Ok(this.cardRepository.GetAll());

        }
    }
}
