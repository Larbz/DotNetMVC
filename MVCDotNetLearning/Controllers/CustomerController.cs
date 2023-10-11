using Microsoft.AspNetCore.Mvc;
using MVCDotNetLearning.Models;

namespace MVCDotNetLearning.Controllers;

public class CustomerController : Controller
{
    public static List<Customer> customers = new List<Customer>()
    {
        new Customer() { Id = 101, Name = "King", Amount = 12000 },
        new Customer() { Id = 102, Name = "King", Amount = 12000 },
    };
    // GET
    public IActionResult Index()
    {
        ViewBag.Message = "Customer Management System";
        ViewBag.CustomerCount = customers.Count;
        ViewBag.CustomerList = customers;
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }
    
    public IActionResult Message()
    {
        return View();
    }
}