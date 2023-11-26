using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL.Services;
using DAL.Model;


namespace API.Controllers
{
   // [EnableCors("*", "*", "*")]
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("api/customers")]
        public HttpResponseMessage AllCustomers()
        {
            try
            {
                var data = CustomerServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
        [HttpGet]
        [Route("api/customers/{id}")]
        public HttpResponseMessage Customer(int id)
        {
            try
            {
                var data = CustomerServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/customer/create")]
        public HttpResponseMessage Create(Customer obj)
        {
            try
            {
                var data = CustomerServices.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/customer/update")]
        public HttpResponseMessage Update(Customer obj)
        {
            try
            {
                var data = CustomerServices.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        
        [HttpGet]
        [Route("api/customer/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var res = CustomerServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }
    }
}
