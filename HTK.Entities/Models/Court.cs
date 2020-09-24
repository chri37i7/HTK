using HTK.Utilities;
using System;
using System.Collections.Generic;

namespace HTK.Entities.Models
{
    /// <summary>
    /// Represents a court at HTK
    /// </summary>
    public partial class Court
    {
        #region Fields
        protected int pkCourtId;
        protected string courtName; 
        #endregion

        #region Constructor
        public Court()
        {
            Reservations = new HashSet<Reservation>();
        } 
        #endregion

        #region Properties
        /// <summary>
        /// Datebase id of the <see cref="Court"/>
        /// </summary>
        public virtual int PkCourtId
        {
            get { return pkCourtId; }
            set
            {
                if(pkCourtId != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                    if(isValid)
                    {
                        pkCourtId = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(PkCourtId));
                    }
                }
            }
        }

        /// <summary>
        /// Name of the <see cref="Court"/>
        /// </summary>
        public virtual string CourtName
        {
            get { return courtName; }
            set
            {
                if(courtName != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsStringNull(value);
                    if(isValid)
                    {
                        courtName = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(CourtName));
                    }
                }
            }
        }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Reservation> Reservations { get; set; } 
        #endregion
    }
}