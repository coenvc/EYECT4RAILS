using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;

namespace eyect4rails.IRepository
{
    interface ITrackRepository
    {
        List<Track> GetAll();

        Track GetById(int id);

        bool Insert(Track track);

        void Update(int id, Track track);

        bool Delete(int id);
    }
}
