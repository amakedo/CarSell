using CarSell.Data;

namespace CarSell.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public int CarId { get; set; }
        public Car? Car { get; set; }
        public string BuyerId { get; set; } = string.Empty;
        public ApplicationUser Buyer { get; set; } = null!;

        public DateTime PurchaseDate { get; set; }
    }
}
