

namespace PizzaTuto.Data
{
    public class Pizza
    {
    public int Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Description { get; set; }
    
    public decimal Price { get; set; }
    
    public bool Vegetarian { get; set; }
    
    public bool Vegan { get; set; }

    public string? Image { get; set; }


        public PizzaSpecial Special { get; set; }
        public int SpecialId { get; set; }
        public string? Size { get; set; }
        public static string DefaultSize { get; set; } = "Medium";
                // Additional properties for ConfigurePizzaDialog
        public string MinimumSize { get; set; } = "Small";
        public string MaximumSize { get; set; } = "Large";

        public string GetFormattedTotalPrice() => Price.ToString("0.00");
    }
}