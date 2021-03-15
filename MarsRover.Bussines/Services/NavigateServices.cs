using MarsRover.Bussines.Models;
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
        public static void SetRoverPosition(this ProcessedCommands processedCommands)
        {
            if (processedCommands.StartPosition.XPoint<0 && processedCommands.StartPosition.YPoint<0)
            {
                processedCommands.StartPosition.XPoint = 0;
                processedCommands.StartPosition.YPoint = 0;
                processedCommands.CurrentPosition.XPoint = 0;
                processedCommands.CurrentPosition.YPoint = 0;
            }
            else
            {
                processedCommands.CurrentPosition.XPoint = processedCommands.StartPosition.XPoint;
                processedCommands.CurrentPosition.YPoint = processedCommands.StartPosition.YPoint;
            }
        }
        public static string CurrentPosition(this ProcessedCommands processedCommands)
        {
            return processedCommands.CurrentPosition.XPoint.ToString() + " " + processedCommands.CurrentPosition.YPoint.ToString() + " " + processedCommands.CurrentPosition.LookingDirection;
        }

    }
}
