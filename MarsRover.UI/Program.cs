using MarsRover.Bussines.Services;
using MarsRover.Core.Models;
using System;

namespace MarsRover.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau(5, 5);
            //Console.WriteLine(Enum.GetName())
            Position position = new Position(1, 2, Core.Enums.Direction.E);
            ProcessedCommands processedCommands = new ProcessedCommands(plateau,position,"MML");
            processedCommands.Process();
            Console.WriteLine(NavigateServices.CurrentPosition(processedCommands));
            Console.WriteLine(position.YPoint);
        }
    }
}
