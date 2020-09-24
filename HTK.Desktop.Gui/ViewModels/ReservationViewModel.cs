using HTK.DataAccess;
using HTK.DataAccess.Factory;
using HTK.Desktop.Gui.ViewModels.Base;
using HTK.Entities.Models;
using HTK.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HTK.Desktop.Gui.ViewModels
{
    public class ReservationViewModel : ViewModelBase<Reservation>
    {
        #region Methods
        /// <summary>
        /// Override of <see cref="LoadAllAsync"/> to use <see cref="ReservationRepository"/> instead for including navigation properties
        /// </summary>
        /// <returns></returns>
        protected override async Task LoadAllAsync()
        {
            // Create factory, and get the instance
            RepositoryFactory<ReservationRepository, Reservation> reservationFactory = RepositoryFactory<ReservationRepository, Reservation>.GetInstance();
            // Create repository with the factory
            ReservationRepository reservationRepository = reservationFactory.Create();
            // Get all reservations
            IEnumerable<Reservation> reservations = await reservationRepository.GetAllAsync();
            // Replace collection
            Items.ReplaceWith(reservations);
        }
        #endregion
    }
}