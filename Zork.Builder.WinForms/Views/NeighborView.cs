using System;
using System.Linq;
using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    internal partial class NeighborView : UserControl
    {
        public GameViewModel ViewModel { get; set; }

        public Room Room
        {
            get => mRoom;
            set
            {
                mRoom = value;
                if (mRoom != null)
                {
                    Neighbor = mRoom.Neighbors.TryGetValue(Direction, out Room neighbor) ? neighbor : null;
                }
                else
                {
                    Neighbor = null;
                }
            }
        }

        public Directions Direction
        {
            get => mDirection;
            set
            {
                mDirection = value;
                selectNeighborButton.Text = value.ToString();
            }
        }

        public Room Neighbor
        {
            get => mNeighbor;
            set
            {
                mNeighbor = value;
                neighborLabel.Text = value != null ? value.Name : "<None>";
            }
        }

        public NeighborView()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            Room = null;
            Neighbor = null;
        }

        private void SelectNeighborButton_Click(object sender, EventArgs e)
        {
            using (SelectNeighborForm selectNeighborForm = new SelectNeighborForm(ViewModel.Game.World.Rooms.ToList(), Direction, Room))
            {
                if (selectNeighborForm.ShowDialog() == DialogResult.OK)
                {
                    Room originalNeighbor = Neighbor;
                    if (ReferenceEquals(selectNeighborForm.Neighbor, SelectNeighborForm.NoNeighbor))
                    {
                        Room.Neighbors.Remove(Direction);
                        Neighbor = null;
                    }
                    else
                    {
                        Room.Neighbors[Direction] = selectNeighborForm.Neighbor;
                        Neighbor = selectNeighborForm.Neighbor;
                    }

                    if (Neighbor != originalNeighbor)
                    {
                        ViewModel.IsModified = true;
                    }
                }
            }
        }

        private Room mRoom;
        private Room mNeighbor;
        private Directions mDirection;
    }
}