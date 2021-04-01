using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRovers
{
    interface IRoverAction
    {
        void ProcessCommands(string commandsString);
    }
}
