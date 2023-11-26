using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using WebProject.Models;
using Newtonsoft.Json;

namespace WebProject.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        Uri baseAddress = new Uri("https://localhost:44333/api/");
        private readonly HttpClient client;
        public CustomerController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Customer> Customer = new List<Customer>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "customers").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                Customer = JsonConvert.DeserializeObject<List<Customer>>(data);
            }
            return View(Customer);
        }
        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(int id)
        {

            return RedirectToAction("Get", new { id = id });
        }
        [HttpGet]
        public ActionResult Get(int id)
        {
            Customer customer = new Customer();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "customers/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                customer = JsonConvert.DeserializeObject<Customer>(data);
            }
            return View(customer);
        }
    }
}