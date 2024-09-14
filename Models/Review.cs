
namespace Foody_bite.Models
{
    internal class Review
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        public int RestaurantId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
