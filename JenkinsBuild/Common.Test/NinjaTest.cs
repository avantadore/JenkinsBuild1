using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Common.Test
{
    [TestClass]
    public class NinjaTest
    {
        [TestMethod]
        public void GivenListOfNinjaswithSkillLevel10and20and30_whenMinSkillLevelIs20_thenReturn2Nijas()
        {
            // Arrange
            var ninjaDataProvider = new Mock<INinjaDataProvider>();
            ninjaDataProvider.Setup(m => m.GetNinjas()).
                Returns(new List<INinja>()
                {
                    new Ninja("Ole", 10),
                    new Ninja("Ninja Niller", 20),
                    new Ninja("Q", 30)
                });
            var ninjaRepo = new NinjaRepository(ninjaDataProvider.Object);

            // Act
            var result = ninjaRepo.NinjasWithSkillMinimunSkillLevel(20);

            // Assert
            Assert.IsTrue(result.Count() == 2);
        }

        [TestMethod]
        public void GivenListOfNinjas_whenSkillLevelIs10and30and30_ThenFindTwoNinjasWhenSearchingTheBestNinja()
        {
            // Arrange
            var ninjaDataProvider = new Mock<INinjaDataProvider>();
            ninjaDataProvider.Setup(m => m.GetNinjas()).
                Returns(new List<INinja>()
                {
                    new Ninja("Ole", 10),
                    new Ninja("Ninja Niller", 30),
                    new Ninja("Q", 30)
                });
            var ninjaRepo = new NinjaRepository(ninjaDataProvider.Object);

            // Act
            var result = ninjaRepo.BestNinja();

            // Assert
            Assert.IsTrue(result.Count() == 2);
            Assert.IsTrue(result.Any(x => x.Name.Equals("Ninja Niller")));
            Assert.IsTrue(result.Any(x => x.Name.Equals("Q")));
        }

        [TestMethod]
        public void GivenEmptyListOfNinjas_whenSearchingForBestNinja_ThenFindZeroNinjas()
        {
            // Arrange
            var ninjaDataProvider = new Mock<INinjaDataProvider>();
            ninjaDataProvider.Setup(m => m.GetNinjas()).Returns(new List<INinja>());
            var ninjaRepo = new NinjaRepository(ninjaDataProvider.Object);

            // Act
            var result = ninjaRepo.BestNinja();

            // Assert
            Assert.IsTrue(!result.Any());
        }

    }
}
