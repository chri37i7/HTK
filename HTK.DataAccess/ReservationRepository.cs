﻿using HTK.DataAccess.Base;
using HTK.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HTK.DataAccess
{
    public class ReservationRepository : RepositoryBase<Reservation>
    {
        /// <summary>
        /// Returns all reservations included with members and court
        /// </summary>
        /// <returns></returns>
        public override async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return await context.Set<Reservation>()
                .Include("FkCourt")
                .Include("FkFirstMemberNavigation")
                .Include("FkSecondMemberNavigation")
                .ToListAsync();
        }
    }
}