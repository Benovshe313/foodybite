
namespace Foody_bite.Models
{
    internal class MediaRestaurant
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
