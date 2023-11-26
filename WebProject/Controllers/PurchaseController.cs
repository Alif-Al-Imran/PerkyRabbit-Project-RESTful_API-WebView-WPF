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
    public class PurchaseController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44333/api/");
        private readonly HttpClient client;
        public PurchaseController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Purchase> Purchase = new List<Purchase>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "purchases").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                Purchase = JsonConvert.DeserializeObject<List<Purchase>>(data);
            }
            return View(Purchase);
        }
    }
}