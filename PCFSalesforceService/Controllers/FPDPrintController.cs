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
        public HttpResponse Post([FromBody] FPDFields fpdField)
        {            
            try
            {
                if (fpdField == null)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("")]
        public string Get()
        {
            return "Success";
        }
    }
}