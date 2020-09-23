using System;
using System.Collections.Generic;

#nullable disable

namespace HTKKlub.Entities.Models
{
    public partial class Reservation
    {
        public int PkReservationId { get; set; }
        public int FkCourtId { get; set; }
        public int FkFirstMember { get; set; }
        public int FkSecondMember { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual Court FkCourt { get; set; }
        public virtual Member FkFirstMemberNavigation { get; set; }
        public virtual Member FkSecondMemberNavigation { get; set; }
    }
}
