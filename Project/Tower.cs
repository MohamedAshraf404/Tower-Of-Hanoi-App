using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towers_of_hanoi
{
    class Tower
    {
        plate[] plates;
        public int noelementes;

        public Tower(int noplates)
        {
            plates = new plate[noplates];
            noelementes = 0;
        }
        public void AddPlate(plate p)
        {
            this.plates[noelementes] = p;
            noelementes++;
        }
        public plate removeplate()
        {
            noelementes--;
            return plates[noelementes];
        }
        public plate lastestelement()
        {
            return plates[noelementes - 1];
        }
        public int NoFainalRange()
        {
            if (noelementes != 0)
            {
                return plates[noelementes - 1].norange;

            }
            else
            {
                return 0;
            }
        }
    }
}
