using CarSell.Data;

namespace CarSell.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public double Price { get; set; }
        public string Description { get; set; } = string.Empty;

        public string SellerId { get; set; } = string.Empty;
        public ApplicationUser? Seller { get; set; }
    }
}
