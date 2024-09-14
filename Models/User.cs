
namespace Foody_bite.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int MediaUserId { get; set; }
        public ICollection<RestaurantUser> RestaurantUsers { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public MediaUser MediaUser { get; set; }
    }
}
