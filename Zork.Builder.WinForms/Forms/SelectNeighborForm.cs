using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    public partial class SelectNeighborForm : Form
    {
        public static readonly Room NoNeighbor = new Room() { Name = "None" };

        public Directions Direction
        {
            get => (Directions)Enum.Parse(typeof(Directions), directionTextBox.Text, true);
            set => directionTextBox.Text = value.ToString();
        }

        public Room Room { get; set; }

        public Room Neighbor
        {
            get => (Room)roomsComboBox.SelectedItem;
            set => roomsComboBox.SelectedItem = value;
        }

        public SelectNeighborForm(List<Room> rooms, Directions direction, Room room)
        {
            InitializeComponent();

            rooms.Insert(0, NoNeighbor);
            roomsComboBox.DataSource = rooms;
            Direction = direction;
            Room = room;

            if (room.Neighbors.TryGetValue(Direction, out Room neighbor))
            {
                Neighbor = neighbor;
            }
        }
    }
}