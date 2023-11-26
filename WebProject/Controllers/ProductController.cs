using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class ProductController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44333/api/");
        private readonly HttpClient client;
        public ProductController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Product> Product = new List<Product>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "products").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                Product = JsonConvert.DeserializeObject<List<Product>>(data);
            }
            return View(Product);
        }
    }
}