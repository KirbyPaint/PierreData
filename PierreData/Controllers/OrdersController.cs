using Microsoft.AspNetCore.Mvc;
using PierreData.Models;
using System.Collections.Generic;

namespace Pierre.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
    }

  }
}