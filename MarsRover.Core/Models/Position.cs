using MarsRover.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Models
{
    public class Position
    {
        public int XPoint { get; set; }
        public int YPoint { get; set; }
        public Direction LookingDirection { get; set; }
    }
}
