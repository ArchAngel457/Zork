using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public HashSet<Room> Rooms { get; set; } = new HashSet<Room>();

        public string StartingLocation { get; set; }

        [JsonIgnore]
        public ReadOnlyDictionary<string, Room> RoomsByName => new ReadOnlyDictionary<string, Room>(mRoomsByName);

        public World() => mRoomsByName = new Dictionary<string, Room>();

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            if (Rooms != null)
            {
                mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

                foreach (Room room in Rooms)
                {
                    room.UpdateNeighbors(this);
                }
            }
        }

        public void RemoveRoom(Room roomToRemove)
        {
            if (Rooms.Remove(roomToRemove))
            {
                foreach (Room room in Rooms)
                {
                    var neighbor = room.Neighbors.FirstOrDefault(n => n.Value == roomToRemove);
                    if (neighbor.Value != null)
                    {
                        room.Neighbors.Remove(neighbor.Key);
                    }
                }
            }
        }

        private Dictionary<string, Room> mRoomsByName;
    }
}