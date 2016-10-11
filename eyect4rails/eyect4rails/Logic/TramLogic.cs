using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Logic
{
    class TramLogic : ITramRepository
    {
        private ITramRepository Context;

        public TramLogic(ITramRepository context)
        {
            this.Context = context;
        }

        public List<Tram> GetAll()
        {
            return Context.GetAll();
        }

        public Tram GetById(int id)
        {
            return Context.GetById(id);
        }

        public bool SetParkedTrack(Tram tram, Track track)
        {
            return Context.SetParkedTrack(tram, track);
        }

        public bool Insert(Tram tram)
        {
            return Context.Insert(tram);
        }

        public void Update(int id, Tram tram)
        {
            Context.Update(id, tram);
        }

        public bool Delete(int id)
        {
            return Context.Delete(id);
        }
    }
}
