
namespace Computer
{
    internal class DataBase
    {
        private static DataBase inst;
        public static DataBase Instance { get { return inst ??= new(); } }

        public int AutoIncrementSingers = 1;
        public int AutoIncrementMusic = 1;

        public DataBase()
        {
            GetFullData();
        }

        public async void GetFullData()
        {
            await Task.Delay(1000);
            singers = await GetFullSingerDataBase();
            musics = await GetFullMusicDataBase();
        }

        private List<Singer> singers = [];
        private List<Music> musics = [];

        public async Task<List<Singer>> GetFullSingerDataBase()
        { 
            await Task.Delay(100);
            AutoIncrementSingers += 3;
            AutoIncrementMusic += 9;

            return
            [
                new() { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new() { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new() { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }
                
                
               /*  Too many singers
                , new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() }, new Singer { ID = 0, IsBoy = true, Name = "Максим Галкин", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 1, IsBoy = false, Name = "Алла Пугачева", Musics = await GetFullMusicDataBase() },
                new Singer { ID = 2, IsBoy = false, Name = "Агата Кристи", Musics = await GetFullMusicDataBase() },
                */
                 
            ];
        }
        public async Task<List<Music>> GetFullMusicDataBase()
        {
            await Task.Delay(100);

            return
            [
                new() { ID = 0, Title = "Ляляля", Description = "Первая песенка певца"},
                new() { ID = 1, Title = "Лелеле", Description = "Вторая песенка певца"},
                new() { ID = 2, Title = "Лололо", Description = "Третья песенка певца"}
            ];
        }
        public async Task AddMusic(Music music)
        {
            await Task.Delay(500);
            if(singers.Count == 0)
                GetFullSingerDataBase();

            if (musics.Count == 0)
            {
                music.ID = 0;
                musics.Add(music);
                AutoIncrementMusic++;
            }
            else
            {
                music.ID = musics[^1].ID++;
                musics.Add(music);
                AutoIncrementMusic++;

            }

        }
        public async Task AddSinger(Singer singer)
        {
            await Task.Delay(1000);

            if (singers.Count == 0)
                singer.ID = 0;
            else
                singer.ID = singers[^1].ID++;

            AutoIncrementSingers++;


            singers.Add(singer);
        }

        public async Task DeleteSinger(Singer singer)
        {
            await Task.Delay(100);

            foreach (var m in singer.Musics)
                DeleteMusic(m);

            singers.Remove(singer);
        }

        public async Task DeleteMusic(Music music)
        {
            await Task.Delay(100);

            musics.Remove(music);
        }

        public async Task<Singer> SearchSingerById(int id)
        {
            await Task.Delay(1000);

            foreach (var s in singers)
                if (s.ID == id)
                { 
                    var singer = s;
                    return singer;
                }

            return new Singer();
        }

        public async Task<Music> SearchMusicById(int id)
        {
            await Task.Delay(1000);

            foreach (var m in musics)
                if (m.ID == id)
                {
                    var music = m;
                    return music;
                }

            return new Music();
        }

        public async Task<List<Singer>> GetAllSingers()
        {
            await Task.Delay(1000);
            return new List<Singer>( singers);
        }

        public async Task<List<Music>> GetAllMusics()
        {
            await Task.Delay(1000);
            return new List<Music>(musics);
        }

        public async Task EditSinger(Singer singer)
        {
            await Task.Delay(1000);

            Singer s = await SearchSingerById(singer.ID);

            foreach (var m in singer.Musics)
            { EditMusic(m); }

            singers[s.ID] = singer;
        }
        
        public async Task EditMusic(Music music)
        {
            await Task.Delay(1000);

            Music m = await SearchMusicById(music.ID);

            musics[m.ID] = music;
        }
    }
}