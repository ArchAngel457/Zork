using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    internal partial class WorldView : UserControl
    {
        public GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                mViewModel = value;
                foreach (var entry in DirectionNeighborViewMap)
                {
                    entry.Value.ViewModel = mViewModel;
                }
            }
        }

        public Room SelectedRoom
        {
            get => mSelectedRoom;
            set
            {
                if (mSelectedRoom != value)
                {
                    mSelectedRoom = value;
                    roomsListBox.SelectedItem = mSelectedRoom;
                    if (mSelectedRoom == null)
                    {
                        selectedRoomBindingSource.DataSource = typeof(Room);
                        deleteButton.Enabled = false;
                        foreach (var entry in DirectionNeighborViewMap)
                        {
                            entry.Value.Clear();
                        }
                    }
                    else
                    {
                        deleteButton.Enabled = true;
                        foreach (var entry in DirectionNeighborViewMap)
                        {
                            entry.Value.Room = mSelectedRoom;

                            if (mSelectedRoom.Neighbors.TryGetValue(entry.Key, out Room neighbor))
                            {
                                entry.Value.Neighbor = neighbor;
                            }
                        }
                    }
                }
            }
        }

        public Room StartingLocation
        {
            get => mStartingLocation;
            set
            {
                if (mStartingLocation != value)
                {
                    mStartingLocation = value;
                    startingLocationComboBox.SelectedItem = mStartingLocation;
                    if (mRefreshingData == false)
                    {
                        if (ViewModel.Game != null && ViewModel.Game.World != null)
                        {
                            ViewModel.Game.World.StartingLocation = mStartingLocation?.Name;
                        }
                    }
                }
            }
        }

        public void RefreshData()
        {
            mRefreshingData = true;
            var rooms = ViewModel.Game?.World?.Rooms?.OrderBy(room => room.Name).ToList();
            roomsListBox.DataSource = rooms != null ? new BindingList<Room>(rooms) : null;

            // Cannot use the same binding list as the roomsListBox (otherwise the selected item will sync between the two controls)
            startingLocationComboBox.DataSource = rooms != null ? new BindingList<Room>(rooms) : null;
            StartingLocation = ViewModel?.Game?.World.RoomsByName.GetValueOrDefault(ViewModel?.Game?.World?.StartingLocation);
            mRefreshingData = false;
        }

        public WorldView()
        {
            InitializeComponent();

            DirectionNeighborViewMap = new Dictionary<Directions, NeighborView>()
            {
                { Directions.North, northNeighborView },
                { Directions.South, southNeighborView},
                { Directions.East, eastNeighborView },
                { Directions.West, westNeighborView }
            };
        }

        private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedRoom = roomsListBox.SelectedItem as Room;
            selectedRoomBindingSource.DataSource = SelectedRoom as object ?? typeof(Room);
            foreach (var entry in DirectionNeighborViewMap)
            {
                entry.Value.Room = SelectedRoom;
            }
        }

        private void StartingLocationComboBox_SelectedIndexChanged(object sender, EventArgs e) => StartingLocation = startingLocationComboBox.SelectedItem as Room;

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    var room = new Room() { Name = addRoomForm.RoomName };
                    ViewModel.Game.World.Rooms.Add(room);
                    RefreshData();
                    SelectedRoom = room;
                    ViewModel.IsModified = true;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", MainForm.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Game.World.RemoveRoom(SelectedRoom);
                RefreshData();
                SelectedRoom = ViewModel.Game.World.Rooms?.FirstOrDefault();
                ViewModel.IsModified = true;
            }
        }

        private Room mSelectedRoom;
        private Room mStartingLocation;
        private GameViewModel mViewModel;
        private readonly Dictionary<Directions, NeighborView> DirectionNeighborViewMap;
        private bool mRefreshingData;
    }
}