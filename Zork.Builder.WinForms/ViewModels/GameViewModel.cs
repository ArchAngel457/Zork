using System.IO;
using System.ComponentModel;

namespace Zork.Builder.WinForms
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Game Game
        {
            get => mGame;
            set
            {
                if (mGame != value)
                {
                    if (mGame != null)
                    {
                        mGame.PropertyChanged -= Game_PropertyChanged;
                        mGame.World.PropertyChanged -= Game_PropertyChanged;
                        if (Game.World?.Rooms != null)
                        {
                            foreach (Room room in Game.World.Rooms)
                            {
                                room.PropertyChanged -= Game_PropertyChanged;
                            }
                        }
                    }

                    mGame = value;
                    if (mGame != null)
                    {
                        mGame.PropertyChanged += Game_PropertyChanged;
                        mGame.World.PropertyChanged += Game_PropertyChanged;
                        if (Game.World?.Rooms != null)
                        {
                            foreach (Room room in Game.World.Rooms)
                            {
                                room.PropertyChanged += Game_PropertyChanged;
                            }
                        }
                    }
                }
            }
        }

        public string FullPath { get; set; }

        public string Filename => FullPath != null ? Path.GetFileName(FullPath) : "Untitled";

        public bool IsModified { get; set; }

        private void Game_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            IsModified = true;
            PropertyChanged?.Invoke(sender, e);
        }

        private Game mGame;
    }
}