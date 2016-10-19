using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Logic
{
    class TramTransferLogic:ITramRepository,IRemiseRepository,ITrackRepository
    {
        List<Tram> ITramRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Track ITrackRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Track track)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Track track)
        {
            throw new NotImplementedException();
        }

        bool ITrackRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Remise GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Track> GetTracksByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Remise remise)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Remise remise)
        {
            throw new NotImplementedException();
        }

        bool IRemiseRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Track> ITrackRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Tram ITramRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public bool Insert(Tram tram)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Tram tram)
        {
            throw new NotImplementedException();
        }

        List<Remise> IRemiseRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        bool ITramRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
