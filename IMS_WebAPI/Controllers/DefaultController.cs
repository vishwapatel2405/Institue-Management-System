using IMS_WebAPI.BAL;
using IMS_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IMS_WebAPI.Controllers
{
    public class DefaultController : ApiController
    {
        UserAuthHelper uah = new UserAuthHelper();
        // GET: api/Default
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Default/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Default
        public void Post([FromBody]t_user value)
        {
            uah.Register(value);
           

        }
        public bool Login([FromBody]vm_login value)
        {
            if(uah.Login(value))
            {
                return true;
            }
            return false;


        }
        // PUT: api/Default/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Default/5
        //public void Delete(int id)
        //{
        //}
    }
}
