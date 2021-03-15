using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Models
{
    public class Plateau
    {
        public int XLength { get; set; }
        public int YLength { get; set; }
        public Plateau(int XTotalLenght, int YTotalLenght)
        {
            if (XTotalLenght > 0 && YTotalLenght > 0)
            {
                XLength = XTotalLenght;
                YLength = YTotalLenght;
            }
            else
            {
                XLength = 0;
                YLength = 0;
            }
        }
    }
}
