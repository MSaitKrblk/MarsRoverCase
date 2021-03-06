using MarsRover.Core.Enums;
using MarsRover.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MarsRover.Bussines.Services
{
    public static class NavigateServices
    {
        public static Direction direction;
        public static string CurrentPosition(this ProcessedCommands processedCommands)
        {
            return processedCommands.CurrentPosition.XPoint.ToString() + " " + processedCommands.CurrentPosition.YPoint.ToString() + " " + processedCommands.CurrentPosition.LookingDirection;
        }
        public static void Process(this ProcessedCommands processedCommands)
        {
            for (int i = 0; i < processedCommands.Commands.Length; i++)
            {
                processedCommands.RunCommand(processedCommands.Commands[i]);
            }
        }

        public static void RunCommand(this ProcessedCommands processedCommands, char command)
        {
            if ('L' == command)
                processedCommands.TurnLeft();
            else if ('R' == command)
                processedCommands.TurnRight();
            else if ('M' == command)
            {
                if (!processedCommands.Move())
                    Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine("Unknown Variable!");
            }
        }
        public static void TurnLeft(this ProcessedCommands processedCommands)
        {
            processedCommands.CurrentPosition.LookingDirection = ((int)processedCommands.CurrentPosition.LookingDirection - 1) < (int)Direction.N ? Direction.W : (Direction)((int)processedCommands.CurrentPosition.LookingDirection - 1);
        }
        public static void TurnRight(this ProcessedCommands processedCommands)
        {
            processedCommands.CurrentPosition.LookingDirection = ((int)processedCommands.CurrentPosition.LookingDirection + 1) > (int)Direction.W ? Direction.N : (Direction)((int)processedCommands.CurrentPosition.LookingDirection + 1);
        }
        public static bool Move(this ProcessedCommands processedCommands)
        {
            try
            {
                switch (processedCommands.CurrentPosition.LookingDirection)
                {
                    case Direction.N:
                            processedCommands.CurrentPosition.YPoint += 1;
                        break;
                    case Direction.E:
                            processedCommands.CurrentPosition.XPoint += 1;
                        break;
                    case Direction.S:
                            processedCommands.CurrentPosition.YPoint -= 1;
                        break;
                    case Direction.W:
                            processedCommands.CurrentPosition.XPoint -= 1;
                        break;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
