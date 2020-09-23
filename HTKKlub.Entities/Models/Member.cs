﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HTKKlub.Entities.Models
{
    public partial class Member
    {
        public Member()
        {
            Rankings = new HashSet<Ranking>();
            ReservationFkFirstMemberNavigations = new HashSet<Reservation>();
            ReservationFkSecondMemberNavigations = new HashSet<Reservation>();
        }

        public int PkMemberId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Ranking> Rankings { get; set; }
        public virtual ICollection<Reservation> ReservationFkFirstMemberNavigations { get; set; }
        public virtual ICollection<Reservation> ReservationFkSecondMemberNavigations { get; set; }
    }
}