using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using API.Helper;
using API.Models;

namespace API.Controllers
{
    [RoutePrefix("api/Activity")]
    public class ActivityController : ApiController
    {
        // POST api/Activity/LogError
        [Route("LogError")]
        public async Task<IHttpActionResult> LogError(ActivityModel model)
        {
            string log = Logger.LogError(model.User, model.Data);
            return Ok(log);
        }

        // POST api/Activity/LogActivity
        [Route("LogActivity")]
        public async Task<IHttpActionResult> LogActivity(ActivityModel model)
        {
            string log = Logger.LogActivity(model.User, model.Data);
            return Ok(log);
        }
    }
}
