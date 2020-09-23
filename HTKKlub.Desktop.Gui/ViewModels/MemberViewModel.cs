using HTKKlub.DataAccess.Base;
using HTKKlub.Desktop.Gui.ViewModels.Base;
using HTKKlub.Entities.Models;
using HTKKlub.Utilities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HTKKlub.Desktop.Gui.ViewModels
{
    public class MemberViewModel : ViewModelBase
    {
        #region Fields
        protected ObservableCollection<Member> members;
        protected Member selectedMember;
        #endregion

        #region Constructor
        public MemberViewModel()
        {
            members = new ObservableCollection<Member>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// The displayed members in the view
        /// </summary>
        public ObservableCollection<Member> Members
        {
            get
            {
                return members;
            }
            set
            {
                SetProperty(ref members, value);
            }
        }

        /// <summary>
        /// The selected member in the view
        /// </summary>
        public Member SelectedMember
        {
            get
            {
                return selectedMember;
            }
            set
            {
                SetProperty(ref selectedMember, value);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Loads all members in from the database
        /// </summary>
        /// <returns></returns>
        protected override async Task LoadAllAsync()
        {
            // Create repository object
            RepositoryBase<Member> repo = new RepositoryBase<Member>();
            // Get all members
            IEnumerable<Member> members = await repo.GetAllAsync();
            // Replace collection
            Members.ReplaceWith(members);
        } 
        #endregion
    }
}