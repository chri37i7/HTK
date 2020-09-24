using HTK.Utilities;
using System;

namespace HTK.Entities.Models
{
    public partial class Ranking
    {
        #region Fields
        protected int pkRankId;
        protected int fkMemberId;
        protected int points; 
        #endregion

        #region Properties
        /// <summary>
        /// Id of the <see cref="Ranking"/>
        /// </summary>
        public virtual int PkRankId
        {
            get { return pkRankId; }
            set
            {
                if(pkRankId != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                    if(isValid)
                    {
                        pkRankId = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(PkRankId));
                    }
                }
            }
        }

        /// <summary>
        /// Id of the <see cref="Ranking"/> <see cref="Member"/>
        /// </summary>
        public virtual int FkMemberId
        {
            get { return fkMemberId; }
            set
            {
                if(fkMemberId != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                    if(isValid)
                    {
                        fkMemberId = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(FkMemberId));
                    }
                }
            }
        }

        /// <summary>
        /// Points of the <see cref="Ranking"/> <see cref="Member"/>
        /// </summary>
        public virtual int Points
        {
            get { return points; }
            set
            {
                if(points != value)
                {
                    (bool isValid, string errorMessage) = Validations.ValidateIsIntNegative(value);
                    if(isValid)
                    {
                        points = value;
                    }
                    else
                    {
                        throw new ArgumentException(errorMessage, nameof(Points));
                    }
                }
            }
        }
        #endregion

        #region Navigation Properties
        public virtual Member FkMember { get; set; } 
        #endregion
    }
}