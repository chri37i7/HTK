using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HTK.DataAccess;
using HTK.Entities.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTK.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RankingController : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IEnumerable<Ranking>> GetAllAsync()
        {
            return await new RankingRepository().GetAllAsync();
        }
    }
}