using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRovers.Models
{
    public class Rover
    {
        public char Heading { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Rover(char heading, int x, int y)
        {
            Heading = heading;
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X} {Y} {Heading}";
        }
    }
}
