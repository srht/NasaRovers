using NasaRovers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRovers
{
    class RoverAction:IRoverAction, IDisposable
    {
        const string CompassValues = "NESW";
        public Rover CurrentRover { get; set; }
        public PlateuScale PlateuScale { get; set; }

        public RoverAction()
        {
        }

        public void ProcessCommands(string commandsString)
        {
            int currentCompassIndex = CompassValues.IndexOf(CurrentRover.Heading);

            foreach (char command in commandsString)
            {
                switch (command) 
                {
                    case 'L': currentCompassIndex--; break;
                    case 'R': currentCompassIndex++; break;
                    case 'M':
                        if (CompassValues[currentCompassIndex] == 'E')
                        {
                            if (CurrentRover.X < PlateuScale.XmaxPlateuCoordinate) CurrentRover.X++;
                        }

                        else if (CompassValues[currentCompassIndex] == 'W')
                        {
                            if (CurrentRover.X > 0) CurrentRover.X--;
                        }

                        else if (CompassValues[currentCompassIndex] == 'N')
                        {
                            if (CurrentRover.Y < PlateuScale.YmaxPlateuCoordinate) CurrentRover.Y++;
                        }
                        else if (CompassValues[currentCompassIndex] == 'S')
                        {
                            if (CurrentRover.Y > 0) CurrentRover.Y--;
                        }
                        break;
                }

                if (currentCompassIndex < 0)
                    currentCompassIndex = currentCompassIndex + CompassValues.Length;

                if (currentCompassIndex >= CompassValues.Length)
                    currentCompassIndex = currentCompassIndex - CompassValues.Length;

                CurrentRover.Heading = CompassValues[currentCompassIndex];
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
