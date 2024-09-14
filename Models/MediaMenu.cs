
namespace Foody_bite.Models
{
    internal class MediaMenu
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public ICollection<Dish> Dishes { get; set; }
    }
}
