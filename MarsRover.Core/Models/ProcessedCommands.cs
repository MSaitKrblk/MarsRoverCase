﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Models
{
    public class ProcessedCommands
    {
        public Plateau Plateau { get; set; }
        public StartPosition StartPosition { get; set; }
        public char[] Commands { get; set; }
    }
}