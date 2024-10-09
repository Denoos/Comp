namespace Computer
{
    class  OpenWindowMethods
    {
        private static OpenWindowMethods inst;
        public static OpenWindowMethods Instance { get { return inst ??= new(); } }

        public async Task<List<Singer>> OpenAdd()
        {
            Singer singer = new()
            {
                ID = DataBase.Instance.AutoIncrementSingers,
                Name = "Витя АК",
                IsBoy = true,
                Musics = [new Music { Title = "Витек" }, new Music { Title = "Аканек" }]
            };
            for (int i = 0; i < singer.Musics.Count; i++)
                singer.Musics[i].ID = DataBase.Instance.AutoIncrementMusic + i;

            DataBase.Instance.AddSinger(singer);

            return await DataBase.Instance.GetAllSingers();
        }
        public async Task<List<Singer>> OpenEdit(Singer singer)
        {
            singer.Name = "Морген что?";
            singer.IsBoy = true;
            DataBase.Instance.EditSinger(singer);
            return await DataBase.Instance.GetAllSingers();
        }
        public async Task<List<Singer>> OpenDel(Singer singer)
        {
            DataBase.Instance.DeleteSinger(singer);
            return await DataBase.Instance.GetAllSingers();
        }
        public async Task<List<Music>> OpenAddMusic()
        {
            Music music = new()
            {
                ID = DataBase.Instance.AutoIncrementSingers,
                Title = "Опиум для никого",
                Description = "Я мажу жопу вазелином",
            };
            DataBase.Instance.AddMusic(music);

            return await DataBase.Instance.GetAllMusics();
        }
        public async Task<List<Music>> OpenEditMusic(Music music)
        {
            music.Title = "Негры";
            music.Description = "Я съел деда";
            DataBase.Instance.EditMusic(music);
            return await DataBase.Instance.GetAllMusics();
        }
        public async Task<List<Music>> OpenDelMusic(Music music)
        {
            DataBase.Instance.DeleteMusic(music);
            return await DataBase.Instance.GetAllMusics();
        }
    }
}
