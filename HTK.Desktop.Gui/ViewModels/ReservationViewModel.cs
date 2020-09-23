﻿using HTK.DataAccess;
using HTK.DataAccess.Factory;
using HTK.Desktop.Gui.ViewModels.Base;
using HTK.Entities.Models;
using HTK.Utilities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HTK.Desktop.Gui.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        #region Properties
        protected ObservableCollection<Reservation> reservations;
        protected Reservation selectedReservation;
        #endregion

        #region Constructor
        public ReservationViewModel()
        {
            // Initialize collection to prevent error with the ReplaceWith extention method
            reservations = new ObservableCollection<Reservation>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// The displayed reservations in the view
        /// </summary>
        public ObservableCollection<Reservation> Reservations
        {
            get
            {
                return reservations;
            }
            set
            {
                SetProperty(ref reservations, value);
            }
        }

        /// <summary>
        /// The selected reservation in the view
        /// </summary>
        public Reservation SelectedReservation
        {
            get
            {
                return selectedReservation;
            }
            set
            {
                SetProperty(ref selectedReservation, value);
            }
        }
        #endregion

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
            Reservations.ReplaceWith(reservations);
        } 
        #endregion
    }
}