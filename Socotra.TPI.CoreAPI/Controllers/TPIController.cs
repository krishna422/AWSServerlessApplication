using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Socotra.TPI.BLL.Services;

namespace Socotra.TPI.CoreAPI.Controllers
{
    [Route("api/TPI")]
    [ApiController]
    public class TPIController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        [Route("GetLatLongTerritory")]
        [HttpPost]
        public dynamic GetLatLongTerritory(dynamic policyRequest)
        {
            try
            {
                PreciselyService preciselyService = new PreciselyService();
                dynamic response = preciselyService.GetLatLongTerritory(policyRequest);
                return response;
            }
            catch(Exception ex)
            {                
                ExceptionService.LogException(ex, policyRequest, "Error in 'GetLatLongTerritory' API");
                return null;
            }
        }
    }
}
