
namespace Foody_bite.Models
{
    internal class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public TimeOnly OpenTime { get; set; }
        public TimeOnly CloseTime { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Dish> Dishes { get; set; }
        public int MediaRestaurantId { get; set; }
        public Category Category { get; set; }
        public MediaRestaurant MediaRestaurant { get; set; }
        public ICollection<RestaurantUser> RestaurantUsers { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
