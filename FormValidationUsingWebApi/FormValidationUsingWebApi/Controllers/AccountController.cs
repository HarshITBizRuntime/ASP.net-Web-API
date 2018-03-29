using FormValidationUsingWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FormValidationUsingWebApi.Controllers
{
    [RoutePrefix("api/account")]
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("save")]
        public HttpResponseMessage save(Account accont)
        {
            try
            {
                if (accont != null && accont.uname.Equals("harshad"))
                {
                    ModelState.AddModelError("account.uname", "user all ready exit ");
                }
                if (ModelState.IsValid)
                    return new HttpResponseMessage(HttpStatusCode.OK);
                else
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ModelState);
            }
            catch
            {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ModelState);
            }
        }
    }
}
