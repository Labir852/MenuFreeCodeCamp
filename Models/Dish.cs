namespace MenuFreeCodeCamp.Models
{
    public class Dish
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public double price { get; set; }
        public List<DishIngredient>? DishIngredients {get; set;}
    }
}
