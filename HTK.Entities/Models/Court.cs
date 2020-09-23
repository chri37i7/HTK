using System;
using System.Collections.Generic;

#nullable disable

namespace HTK.Entities.Models
{
    public partial class Court
    {
        public Court()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int PkCourtId { get; set; }
        public string CourtName { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
