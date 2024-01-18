using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrary
{
    public class ChinaCity:City
    {
        public override int Population
        {
            get => _population;
            set { if (value >= 100000) _population = value; }
        }
    }
}
