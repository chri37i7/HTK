using HTKKlub.DataAccess.Base;
using HTKKlub.Entities.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTKKlub.Tests
{
    /// <summary>
    /// Used for testing the repository implementation
    /// </summary>
    [TestClass]
    public class RepositoryTests
    {
        /// <summary>
        /// Tests that a member returned by id is not null
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetMemberById()
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
        /// Tests that all orders are returned
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetAllOrders()
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
    }
}