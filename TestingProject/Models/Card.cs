namespace TestingProject.Models
{
    public class Card
    {
        public required string Id { get; set; }
        public required int Stars { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Type { get; set; }
        public required int Price { get; set; }
    }
}
