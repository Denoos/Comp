using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Computer;
public partial class ListViewPage : ContentPage, INotifyPropertyChanged
{
    private List<Singer> singers;
    public List<Singer> Singers
    {
        get => singers;
        set
        { 
            singers = value;
            OnPropertyChanged(nameof(Singers));
        }
    }
    public ListViewPage()
    {
        InitializeComponent();
        BindingContext = this;

        DataBase a = new();
        GetData(a);
    }

    private async void GetData(DataBase a)
    {
        Singers = await a.GetAllSingers();
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public event PropertyChangedEventHandler PropertyChanged;
}