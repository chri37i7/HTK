using HTK.DataAccess.Base;
using HTK.Entities.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTK.Tests
{
    /// <summary>
    /// Used for testing the repository implementation
    /// </summary>
    [TestClass]
    public class RepositoryTests
    {
        #region Member Tests
        /// <summary>
        /// Tests that a member returned by id is not null
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public virtual async Task GetMemberById()
        {
            // Arrange
            RepositoryBase<Member> repository;
            Member member;

            // Act
            repository = new RepositoryBase<Member>();
            member = await repository.GetByIdAsync(1);

            // Assert
            Assert.IsNotNull(member);
        }

        /// <summary>
        /// Tests that all members are returned
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public virtual async Task GetAllMembers()
        {
            // Arrange
            RepositoryBase<Member> repository;
            IEnumerable<Member> members;

            // Act
            repository = new RepositoryBase<Member>();
            members = await repository.GetAllAsync();

            // Assert
            Assert.IsTrue(members.Count() > 0);
        }
        #endregion

        #region Court Tests
        /// <summary>
        /// Tests that a court returned by id is not null
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public virtual async Task GetCourtById()
        {
            // Arrange
            RepositoryBase<Court> repository;
            Court court;

            // Act
            repository = new RepositoryBase<Court>();
            court = await repository.GetByIdAsync(1);

            // Assert
            Assert.IsNotNull(court);
        }

        /// <summary>
        /// Tests that all courts are returned
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public virtual async Task GetAllCourts()
        {
            // Arrange
            RepositoryBase<Court> repository;
            IEnumerable<Court> courts;

            // Act
            repository = new RepositoryBase<Court>();
            courts = await repository.GetAllAsync();

            // Assert
            Assert.IsTrue(courts.Count() > 0);
        }
        #endregion

        #region Ranking Tests
        /// <summary>
        /// Tests that a rankings returned by id is not null
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public virtual async Task GetRankingById()
        {
            // Arrange
            RepositoryBase<Ranking> repository;
            Ranking rankings;

            // Act
            repository = new RepositoryBase<Ranking>();
            rankings = await repository.GetByIdAsync(1);

            // Assert
            Assert.IsNotNull(rankings);
        }

        /// <summary>
        /// Tests that all rankings are returned
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public virtual async Task GetAllRankings()
        {
            // Arrange
            RepositoryBase<Ranking> repository;
            IEnumerable<Ranking> rankings;

            // Act
            repository = new RepositoryBase<Ranking>();
            rankings = await repository.GetAllAsync();

            // Assert
            Assert.IsTrue(rankings.Count() > 0);
        }
        #endregion

        #region Ranking Tests
        /// <summary>
        /// Tests that a reservation returned by id is not null
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public virtual async Task GetReservationById()
        {
            // Arrange
            RepositoryBase<Reservation> repository;
            Reservation reservation;

            // Act
            repository = new RepositoryBase<Reservation>();
            reservation = await repository.GetByIdAsync(1);

            // Assert
            Assert.IsNotNull(reservation);
        }

        /// <summary>
        /// Tests that all reservations are returned
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public virtual async Task GetAllReservations()
        {
            // Arrange
            RepositoryBase<Reservation> repository;
            IEnumerable<Reservation> reservations;

            // Act
            repository = new RepositoryBase<Reservation>();
            reservations = await repository.GetAllAsync();

            // Assert
            Assert.IsTrue(reservations.Count() > 0);
        }
        #endregion
    }
}