using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Computer;

public partial class CollectionViewPage : ContentPage
{
    private List<Music> musics;
    public List<Music> Musics
    {
        get => musics;
        set
        {
            musics = value;
            OnPropertyChanged(nameof(Musics));
        }
    } 

    private Music selMusic;
    public Music SelMusic
    {
        get => selMusic;
        set
        {
            selMusic = value;
            OnPropertyChanged(nameof(SelMusic));
        }
    }

    public CollectionViewPage()
    {
        InitializeComponent();
        BindingContext = this;
        Musics = [];
        SelMusic = new();

        GetData(DataBase.Instance);
    }

    private async void GetData(DataBase a)
    {
        List<Singer> Singers = new(await a.GetAllSingers());

        foreach (Singer singer in Singers)
            foreach(Music music in singer.Musics)
                Musics.Add(music);
    }

    private void BackClick(object sender, EventArgs e) => Navigation.PopModalAsync();
    private async void AddClick(object sender, EventArgs e) => Musics = await OpenWindowMethods.Instance.OpenAddMusic();
    private async void EditClick(object sender, EventArgs e) { if (SelMusic != null) Musics = await OpenWindowMethods.Instance.OpenEditMusic(SelMusic); }
    private async void DeleteClick(object sender, EventArgs e) { if (SelMusic != null) Musics = await OpenWindowMethods.Instance.OpenDelMusic(SelMusic); }
}