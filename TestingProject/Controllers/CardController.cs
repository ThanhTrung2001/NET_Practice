using Microsoft.AspNetCore.Mvc;
using TestingProject.Data;
using TestingProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly CardRepository cardRepository;
        private readonly ILogger<CardController> _logger;

        public CardController(ILogger<CardController> logger)
        {
            cardRepository = new CardRepository();
            _logger = logger;
        }
        // GET: api/<CardController>
        [HttpGet]
        public IEnumerable<Card> Get()
        {
            var cards = cardRepository.GetCards().ToList();
            _logger.LogInformation("log");
            return cards;
        }

        [HttpGet("{id}")]
        public Card Get(string id)
        {
            return cardRepository.GetCardById(id);
        }

        [HttpPost]
        public IEnumerable<Card> Add()
        {
            Card addObj = new Card { Id = "6", Name = "Card 6", Stars = 6, Description = "This is Card Number.6", Type = "Ultra", Price = 600 };
            cardRepository.Insert(addObj);
            return cardRepository.GetCards();
        }





    }
}
