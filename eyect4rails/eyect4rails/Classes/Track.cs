﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    public class Track
    {
        public int Id;
        public bool ConductorRequired;
        public int Sectors;
        public List<Tram> TramList;
        public string TrackType { get; private set; }

        public Track(int id, bool conductorRequired, int sectors, string tracktype)
        {
            this.Id = id;
            this.ConductorRequired = conductorRequired;
            this.Sectors = sectors;
            SetTrackType(tracktype);
        }
        

        public bool SetTrackType(string type)
        {
            if (type == "GateTrack" || type == "ParkTrack")
            {
                this.TrackType = type;
                return true;
            }
            return false;
        }
    }
}
