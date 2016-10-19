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
    class TrackRepository : ITrackRepository
    {
        private List<Track> Tracklist;
        

        public TrackRepository()
        {
            Tracklist = new List<Track>
            {
                ///
                /// HERE WILL BE A LIST FILLING THE TRACKLIST
                /// 
            };
        }

        public List<Track> GetAll()
        {
            return Tracklist;
        }

        public Track GetById(int id)
        {
            foreach (Track track in Tracklist)
            {
                if (track.Id == id)
                {
                    return track;
                }
            }
            return null;
        }

        public bool Insert(Track track)
        {
            int listcount = Tracklist.Count;
            Tracklist.Add(track);
            return listcount + 1 == Tracklist.Count;
        }

        public void Update(int id, Track track)
        {
            foreach (Track selectedTrack in Tracklist)
            {
                if (selectedTrack.Id == id)
                {
                    selectedTrack.Id = track.Id;
                    selectedTrack.ConductorRequired = track.ConductorRequired;
                    selectedTrack.Sectors = track.Sectors;
                    selectedTrack.SetTrackType(track.TrackType);
                }
            }
        }

        public bool Delete(int id)
        {
            foreach (Track track in Tracklist)
            {
                if (track.Id == id)
                {
                    Tracklist.Remove(track);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// This method checks if a given tram fits inside the given track. 
        /// It checks if the sectors of the track are large enough for the tram and the trams that are allready parked there. 
        /// If this is true the tram can park at the track en the method return true and the tram IsParked bool is set to true.
        /// </summary>
        /// <param name="tram"> this tram is the tram that wants to park at the track</param>
        /// <param name="trackID"> this is the id of the track </param>
        /// <returns></returns>
        public bool AssignTram(Tram tram, int trackID)
        {
            
            foreach (Track track in Tracklist)
            {
                if (track.Id == trackID)
                {
                    int sectortrack = track.Sectors;
                    int usedsectors = 0;

                    foreach (Tram sectortram in track.TramList)
                    {
                        usedsectors += sectortram.Sectors;
                    }

                    if ((sectortrack - usedsectors - tram.Sectors) >= 0)
                    {
                        track.TramList.Add(tram);
                        tram.IsParked = true;
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }
    }
}
