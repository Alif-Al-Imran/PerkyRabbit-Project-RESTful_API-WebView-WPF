using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PurchaseController : ApiController
    {
        [HttpGet]
        [Route("api/purchases")]
        public HttpResponseMessage AllPurchases()
        {
            try
            {
                var data = PurchaseServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
