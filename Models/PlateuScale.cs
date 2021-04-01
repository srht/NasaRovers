using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRovers.Models
{
    struct PlateuScale
    {
       public int XmaxPlateuCoordinate;
       public int YmaxPlateuCoordinate;
        public PlateuScale(int xMax, int yMax)
        {
            XmaxPlateuCoordinate = xMax;
            YmaxPlateuCoordinate = yMax;
        }
    }
}
