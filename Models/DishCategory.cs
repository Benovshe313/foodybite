
namespace Foody_bite.Models
{
    internal class DishCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Dish> Dishes { get; set; }
    }
}
