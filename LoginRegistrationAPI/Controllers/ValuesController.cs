using LoginRegistrationUtilities;
using LoginRegistrationUtilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginRegistrationAPI.Controllers
{
    public class ValuesController : ApiController
    {
        IGetRegisterData _igetRegisterData = null;

        public ValuesController(IGetRegisterData getRegisterData)
        {
            _igetRegisterData = getRegisterData;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            if (!ModelState.IsValid)
            { 
                RegisterMM register = new RegisterMM();
                _igetRegisterData.RegisterUser(register);
            }
            else
            {
                Console.WriteLine(BadRequest("Not a valid model"));
            }

            
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
