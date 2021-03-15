using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Models
{
    public class ProcessedCommands
    {
        public ProcessedCommands(Plateau _Plateau, Position _StartPosition, string _Commands)
        {
            Plateau = _Plateau;
            StartPosition = _StartPosition;
            CurrentPosition = _StartPosition;
            Commands = _Commands;
        }
        public Plateau Plateau { get; set; }
        public Position StartPosition { get; set; }
        public Position CurrentPosition { get; set; }
        public string Commands { get; set; }

    }
}
