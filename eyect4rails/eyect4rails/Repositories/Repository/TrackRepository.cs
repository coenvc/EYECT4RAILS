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
                new Track(1, true, 5, TrackType.ParkTrack),
                new Track(2, true, 5, TrackType.ParkTrack),
                new Track(3, true, 5, TrackType.ParkTrack),
                new Track(4, true, 5, TrackType.ParkTrack),
                new Track(5, true, 5, TrackType.ParkTrack),
                new Track(6, true, 5, TrackType.ParkTrack),
                new Track(7, true, 5, TrackType.ParkTrack),
                new Track(8, true, 5, TrackType.ParkTrack),
                new Track(9, true, 5, TrackType.ParkTrack),
                new Track(10, true, 5, TrackType.ParkTrack),
                new Track(11, true, 5, TrackType.ParkTrack),
                new Track(12, true, 5, TrackType.ParkTrack)
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
                if (track.Number == id)
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
                if (selectedTrack.Number == id)
                {
                    selectedTrack.Number = track.Number;
                    selectedTrack.ConductorRequired = track.ConductorRequired;
                    selectedTrack.Sectors = track.Sectors;
                    selectedTrack.Tracktype = track.Tracktype;
                }
            }
        }

        public bool Delete(int id)
        {
            foreach (Track track in Tracklist)
            {
                if (track.Number == id)
                {
                    Tracklist.Remove(track);
                    return true;
                }
            }
            return false;
        }
    }
}
