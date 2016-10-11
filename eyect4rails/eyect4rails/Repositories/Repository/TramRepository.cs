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
                new Tram(1, TramType.Combino, 5, false),
                new Tram(2, TramType.DubbelekopCombino, 2, false),
                new Tram(3, TramType.Combino, 9, false),
                new Tram(4, TramType.ElevenG, 6, false),
                new Tram(5, TramType.TwelveG, 3, false),
                new Tram(6, TramType.Opleidingstrein, 4, false),
                new Tram(7, TramType.Opleidingstrein, 2, false),
                new Tram(8, TramType.TwelveG, 7, false),
                new Tram(9, TramType.ElevenG, 8, false),
                new Tram(10, TramType.DubbelekopCombino, 6, false),
                new Tram(11, TramType.DubbelekopCombino, 6, false),
                new Tram(12, TramType.Combino, 2, false)
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
                    tramlistitem.TramType = tram.TramType;
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
