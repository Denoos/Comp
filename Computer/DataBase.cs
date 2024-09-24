using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    internal class DataBase : INotifyPropertyChanged
    {
        public List<Singer> singers;

        public DataBase instance;

        public DataBase GetConnection()
        { 
            return instance ??= new DataBase();
        }

        public List<Singer> Singers
        {
            get => singers;
            set
            {
                singers = value;
                Signal();
            }
        }
        public List<Music> musics;

        public List<Music> Musics
        {
            get => musics;
            set
            {
                musics = value;
                Signal();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        void Signal([CallerMemberName] string prop = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public void AddMusic(Music music)
        {
            if (Musics.Count == 0)
            {
                music.ID = 0;
                Musics.Add(music);
            }
            else
            {
                music.ID = Musics[^1].ID + 1;
                Musics.Add(music);
            }

        }
        public void AddSinger(Singer singer)
        {
            if (Musics.Count == 0)
                singer.ID = 0;
            else
                singer.ID = Musics[^1].ID + 1;

            Singers.Add(singer);
        }

        public void DeleteSinger(Singer singer)
        {
            foreach (var m in singer.Musics)
                DeleteMusic(m);

            Singers.Remove(singer);
        }

        public void DeleteMusic(Music music)
        {
            Musics?.Remove(music);
        }
    }
}
