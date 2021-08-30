using Socotra.TPI.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Socotra.TPI.BLL.Integrations
{
    public class PreciselyTransformations
    {
        public PreciselyResponse FormLatLong()
        {
            PreciselyResponse preciselyResponse = new PreciselyResponse();
            return preciselyResponse;
        }

        public TerritoryCodeResponse FormTerritoryCodes()
        {
            TerritoryCodeResponse territoryCodeResponse = new TerritoryCodeResponse();
            return territoryCodeResponse;
        }
    }
}
