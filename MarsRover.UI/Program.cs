using MarsRover.Bussines.Services;
using MarsRover.Core.Models;
using System;
using System.Collections.Generic;

namespace MarsRover.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<ProcessedCommands> NavigatedRover = new List<ProcessedCommands>();

                string[] plateauString = Console.ReadLine().Split(' ');
                if (plateauString.Length != 2)
                    Console.WriteLine("Error!");

                Plateau plateau = new Plateau(int.Parse(plateauString[0]), int.Parse(plateauString[1]));
                for (int i = 0; i < 2; i++)
                {
                    Position position;
                    string[] GetRoverPosition = Console.ReadLine().Split(' ');
                    if (GetRoverPosition[2]=="N")
                    {
                        position = new Position(int.Parse(GetRoverPosition[0]), int.Parse(GetRoverPosition[1]), Core.Enums.Direction.N);
                    }
                    else if (GetRoverPosition[2] == "E")
                    {
                        position = new Position(int.Parse(GetRoverPosition[0]), int.Parse(GetRoverPosition[1]), Core.Enums.Direction.E);
                    }
                    else if (GetRoverPosition[2] == "S")
                    {
                        position = new Position(int.Parse(GetRoverPosition[0]), int.Parse(GetRoverPosition[1]), Core.Enums.Direction.S);
                    }
                    else
                    {
                        position = new Position(int.Parse(GetRoverPosition[0]), int.Parse(GetRoverPosition[1]), Core.Enums.Direction.W);
                    }
                    ProcessedCommands processedCommands = new ProcessedCommands(plateau, position, Console.ReadLine());
                    processedCommands.Process();
                    NavigatedRover.Add(processedCommands);
                }
                foreach (ProcessedCommands item in NavigatedRover)
                {
                    Console.WriteLine(item.CurrentPosition());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            

           
        }
    }
}
