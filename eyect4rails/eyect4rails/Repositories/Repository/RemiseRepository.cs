using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Repository
{
    class RemiseRepository : IRemiseRepository
    {
        private List<Remise> Remiselist = new List<Remise>();
       
        public RemiseRepository()
        {

            
            Address address1 = new Address(1,"Stremsingel", "Valkerswaard", "Netherlands", "5341HH", "22A");
            Remise remise1 = new Remise(1, "Valkerswaard",address1, "+316 124 124 12");
            Remiselist.Add(remise1);
             //new Remise(2, "Elkersingel", new Address("Elkersingel", "Schubberveen", "Netherlands", "5176AS", "1"), "+314 944 512 31"),
             //   new Remise(3, "Vonkersoord", new Address("Volkelseweg", "Welkeringen", "Netherlands", "6089HA", "561"), "+315 123 897 52")
            
        }

        public List<Remise> GetAll()
        {
            return Remiselist;
        }

        public Remise GetByID(int id)
        {
            foreach (Remise remise in Remiselist)
            {
                if (remise.Id == id)
                {
                    return remise;
                }
            }
            return null;
        }

        public List<Track> GetTracksByID(int id)
        {
            foreach (Remise remise in Remiselist)
            {
                if (remise.Id == id)
                {
                    return remise.Tracklist;
                }
            }
            return null;
        }

        public bool Insert(Remise remise)
        {
            int listcount = Remiselist.Count;
            Remiselist.Add(remise);
            return listcount + 1 == Remiselist.Count;
        }

        public void Update(int id, Remise remise)
        {
            foreach (Remise selectedRemise in Remiselist)
            {
                if (selectedRemise.Id == id)
                {
                    selectedRemise.Name = remise.Name;
                    selectedRemise.Tracklist = remise.Tracklist;
                    selectedRemise.Address = remise.Address;
                    selectedRemise.TelephoneNumber = remise.TelephoneNumber;
                }
            }
        }

        public bool Delete(int id)
        {
            foreach (Remise remise in Remiselist)
            {
                if (remise.Id == id)
                {
                    Remiselist.Remove(remise);
                    return true;
                }
            }
            return false;
        }
    }
}
