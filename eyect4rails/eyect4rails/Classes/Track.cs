using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    public class Track
    {
        // Creator: Reinoud
        
        public int Number;
        public bool ConductorRequired;
        public int Sectors;
        public Enums.TrackType Tracktype;

        public Track(int number, bool conductorRequired, int sectors, Enums.TrackType tracktype)
        {
            this.Number = number;
            this.ConductorRequired = conductorRequired;
            this.Sectors = sectors;
            this.Tracktype = tracktype;
        }
    }
}
