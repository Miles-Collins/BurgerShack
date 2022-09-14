namespace burgerShack.Models
{
  public class Burger
  {
    public Burger()
    {
    }

    public Burger(string name, int price, string meat, string toppings, string description, bool vegan, int id)
    {
      this.Name = name;
      this.Price = price;
      this.Meat = meat;
      this.Toppings = toppings;
      this.Description = description;
      this.Vegan = vegan;
      this.Id = id;
    }
    public string Name { get; set; }
    public int? Price { get; set; }
    public string Meat { get; set; }
    public string Toppings { get; set; }
    public string Description { get; set; }
    public bool? Vegan { get; set; }
    public int Id { get; set; }

  }
}