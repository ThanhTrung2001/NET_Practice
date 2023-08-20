using MediatR;
using Microsoft.AspNetCore.Mvc;
using SpecialDP.Data.Features.Queries;
using SpecialDP.Data.UnitOfWork;
using SpecialDP.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpecialDP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        //private readonly ICardRepository cardRepository;

        //public CardController(ICardRepository repository)
        //{
        //    this.cardRepository = repository;
        //}

        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;
        public CardController(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
        }


        // GET: api/<CardController>
        [HttpGet]
        public async Task<IEnumerable<Card>> Get()
        {
            //return this.cardRepository.GetAll();
            //return unitOfWork.GetCardRepository().GetAll();
            return await mediator.Send(new GetAllCardsQuery());
        }

        // GET api/<CardController>/5
        [HttpGet("{id}")]
        public Card Get(int id)
        {
            //return this.cardRepository.GetById(id.ToString());
            return unitOfWork.GetCardRepository().GetById(id.ToString());
        }

        // POST api/<CardController>
        [HttpPost]
        public IEnumerable<Card> Post()  //[FromBody] Card obj
        {
            var card = new Card { Id = "3", Name = "Card 3", Stars = 3, Description = "This is Card Number.3", Type = "High", Price = 300 };
            try
            {
                unitOfWork.CreateTransaction();
                unitOfWork.GetCardRepository().Add(card);
                unitOfWork.Save();
                unitOfWork.Commit();
                return unitOfWork.GetCardRepository().GetAll();
            }
            catch (Exception e)
            {
                unitOfWork.Rollback();
                throw e;
            }
        }

        // PUT api/<CardController>/5
        [HttpPut("{id}")]
        public void Put(int id, string value)
        {
            //var card = this.cardRepository.GetById(id.ToString());
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
