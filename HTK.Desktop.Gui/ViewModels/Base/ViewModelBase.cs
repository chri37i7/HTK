﻿using HTK.DataAccess.Base;
using HTK.DataAccess.Factory;
using HTK.Utilities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HTK.Desktop.Gui.ViewModels.Base
{
    /// <summary>
    /// Generic base class for easy implementation
    /// </summary>
    public abstract class ViewModelBase<TModel> : BindableBase where TModel : class
    {
        #region Fields
        protected ObservableCollection<TModel> items;
        protected TModel selectedItem;
        #endregion

        #region Constructor
        public ViewModelBase()
        {
            items = new ObservableCollection<TModel>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// The displayed items in the view
        /// </summary>
        public ObservableCollection<TModel> Items
        {
            get
            {
                return items;
            }
            set
            {
                SetProperty(ref items, value);
            }
        }

        /// <summary>
        /// The selected item in the view
        /// </summary>
        public TModel SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                SetProperty(ref selectedItem, value);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calls the <see cref="LoadAllAsync"/> method used to load all viewmodel data.
        /// </summary>
        public virtual async Task InitializeAsync()
        {
            // Load items
            await LoadAllAsync();
        }

        /// <summary>
        /// Loads all items from the database
        /// </summary>
        /// <returns></returns>
        protected virtual async Task LoadAllAsync()
        {
            // Create factory, and get the instance
            RepositoryFactory<RepositoryBase<TModel>, TModel> repositoryFactory = RepositoryFactory<RepositoryBase<TModel>, TModel>.GetInstance();
            // Create repository with the factory
            RepositoryBase<TModel> itemRepository = repositoryFactory.Create();
            // Get all reservations
            IEnumerable<TModel> items = await itemRepository.GetAllAsync();
            // Replace collection
            Items.ReplaceWith(items);
        }
        #endregion
    }
}