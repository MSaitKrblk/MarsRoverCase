using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Models
{
    public class ProcessedCommands
    {
        public Plateau Plateau { get; set; }
        public Position StartPosition { get; set; }
        public Position CurrentPosition { get; set; }
        public string Commands { get; set; }
    }
}
