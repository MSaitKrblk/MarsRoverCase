using MarsRover.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Models
{
    public class Position
    {
        public Position(int _XPoint, int _YPoint, Direction _Direction)
        {
            XPoint = _XPoint;
            YPoint = _YPoint;
            LookingDirection = _Direction;
        }
        public int XPoint { get; set; }
        public int YPoint { get; set; }
        public Direction LookingDirection { get; set; }
    }
}
