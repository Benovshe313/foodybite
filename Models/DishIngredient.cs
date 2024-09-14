
namespace Foody_bite.Models
{
    internal class DishIngredient
    {
        public int IngredientId { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
