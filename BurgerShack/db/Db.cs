using System.Collections.Generic;
using burgerShack.Models;

namespace burgerShack.db
{
  public static class Db
  {
    public static List<Burger> Burgers { get; set; } = new List<Burger>(){
      new Burger("The Miles Collins", 5, "Chicken Breast", "Pickles, Mustard", "Delicious chicken topped with mustard, and pickles in between two fresh buns!", false, 1)
    };
  }
}