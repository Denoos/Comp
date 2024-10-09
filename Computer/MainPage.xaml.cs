namespace Computer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            DataBase.Instance.GetFullData();
        }

        private void ListViewClicked(object sender, EventArgs e) => Navigation.PushModalAsync(new ListViewPage());
        private void CollectionViewClicked(object sender, EventArgs e) => Navigation.PushModalAsync(new CollectionViewPage());
        private void CarouseViewClicked(object sender, EventArgs e) => Navigation.PushModalAsync(new CarouseViewPage());
    }
}
