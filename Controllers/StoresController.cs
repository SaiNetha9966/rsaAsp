using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactApiRsa.Models;
using System.Data.SqlClient;

namespace ReactApiRsa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public StoresController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("StoresList")]
        public Response StoresList()
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DBBASE").ToString());
            Methods dal = new Methods();
            response = dal.GetStores(connection);
            return response;
        }

    }
}
