using HTKKlub.DataAccess.Base;
using HTKKlub.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HTKKlub.DataAccess
{
    public class ReservationRepository : RepositoryBase<Reservation>
    {
        /// <summary>
        /// Returns all reservations included with members and which court
        /// </summary>
        /// <returns></returns>
        public override async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return await context.Set<Reservation>()
                .Include("Members")
                .Include("Courts")
                .ToListAsync();
        }
    }
}