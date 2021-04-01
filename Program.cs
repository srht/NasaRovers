using NasaRovers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            var roverAction = new RoverAction();

            roverAction.CurrentRover = new Rover('E', 3, 3);
            roverAction.PlateuScale = new PlateuScale(xMax: 5, yMax: 5);

            string commandsString = "MMRMMRMRRM";
            roverAction.ProcessCommands(commandsString);
            Console.WriteLine(roverAction.CurrentRover);

            Console.Read();
        }
    }
}
