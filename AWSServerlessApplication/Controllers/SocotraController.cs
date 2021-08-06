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

        [HttpGet]
        [Route("getvalues")]
        public string GetValues()
        {
            return "{\"fieldValues\":{\"external_value_here\":[\"Hello from aws function app\"]}}";
        }
    }
}
