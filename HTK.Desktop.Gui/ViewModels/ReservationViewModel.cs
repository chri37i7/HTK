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