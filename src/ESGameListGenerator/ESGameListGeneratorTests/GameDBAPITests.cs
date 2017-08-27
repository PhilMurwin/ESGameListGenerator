using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESGameListGenerator.GameDBAPI;

namespace ESGameListGeneratorTests
{
    [TestClass]
    public class GameDBAPITests
    {
        [TestMethod]
        public void GetGameDataNoPlatform()
        {
            // Act
            var gamedata = GameDBAPIv1.GetGame( "Baku Baku" );

            // Assert
            Assert.AreEqual( 5, gamedata.Game.Count );
        }

        [TestMethod]
        public void GetGameDataWithPlatform()
        {
            // Act
            var gamedata = GameDBAPIv1.GetGame( "Baku Baku", "Sega Game Gear" );

            // Assert
            Assert.AreEqual( 1, gamedata.Game.Count );
        }
    }
}
