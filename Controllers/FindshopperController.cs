using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReactApiRsa.Models;
using System.Data.SqlClient;

namespace ReactApiRsa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindshopperController : ControllerBase
    {
        private readonly IConfiguration _configuaration;

        public FindshopperController(IConfiguration configuaration)
        {
            _configuaration = configuaration;

        }

        [HttpPost]
        [Route("findShopper")]

        public Response FindShopper(FindShopper findShopper)
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection(_configuaration.GetConnectionString("DBBASE").ToString());
            Methods met  = new Methods();
            response = met.Shopper(findShopper, connection);
            return response;
        }

       

    }
}
