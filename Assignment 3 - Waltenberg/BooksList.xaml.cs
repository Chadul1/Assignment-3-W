namespace Assignment_3___Waltenberg;

public partial class BooksList : ContentPage
{
    public List<MediaItem> Items { get; set; }

    public BooksList()
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
            new MediaItem("Book Name","Genre","",""
                ),
            new MediaItem("Hitchkiers Guide to the Galaxy",
                          "Absurdist Sci-fi",
                          "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                          "https://en.wikipedia.org/wiki/The_Hitchhiker%27s_Guide_to_the_Galaxy"
                ),
            new MediaItem("The Hobbit",
                          "Fantasy",
                          "https://upload.wikimedia.org/wikipedia/en/4/4a/TheHobbit_FirstEdition.jpg",
                          "https://en.wikipedia.org/wiki/The_Hobbit"
                ),
            new MediaItem("The Color of Magic",
                          "Absurdist Fantasy",
                          "https://upload.wikimedia.org/wikipedia/en/4/4d/The_Colour_of_Magic_%28cover_art%29.jpg",
                          "https://en.wikipedia.org/wiki/The_Colour_of_Magic"
                ),
            new MediaItem("The Alchemist",
                          "Historical Fiction",
                          "https://upload.wikimedia.org/wikipedia/commons/c/c4/TheAlchemist.jpg",
                          "https://en.wikipedia.org/wiki/The_Alchemist_(novel)"
                ),
            new MediaItem("TL:TW:TW",
                          "High Fantasy",
                          "https://upload.wikimedia.org/wikipedia/en/8/86/TheLionWitchWardrobe%281stEd%29.jpg",
                          "https://en.wikipedia.org/wiki/The_Lion,_the_Witch_and_the_Wardrobe"
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