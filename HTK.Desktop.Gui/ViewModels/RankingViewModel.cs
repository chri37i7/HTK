using HTK.DataAccess;
using HTK.DataAccess.Factory;
using HTK.Desktop.Gui.ViewModels.Base;
using HTK.Entities.Models;
using HTK.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HTK.Desktop.Gui.ViewModels
{
    public class RankingViewModel : ViewModelBase<Ranking>
    {
        #region Methods
        /// <summary>
        /// Loads all members in from the database
        /// </summary>
        /// <returns></returns>
        protected override async Task LoadAllAsync()
        {
            // Create factory, and get the instance
            RepositoryFactory<RankingRepository, Ranking> rankingFactory = RepositoryFactory<RankingRepository, Ranking>.GetInstance();
            // Create repository with the factory
            RankingRepository rankingRepository = rankingFactory.Create();
            // Get all reservations
            IEnumerable<Ranking> rankings = await rankingRepository.GetAllAsync();
            // Replace collection
            Items.ReplaceWith(rankings);
        }
        #endregion
    }
}