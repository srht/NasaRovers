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
            string respectiveCompassValues = "NESW";
            int maxX = 5, maxY=5;
            var rover = new Rover('E', 3, 3);
            int currentCompassIndex = respectiveCompassValues.IndexOf(rover.Heading);
            string commandsString = "MMRMMRMRRM";
            foreach (char command in commandsString)
            {
                switch (command)
                {
                    case 'L':currentCompassIndex--; break;
                    case 'R':currentCompassIndex++; break;
                    case 'M':
                        if (respectiveCompassValues[currentCompassIndex] == 'E')
                        {
                            if (rover.X<maxX) rover.X++;
                        }
                           
                        else if (respectiveCompassValues[currentCompassIndex] == 'W')
                        {
                            if(rover.X>0) rover.X--;
                        }
                            
                        else if (respectiveCompassValues[currentCompassIndex] == 'N')
                        {
                            if(rover.Y<maxY) rover.Y++;
                        }
                        else if (respectiveCompassValues[currentCompassIndex] == 'S')
                        {
                            if(rover.Y>0) rover.Y--;
                        }
                        break;
                }

                if(currentCompassIndex<0)
                currentCompassIndex = currentCompassIndex + respectiveCompassValues.Length;

                if (currentCompassIndex >= respectiveCompassValues.Length)
                    currentCompassIndex = currentCompassIndex-respectiveCompassValues.Length;

                rover.Heading = respectiveCompassValues[currentCompassIndex];
            }

            Console.WriteLine(rover);

            Console.Read();
        }
    }
}
