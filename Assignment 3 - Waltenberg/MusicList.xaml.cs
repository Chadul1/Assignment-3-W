namespace Assignment_3___Waltenberg;


public partial class MusicList : ContentPage
{
	public List<MediaItem> Items { get; set; }

	public MusicList()
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
            new MediaItem("Band Name","Genre","",""
                ),
            new MediaItem("1. Mushuggah",
						  "Mathematical Metal",
                          "https://m.media-amazon.com/images/I/91IiCnUMXSL._SL1500_.jpg",
						  "https://en.wikipedia.org/wiki/Meshuggah"
				), 
			new MediaItem("2. Wind Rose",
			              "Folk Metal",
                          "https://f4.bcbits.com/img/a0582306680_10.jpg",
                          "https://en.wikipedia.org/wiki/Wind_rose"
                ),
			new MediaItem("3. Slayer",
					      "Thrash Metal",
                          "https://m.media-amazon.com/images/I/51SIMH62ujL._SX300_SY300_QL70_FMwebp_.jpg",
                          "https://en.wikipedia.org/wiki/Slayer"
                ),
			new MediaItem("4. Journey",
						  "Rock",
                          "https://upload.wikimedia.org/wikipedia/en/f/f8/Jfrontiers.jpg",
                          "https://en.wikipedia.org/wiki/Journey_(band)"
                ),
			new MediaItem("5. Ritchie Valens",
				          "Classic Rock",
                          "https://upload.wikimedia.org/wikipedia/en/0/0c/Ritchie_Valens_1959.jpg",
                          "https://en.wikipedia.org/wiki/Ritchie_Valens"
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