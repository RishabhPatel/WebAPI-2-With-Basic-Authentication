using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using BasicAuthentication.Filters;


namespace OTPWebApi.Controllers
{


    [Route("otp/password")]
    public class OTPController : ApiController
    {
        [Route("")]
        [AllowAnonymous]
        /// <summary>
        /// </summary>
        public HttpResponseMessage GetIndex()
        {
            var response = Request.CreateResponse(HttpStatusCode.Moved);
            string fullyQualifiedUrl = Request.RequestUri.GetLeftPart(UriPartial.Authority);
            response.Headers.Location = new Uri(fullyQualifiedUrl + "/help");
            return response;
        }


        [Route("otp/password")]
        [Authorize]
        /// <summary>
        /// GET One Time Password
        /// </summary>
        public String Get()
        {
            try
            {
                int length = 8;
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < length--)
                {
                    res.Append(valid[rnd.Next(valid.Length)]);
                }
                return res.ToString();
            }
            catch (Exception ex)
            {
                return HttpContext.Current.Response.Status.ToString();
            }
        }

   }
}
