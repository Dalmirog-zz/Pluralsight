using Microsoft.Framework.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TheWorld.Services
{
    public class CoordService
    {
        public CoordService(ILogger<CoordService> logger)
        {

        }

        public CoordServiceResult Lookup(string location)
        {
            var result = new CoordServiceResult()
            {
                Sucess = false,
                Message = "Undetermined failer while looking up coordinates"
            };

            //Lookup Coordinates
            var encodedName = WebUtility.UrlEncode(location);
            var bingKey = Startup.Configuration["AppSettings:BingKey"];
            var url = $"http://dev.virtualearth.net/REST/v1/Locations?q={encodedName}&key={bingKey}";

            return result;
        }
    }
}
