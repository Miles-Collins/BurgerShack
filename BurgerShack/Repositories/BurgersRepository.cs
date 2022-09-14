using System.Collections.Generic;
using burgerShack.Models;
using System;
using burgerShack.db;

namespace burgerShack.Repositories
{
  public class BurgersRepository
  {
    internal List<Burger> GetBurgers()
    {
      return Db.Burgers;
    }
    internal Burger CreateBurger(Burger body)
    {
      body.Id = Db.Burgers.Count + 1;

      Db.Burgers.Add(body);
      return body;
    }
    internal Burger GetBurgerById(int id)
    {
      Burger burger = Db.Burgers.Find(c => c.Id == id);
      if (burger != null)
      {
        return burger;
      }
      throw new Exception("No burger by that ID");
    }

    internal Burger UpdateBurger(Burger update)
    {
      Burger original = GetBurgerById(update.Id);
      original.Name = update.Name != null ? update.Name : original.Name;
      original.Price = update.Price ?? original.Price;
      original.Meat = update.Meat != null ? update.Meat : original.Meat;
      original.Toppings = update.Toppings != null ? update.Toppings : original.Toppings;
      original.Description = update.Description != null ? update.Description : original.Description;
      original.Vegan = update.Vegan ?? original.Vegan;
      return original;
    }

    internal string DeleteBurger(int id)
    {
      Burger burger = Db.Burgers.Find(b => b.Id == id);
      if (!Db.Burgers.Remove(burger))
      {
        throw new Exception("There is no burger by that ID.");
      }
      return $"{burger.Name} was deleted";
    }

  }
}