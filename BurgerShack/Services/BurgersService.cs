using System.Collections.Generic;
using burgerShack.Models;
using burgerShack.Repositories;

namespace burgerShack.Services
{
  public class BurgersService
  {
    private readonly BurgersRepository _burgerRepo;

    public BurgersService(BurgersRepository burgerRepo)
    {
      _burgerRepo = burgerRepo;
    }

    internal List<Burger> GetBurgers()
    {
      List<Burger> burgers = _burgerRepo.GetBurgers();
      return burgers;
    }
    internal Burger GetBurgerById(int id)
    {
      Burger burger = _burgerRepo.GetBurgerById(id);
      return burger;
    }
    internal Burger CreateBurger(Burger body)
    {
      Burger burger = _burgerRepo.CreateBurger(body);
      return burger;
    }
    internal Burger UpdateBurger(Burger update)
    {
      return _burgerRepo.UpdateBurger(update);
    }
    internal string DeleteBurger(int id)
    {
      return _burgerRepo.DeleteBurger(id);
    }
  }
}