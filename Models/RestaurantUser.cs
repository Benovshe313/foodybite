
namespace Foody_bite.Models
{
    internal class RestaurantUser
    {
        public int RestaurantId { get; set; }
        public int UserId { get; set; }
        public Restaurant Restaurant { get; set; }
        public User User { get; set; }
    }
}
