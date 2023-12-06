


namespace PizzaTuto.Data
{
    public class PizzaSpecial
    {
       public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public string? Image { get; set; }


        public string GetFormattedBasePrice() => Price.ToString("0.00");

    }
}