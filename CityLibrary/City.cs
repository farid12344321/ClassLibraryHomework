using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrary
{
    public class City
    {
        private string? _name;
        protected int _population;
        public string? Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (CityName(value))
                {
                    _name = value;
                }
            }
        }
        public virtual int Population 
        {
            get
            {
                return _population;
            }
            set
            {
                if (value > 0) _population = value;
            }
        }

        private bool CityName(string? name)
        {
            if (String.IsNullOrWhiteSpace(name)) return false;
            if(name.Length < 3 || name.Length > 20) return false;
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
