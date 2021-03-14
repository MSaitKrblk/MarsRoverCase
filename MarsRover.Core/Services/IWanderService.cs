using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Services
{
    public interface IWanderService
    {
        string Wander(IList<string> commands);
    }
}
