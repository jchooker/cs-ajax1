using ajax_demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ajax_demo1.Controllers
{
    public class CustomerController : Controller
    {

        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            customers = new List<Customer>();
            customers.Add(new Customer(0, "JoeBud", 37));
            customers.Add(new Customer(1, "Emily", 32));
            customers.Add(new Customer(2, "Nutler", 12));
            customers.Add(new Customer(3, "Lan Caihen", 88));
            customers.Add(new Customer(4, "Giancarlo", 64));
            customers.Add(new Customer(5, "Bob", 59));
        }
        public IActionResult Index()
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[0]);

            return View("Customer", tuple);
        }
    }
}
