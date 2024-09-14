
namespace Foody_bite.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
