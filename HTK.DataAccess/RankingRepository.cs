using HTK.DataAccess.Base;
using HTK.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HTK.DataAccess
{
    /// <summary>
    /// <see cref="Ranking"/> specialization of <see cref="RepositoryBase{T}"/> to include navigation properties
    /// </summary>
    public class RankingRepository : RepositoryBase<Ranking>
    {
        /// <summary>
        /// Returns all rankings included members
        /// </summary>
        /// <returns></returns>
        public override async Task<IEnumerable<Ranking>> GetAllAsync()
        {
            return await context.Set<Ranking>().Include("Members").ToListAsync();
        }
    }
}