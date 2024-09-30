namespace Computer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListViewClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewPage());
        }

        private void CollectionViewClicked(object sender, EventArgs e)
        {

        }

        private void CarouseViewClicked(object sender, EventArgs e)
        {

        }
    }

}
