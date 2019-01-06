using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.NTierBLL;
using Microsoft.AspNetCore.Mvc;

namespace NTier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        FacultyBLL _facBll = new FacultyBLL();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //string conString = "Data Source=DAUREN23\\MSSQLSERVER_DAUR;Initial Catalog=NTier;Integrated Security=True";
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            //if (con.State == System.Data.ConnectionState.Open)
            //{
            //    string q = "INSERT INTO Faculties(Faculty) VALUES('qwerty')";
            //    SqlCommand cmd = new SqlCommand(q, con);
            //    cmd.ExecuteNonQuery();
            //}
            //var temp = _facBll.Get(1, null);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
