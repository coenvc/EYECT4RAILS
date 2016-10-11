using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    public class Tram
    {
        public int Id;
        public string TramType { get; private set; }
        public string Status { get; private set; }
        public int Sectors;
        public bool IsParked;
        public Track ParkedTrack;

        public Tram(int id, string tramtype, int sectors, bool isParked)
        {
            this.Id = id;
            SetTramType(tramtype);
            this.Sectors = sectors;
            this.IsParked = isParked;
        }

        public bool SetTramType(string type)
        {
            if (type == "Combino" || type == "Dubbelkop Combino" || type == "11G" || type == "12G" || type == "Opleidingstrein")
            {
                this.TramType = type;
                return true;
            }
            return false;
        }

        public bool SetTramStatus(string status)
        {
            if (status == "Defect" || status == "Schoonmaak" || status == "Dienst" || status == "Remise" || status == "Onderhoud")
            {
                this.Status = status;
                return true;
            }
            return false;
        }
    }
}
