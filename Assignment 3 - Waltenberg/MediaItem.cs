namespace Assignment_3___Waltenberg
{
    /// <summary>
    /// The Mediaitem object will be used to link to other pages. 
    /// </summary>
    public class MediaItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; }
        public string Url { get; set; }

        public MediaItem(string name, string description, string imageURL, string url)
        {
            Name = name;
            Description = description;
            ImageURL = imageURL;
            Url = url;
        }

        public override string ToString() => $"this is the object {Name}, {Description}";
    }
}
