using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCFSalesforceService.Model;

namespace PCFSalesforceService.Controllers
{
    [Route("api/fpdprints")]
    [ApiController]
    public class FPDPrintController : ControllerBase
    {
        [HttpPost("")]
        public HttpResponseMessage Post([FromBody] FPDFields fpdField)
        {
            try
            {
                return new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    ReasonPhrase = "Created"
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ReasonPhrase = $"Data was not created: {ex.InnerException}"
                };
            }
        }
    }
}