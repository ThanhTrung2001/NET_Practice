using FluentAssertions;
using Moq;
using TestingProject.Data;
using TestingProject.Models;

namespace TestPath
{
    public class UnitTest
    {
        [Fact]
        public void TestGetCard_ReturnAllCard()
        {
            //Arrange
            CardRepository repository = new CardRepository();
            //Act
            var card = repository.GetCards();
            //Assert
            Assert.NotNull(card);
            Assert.Equal(5, card.Count());
        }

        [Fact]
        public void TestGetCard_ReturnTrueCard()
        {
            //Arrange
            CardRepository repository = new CardRepository();
            var expectResult = new Card { Id = "2", Name = "Card 2", Stars = 2, Description = "This is Card Number.2", Type = "Normal", Price = 200 };
            //Act
            var card = repository.GetCardById("2");
            //Assert
            Assert.NotNull(card);
            Assert.Equal(expectResult.Name, card.Name);
            Assert.Equal(expectResult.Stars, card.Stars);
            Assert.Equal(expectResult.Price, card.Price);

        }

        [Fact]
        public void TestGetCard_ReturnTrueMockCard()
        {
            //Arrange
            var card = new Card { Id = "2", Name = "Card 2", Stars = 2, Description = "This is Card Number.2", Type = "Normal", Price = 200 };
            var cardRepositoryMock = new Mock<ICardRepository>();
            cardRepositoryMock.Setup(x => x.GetCardById(It.IsAny<string>())).Returns(card);
            //Act
            var expectResult = cardRepositoryMock.Object.GetCardById("2");
            //Assert
            Assert.Equal(expectResult.Name, card.Name);
            Assert.Equal(expectResult.Stars, card.Stars);
            Assert.Equal(expectResult.Price, card.Price);
        }

        [Fact]
        public void TestGetCard_ReturnAllCardWithFluentAssertion()
        {
            //Arrange
            CardRepository repository = new CardRepository();
            //Act
            var card = repository.GetCards();
            //Assert
            card.Count().Should().Be(5);
        }
    }
}