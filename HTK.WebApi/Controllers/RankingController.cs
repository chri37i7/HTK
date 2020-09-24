using System.Collections.Generic;
using System.Threading.Tasks;
using HTK.DataAccess;
using HTK.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace HTK.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RankingController : ControllerBase
    {
        /// <summary>
        /// Get all rankings from the database
        /// </summary>
        /// <returns>/returns>
        [HttpGet("all")]
        public async Task<IEnumerable<Ranking>> GetAllAsync()
        {
            return await new RankingRepository().GetAllAsync();
        }
    }
}