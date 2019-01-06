using BusinessLogicLayer.NTierBLL;
using CORE.Faculty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class ValuesController : ApiController
    {
        FacultyBLL _facBll = new FacultyBLL();
        // GET api/values
        public IEnumerable<FacultyDTO> Get()
        {
            var temp = _facBll.Get(1, null);
            return temp;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
