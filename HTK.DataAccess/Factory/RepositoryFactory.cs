using HTK.DataAccess.Base;
using HTK.Entities.Models;

namespace HTK.DataAccess.Factory
{
    /// <summary>
    /// Factory class for incapsulating DBContext
    /// </summary>
    /// <typeparam name="TRepository"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    public class RepositoryFactory<TRepository, TEntity>
           where TRepository : IRepositoryBase<TEntity>, new()
           where TEntity : class
    {
        #region Fields
        protected static RepositoryFactory<TRepository, TEntity> instance;
        protected HtkDbContext context;
        #endregion

        #region Constructor
        public RepositoryFactory() { }
        #endregion

        #region Methods
        /// <summary>
        /// Constructor for repository factory, needs context
        /// </summary>
        /// <returns></returns>
        public virtual TRepository Create()
        {
            if(context is null)
            {
                context = new HtkDbContext();
            }
            TRepository repo = new TRepository();
            repo.Context = context;
            return repo;
        }


        /// <summary>
        /// Gets the instance of the <see cref="RepositoryFactory{T}"/> if it exitsts, else it creates it.
        /// </summary>
        /// <returns>An instance of <see cref="RepositoryFactory{T}"/></returns>
        public static RepositoryFactory<TRepository, TEntity> GetInstance()
        {
            if(instance is null)
            {
                instance = new RepositoryFactory<TRepository, TEntity>();
            }
            return instance;
        }

        /// <summary>
        /// Disposes of the <see cref="context"/> object
        /// </summary>
        public virtual void KillContext()
        {
            context.Dispose();
        }
        #endregion
    }
}