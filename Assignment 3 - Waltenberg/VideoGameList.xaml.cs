namespace Assignment_3___Waltenberg;

public partial class VideoGameList : ContentPage
{
    public List<MediaItem> Items { get; set; }

    public VideoGameList()
    {
        InitializeComponent();
        PopulateMusicList();
        MediaList.ItemsSource = Items;
    }

    /// <summary>
    /// Creates the list and adds it to the media list.
    /// </summary>
    private void PopulateMusicList()
    {
        Items = new()
        {
            new MediaItem("Game Name","Genre","",""
                ),
            new MediaItem("Disco Elysium",
                          "Surrealist RPG",
                          "https://www.jimzub.com/wp-content/uploads/2023/12/DiscoElysiumConceptArt1.jpg",
                          "https://en.wikipedia.org/wiki/Disco_Elysium"
                ),
            new MediaItem("Pathfinder: WOTR",
                          "Fantasy RPG",
                          "https://static1.srcdn.com/wordpress/wp-content/uploads/sharedimages/2024/04/pathfinderwrathofrighteous.jpg?q=50&fit=crop&w=480&dpr=1.5",
                          "https://en.wikipedia.org/wiki/Pathfinder:_Wrath_of_the_Righteous"
                ),
            new MediaItem("FrostPunk",
                          "Apocalapse City Builder",
                          "https://m.media-amazon.com/images/I/91un+zIMP+L._SY500_.jpg",
                          "https://en.wikipedia.org/wiki/Frostpunk"
                ),
            new MediaItem("Metro Trilogy",
                          "Apocalapse Survival",
                          "https://static.wikia.nocookie.net/metro2033/images/7/7e/Metro2033GameNeutralBoxArt.jpg/revision/latest?cb=20180709232946",
                          "https://en.wikipedia.org/wiki/Metro_(franchise)"
                ),
            new MediaItem("Hades",
                          "Fantasy Roguelite",
                          "https://m.media-amazon.com/images/I/71FjVhf-SlL.__AC_SX300_SY300_QL70_FMwebp_.jpg",
                          "https://en.wikipedia.org/wiki/Hades_(video_game)"
            )
        };
    }

    /// <summary>
    /// When the image is tapped, it sends to the wikipedia page of said item..
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Tapped_Tapped(object sender, TappedEventArgs e)
    {
        var img = sender as Image;
        var item = img?.BindingContext as MediaItem;
        Navigation.PushAsync(new WikiPage(item.Url));
    }
}