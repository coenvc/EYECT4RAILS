using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Logic
{
    class RemiseLogic : IRemiseRepository
    {
        private IRemiseRepository Context;

        public RemiseLogic(IRemiseRepository context)
        {
            this.Context = context;
        }

        public List<Remise> GetAll()
        {
            return Context.GetAll();
        }

        public Remise GetByID(int id)
        {
            return Context.GetByID(id);
        }

        public List<Track> GetTracksByID(int id)
        {
            return Context.GetTracksByID(id);
        }

        public bool Insert(Remise remise)
        {
            return Context.Insert(remise);
        }

        public void Update(int id, Remise remise)
        {
            Context.Update(id, remise);
        }

        public bool Delete(int id)
        {
            return Context.Delete(id);
        }
    }
}
