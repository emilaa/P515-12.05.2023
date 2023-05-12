namespace Task1.Models
{
    public class Car : BaseEntity
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int ModelId { get; set; }
    }
}
