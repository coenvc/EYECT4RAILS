using System.Collections.Generic;
using eyect4rails.Classes;

namespace eyect4rails.IRepository
{
    interface ITramRepository
    {
        List<Tram> GetAll();

        Tram GetById(int id);

        bool SetParkedTrack(Tram tram, Track track);

        bool Insert(Tram tram);

        void Update(int id, Tram tram);

        bool Delete(int id);
    }
}
