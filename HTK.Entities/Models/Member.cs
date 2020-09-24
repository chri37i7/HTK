using HTK.Utilities;
using System;
using System.Collections.Generic;

namespace HTK.Entities.Models
{
    /// <summary>
    /// Represents a <see cref="Member"/> of HTK
    /// </summary>
    public partial class Member
    {
        #region Fields
        protected int pkMemberId;
        protected string firstname;
        protected string lastname;
        protected string address;
        protected string email;
        protected string phone;
        protected DateTime birthdate; 
        #endregion

        #region Constructor
        public Member()
        {
            Rankings = new HashSet<Ranking>();
            ReservationFkFirstMember = new HashSet<Reservation>();
            ReservationFkSecondMember = new HashSet<Reservation>();
        } 
        #endregion

        #region Properties
        /// <summary>
        /// Database id of the <see cref="Member"/>
        /// </summary>
        public virtual int PkMemberId
        {
            get { return pkMemberId; }
            set
            {
                if(pkMemberId != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                    if(isValid)
                    {
                        pkMemberId = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(PkMemberId));
                    }
                }
            }
        }

        /// <summary>
        /// Firstname of the <see cref="Member"/>
        /// </summary>
        public virtual string Firstname
        {
            get { return firstname; }
            set
            {
                if(firstname != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsStringNull(value);
                    if(isValid)
                    {
                        firstname = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(Firstname));
                    }
                }
            }
        }

        /// <summary>
        /// Lastname of the <see cref="Member"/>
        /// </summary>
        public virtual string Lastname
        {
            get { return lastname; }
            set
            {
                if(lastname != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsStringNull(value);
                    if(isValid)
                    {
                        lastname = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(Lastname));
                    }
                }
            }
        }

        /// <summary>
        /// Address of the <see cref="Member"/>
        /// </summary>
        public virtual string Address
        {
            get { return address; }
            set
            {
                if(address != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsStringNull(value);
                    if(isValid)
                    {
                        address = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(Address));
                    }
                }
            }
        }

        /// <summary>
        /// Email of the <see cref="Member"/>
        /// </summary>
        public virtual string Email
        {
            get { return email; }
            set
            {
                if(email != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsStringNull(value);
                    if(isValid)
                    {
                        email = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(Email));
                    }
                }
            }
        }

        /// <summary>
        /// Birthdate of the <see cref="Member"/>
        /// </summary>
        public virtual DateTime Birthdate
        {
            get { return birthdate; }
            set
            {
                if(birthdate != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsDateBefore(value, DateTime.Now);
                    if(isValid)
                    {
                        birthdate = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(Birthdate));
                    }
                }
            }
        }

        /// <summary>
        /// Phone of the <see cref="Member"/>
        /// </summary>
        public virtual string Phone
        {
            get { return phone; }
            set
            {
                if(phone != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsStringNull(value);
                    if(isValid)
                    {
                        phone = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(Phone));
                    }
                }
            }
        } 
        #endregion

        #region Navigation Properties
        public virtual ICollection<Ranking> Rankings { get; set; }
        public virtual ICollection<Reservation> ReservationFkFirstMember { get; set; }
        public virtual ICollection<Reservation> ReservationFkSecondMember { get; set; } 
        #endregion
    }
}