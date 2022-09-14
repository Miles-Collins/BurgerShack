using System;
using System.Collections.Generic;
using burgerShack.Models;
using burgerShack.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgerShack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BurgersController : ControllerBase
  {
    private readonly BurgersService _burgerService;

    public BurgersController(BurgersService burgersService)
    {
      _burgerService = burgersService;
    }

    [HttpGet]
    public ActionResult<List<Burger>> GetBurgers()
    {
      try
      {
        List<Burger> burgers = _burgerService.GetBurgers();
        return Ok(burgers);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Burger> GetBurgerById(int id)
    {
      try
      {
        Burger burger = _burgerService.GetBurgerById(id);
        return Ok(burger);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Burger> CreateBurger(Burger body)
    {
      try
      {
        Burger burger = _burgerService.CreateBurger(body);
        return Ok(burger);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Burger> UpdateBurger([FromBody] Burger body, int id)
    {
      try
      {
        body.Id = id;
        Burger burger = _burgerService.UpdateBurger(body);
        return Ok(burger);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> DeleteBurger(int id)
    {
      try
      {
        string message = _burgerService.DeleteBurger(id);
        return Ok(message);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}