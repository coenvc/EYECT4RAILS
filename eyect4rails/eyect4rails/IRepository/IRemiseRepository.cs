using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;

namespace eyect4rails.IRepository
{
    interface IRemiseRepository
    {
        List<Remise> GetAll();

        Remise GetByID(int id);
        List<Track> GetTracksByID(int id);

        bool Insert(Remise remise);

        void Update(int id, Remise remise);

        bool Delete(int id);
    }
}
