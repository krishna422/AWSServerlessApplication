using Socotra.TPI.BLL.Integrations;
using Socotra.TPI.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Socotra.TPI.BLL.Services
{
    public class PreciselyService
    {
        public dynamic GetLatLongTerritory(dynamic policyRequest)
        {
            dynamic response = new { };
            PreciselyResponse preciselyResponse =  GetLatLongFromAppSync();
            string gridId = FormGridId(preciselyResponse);
            TerritoryCodeResponse territoryCodeResponse = GetTerritoryCodesFromAppSync(gridId);
            return response;
        }

        private string FormGridId(PreciselyResponse preciselyResponse)
        {
            string gridId = "";
            return gridId;
        }

        private PreciselyResponse GetLatLongFromAppSync()
        {
            PreciselyTransformations preciselyTransformations = new PreciselyTransformations();
            PreciselyResponse preciselyResponse =  preciselyTransformations.FormLatLong();
            return preciselyResponse;
        }

        private TerritoryCodeResponse GetTerritoryCodesFromAppSync(string gridId)
        {
            PreciselyTransformations preciselyTransformations = new PreciselyTransformations();
            TerritoryCodeResponse territoryCodeResponse = preciselyTransformations.FormTerritoryCodes();
            return territoryCodeResponse;
        }
    }
}
