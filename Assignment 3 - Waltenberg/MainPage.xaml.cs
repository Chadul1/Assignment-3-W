namespace Assignment_3___Waltenberg
{
    public partial class MainPage : ContentPage
    {
        public List<MediaItem> Items { get; set; }

        public MainPage()
        {
            InitializeComponent();
            PopulateList();
            carouselView.ItemsSource = Items;
        }

        private void FunItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //null conditional operator to access the SelectedItem property and the ToString to compare it with the name.
            if (sender is ListView lv)
            {
                //Starts the Music list content page
                if (lv.SelectedItem?.ToString() == "Bands")
                    Navigation.PushAsync(new MusicList());
                //Starts the VideoGame list content page
                if (lv.SelectedItem?.ToString() == "VideoGames")
                    Navigation.PushAsync(new VideoGameList());
                //Starts the Book list content page
                if (lv.SelectedItem?.ToString() == "Books")
                    Navigation.PushAsync(new BooksList());
                //Starts the Movie list content page
                if (lv.SelectedItem?.ToString() == "Movies")
                    Navigation.PushAsync(new MoviesList());
            }
        }

        /// <summary>
        /// Creates the list and adds it to the media list.
        /// </summary>
        private void PopulateList()
        {
            Items = new()
            {
                new MediaItem("Meshuggah",
                              "Movie",
                              "https://www.rollingstone.com/wp-content/uploads/2022/03/Meshuggah-Band-no-AI-filter-Hint-of-Blue-less-sat.jpg?w=1581&h=1054&crop=1", 
                              ""),
                new MediaItem("Disco Elysium",
                              "Game",
                              "https://www.jimzub.com/wp-content/uploads/2023/12/DiscoElysiumConceptArt1.jpg",
                              ""),
                new MediaItem("Hitchhikers Guide",
                              "Book",
                              "https://www.pluggedin.com/wp-content/uploads/2019/12/the-hickerhikers-guide-to-the-galaxy-1024x607.jpg",
                              ""),
                new MediaItem("Lord of the Rings",
                              "Movie",
                              "https://mondoshop.com/cdn/shop/products/richard-lord-of-the-rings.jpg?v=1667690917&width=2000",
                              "")
            };
        }
    }
}
