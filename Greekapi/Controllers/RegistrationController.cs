using Greekapi.DataHolders;
using Greekapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Greekapi.Controllers
{
    public class RegistrationController : ApiController
    {

        [Route("register")]
        [HttpGet]
        public async Task<ResponseModel> Registeruser(RegistrationDTO registrationDTO)
        {
            try
            {
                using(var cntxt = new GreekstoreEntities())
                {

                }
            }
            catch(Exception ex)
            {
                return new ResponseModel()
                {
                    code = 403,
                    description = ex.InnerException.Message,
                    timestamp = DateTime.Now
                };
            }
        }
    }
}
