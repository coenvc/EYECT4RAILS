using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Logic
{
    class TrackLogic : ITrackRepository
    {
        private ITrackRepository Context;

        public TrackLogic(ITrackRepository context)
        {
            this.Context = context;
        }

        public List<Track> GetAll()
        {
            return Context.GetAll();
        }

        public Track GetById(int id)
        {
            return Context.GetById(id);
        }

        public bool Insert(Track track)
        {
            return Context.Insert(track);
        }

        public void Update(int id, Track track)
        {
            Context.Update(id, track);
        }

        public bool Delete(int id)
        {
            return Context.Delete(id);
        }

       
    }
}
