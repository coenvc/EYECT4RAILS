using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.Enums;
using eyect4rails.IRepository;

namespace eyect4rails.Repository
{
    class TramRepository : ITramRepository
    {
        private List<Tram> Tramlist;

        public TramRepository()
        {
            Tramlist = new List<Tram>
            {
                ///
                /// HERE WILL BE A LIST FILLING THE TRAMLIST
                /// 
            };
        }

        public List<Tram> GetAll()
        {
            return Tramlist;
        }

        public Tram GetById(int id)
        {
            foreach (Tram tram in Tramlist)
            {
                if (tram.Id == id)
                {
                    return tram;
                }
            }
            return null;
        }

        public bool SetParkedTrack(Tram tram, Track track)
        {
            foreach (Tram tramlistitem in Tramlist)
            {
                if (tramlistitem == tram)
                {
                    tram.IsParked = true;
                    tram.ParkedTrack = track;
                    return true;
                }
            }
            return false;
        }
        
        public bool Insert(Tram tram)
        {
            int listcount = Tramlist.Count;
            Tramlist.Add(tram);
            return listcount + 1 == Tramlist.Count;
        }

        public void Update(int id, Tram tram)
        {
            foreach (Tram tramlistitem in Tramlist)
            {
                if (tram.Id == id)
                {
                    tramlistitem.SetTramType(tram.TramType);
                    tramlistitem.Sectors = tram.Sectors;
                    tramlistitem.IsParked = tram.IsParked;
                    tramlistitem.ParkedTrack = tram.ParkedTrack;
                }
            }
        }

        public bool Delete(int id)
        {
            foreach (Tram tram in Tramlist)
            {
                if (tram.Id == id)
                {
                    Tramlist.Remove(tram);
                    return true;
                }
            }
            return false;
        }
    }
}
