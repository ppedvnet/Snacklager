using System;
using System.Security.Principal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snacklager.Data;
using Snacklager.Data.Enums;
using Snacklager.Logic.Contracts;

namespace Snacklager.Logic.Tests
{
    [TestClass]
    public class LogicTests
    {
        // Arrange
        private readonly IRepository<Snack> _snackRepo = new Repository<Snack>();

        [TestMethod]
        public void SnackRepository_Should_Create_Snack()
        {
            // Arrange
            Snack snack = new Snack
            {
                Name = "Bounty",
                GewichtProEinheit = 12.34,
                SnackArtId = (int)SnackArtEnum.Schokolade
            };

            // Act
            _snackRepo.Insert(snack);
            bool result = _snackRepo.SaveAll();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
