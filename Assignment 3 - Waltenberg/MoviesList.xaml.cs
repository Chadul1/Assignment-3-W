namespace Assignment_3___Waltenberg;

public partial class MoviesList : ContentPage
{
    public List<MediaItem> Items { get; set; }

    public MoviesList()
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
            new MediaItem("Movie Name","Genre","",""
                ),
            new MediaItem("The Lord of the Rings Trilogy",
                          "High Fantasy",
                          "https://preview.redd.it/stunning-poster-for-the-lord-of-the-rings-the-fellowship-of-v0-kbrpxpvr19tc1.jpeg?width=640&crop=smart&auto=webp&s=1fcb66d59223a0836a8c96e30f4551223d3f6744",
                          "https://en.wikipedia.org/wiki/The_Lord_of_the_Rings"
                ),
            new MediaItem("True Grit",
                          "Western",
                          "https://m.media-amazon.com/images/I/51J8X29IrCL._SX300_SY300_QL70_FMwebp_.jpg",
                          "https://en.wikipedia.org/wiki/True_Grit_(2010_film)"
                          
                ),
            new MediaItem("No Country for Old Men",
                          "Modern Western",
                          "https://m.media-amazon.com/images/I/51vMJ9L3ivL.__AC_SX300_SY300_QL70_FMwebp_.jpg",
                          "https://en.wikipedia.org/wiki/No_Country_for_Old_Men"
                ),
            new MediaItem("Pulp Fiction",
                          "Crime Neo-noir",
                          "https://m.media-amazon.com/images/I/71wPS3A1EYL._AC_SY741_.jpg",
                          "https://en.wikipedia.org/wiki/Pulp_Fiction"
                ),
            new MediaItem("EEATO",
                          "Surreal Martial Art comedy",
                          "https://i.ebayimg.com/images/g/BNEAAOSwQ9hjRE2D/s-l960.webp",
                          "https://en.wikipedia.org/wiki/Everything_Everywhere_All_at_Once"
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