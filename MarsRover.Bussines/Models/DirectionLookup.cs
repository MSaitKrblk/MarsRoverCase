using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Bussines.Models
{
    public class DirectionLookup
    {
        public char LookingDirection { get; set; }
        public char Instruction { get; set; }
        public char NewDirection { get; set; }

        public readonly List<DirectionLookup> directionLookups = new List<DirectionLookup>
        {
            new DirectionLookup
            {
                 LookingDirection='N',
                 Instruction='L',
                 NewDirection='W'
            },
            new DirectionLookup
            {
                 LookingDirection='W',
                 Instruction='L',
                 NewDirection='S'
            },
            new DirectionLookup
            {
                 LookingDirection='S',
                 Instruction='L',
                 NewDirection='E'
            },
            new DirectionLookup
            {
                 LookingDirection='E',
                 Instruction='L',
                 NewDirection='N'
            },
            new DirectionLookup
            {
                 LookingDirection='N',
                 Instruction='R',
                 NewDirection='E'
            },
            new DirectionLookup
            {
                 LookingDirection='E',
                 Instruction='R',
                 NewDirection='S'
            },
            new DirectionLookup
            {
                 LookingDirection='S',
                 Instruction='R',
                 NewDirection='W'
            },
            new DirectionLookup
            {
                 LookingDirection='W',
                 Instruction='R',
                 NewDirection='N'
            },

        };
    }
}
