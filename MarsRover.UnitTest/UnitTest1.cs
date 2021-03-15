using MarsRover.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(1, 2, Core.Enums.Direction.N);
            ProcessedCommands rover = new ProcessedCommands(plateau, position, "LMLMLMLMM");
            Bussines.Services.NavigateServices.Process(rover);
            string resut = Bussines.Services.NavigateServices.CurrentPosition(rover);
            if (resut == "1 3 N")
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
            Position position2 = new Position(3, 3, Core.Enums.Direction.E);
            ProcessedCommands rover2 = new ProcessedCommands(plateau, position2, "MMRMMRMRRM");
            Bussines.Services.NavigateServices.Process(rover2);
            string resut2 = Bussines.Services.NavigateServices.CurrentPosition(rover2);
            if (resut2 == "5 1 E")
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }
    }
}
