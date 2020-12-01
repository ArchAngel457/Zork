using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zork
{
    [JsonConverter(typeof(RoomConverter))]
    public class Room : IEquatable<Room>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        private Dictionary<Directions, string> NeighborNames { get; set; }

        public Dictionary<Directions, Room> Neighbors { get; set; }

        public Room()
        {
            Description = string.Empty;
            NeighborNames = new Dictionary<Directions, string>();
            Neighbors = new Dictionary<Directions, Room>();
        }

        public Room(string name, string description, Dictionary<Directions, string> neighborNames)
        {
            Name = name;
            Description = description;
            NeighborNames = neighborNames;
        }

        public static bool operator ==(Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs))
            {
                return true;
            }

            if (lhs is null || rhs is null)
            {
                return false;
            }

            return lhs.Name == rhs.Name;
        }

        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);        

        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world) => Neighbors = (from entry in NeighborNames
                                                                 let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                                                                 where room != null
                                                                 select (Direction: entry.Key, Room: room))
                                                                 .ToDictionary(pair => pair.Direction, pair => pair.Room);
    }

    public class RoomConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Room));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            dynamic jsonObject = JObject.Load(reader);

            string name = jsonObject["Name"];
            string description = jsonObject["Description"];
            Dictionary<Directions, string> neighborNames = jsonObject["Neighbors"].ToObject<Dictionary<Directions, string>>();

            return new Room(name, description, neighborNames);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Room room = (Room)value;
            JToken neighborNames = JToken.FromObject(room.Neighbors.ToDictionary(pair => pair.Key, pair => pair.Value.Name), serializer);

            JObject roomObject = new JObject
            {
                { nameof(Room.Name), room.Name },
                { nameof(Room.Description), room.Description },
                { nameof(Room.Neighbors), neighborNames }
            };

            roomObject.WriteTo(writer);
        }
    }
}