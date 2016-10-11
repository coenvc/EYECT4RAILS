using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    public class Tram
    {
        // Creator: Reinoud
        
        public int Id;
        public Enums.TramType TramType;
        public int Sectors;
        public bool IsParked;
        public Track ParkedTrack;

        public Tram(int id, Enums.TramType tramtype, int sectors, bool isParked)
        {
            this.Id = id;
            this.TramType = tramtype;
            this.Sectors = sectors;
            this.IsParked = isParked;
        }
    }
}
