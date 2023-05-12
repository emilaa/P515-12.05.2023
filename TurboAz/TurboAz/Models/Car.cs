namespace TurboAz.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Color { get; set; }
        public DateTime Year { get; set; }
        public int ModelId { get; set; }
    }
}
