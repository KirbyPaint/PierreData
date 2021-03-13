using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierreData.Models;

namespace Pierre.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderPrice, string orderDate)
    {
    }
  }
}