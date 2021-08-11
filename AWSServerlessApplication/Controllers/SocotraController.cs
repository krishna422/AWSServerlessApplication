using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerlessApplication.Controllers
{
    [Route("api/socotra")]
    public class SocotraController : ControllerBase
    {
        const string baseURL = "https://api.sandbox.socotra.com/";

        [HttpPost]
        [Route("getvalues")]
        public string GetValues()
        {
            var str = "{\"fieldValues\":{\"external_value_here\":[\"New Values come here!!!\"]}}";
            return str;
        }
    }
}
