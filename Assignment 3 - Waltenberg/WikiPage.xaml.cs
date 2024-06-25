namespace Assignment_3___Waltenberg;

public partial class WikiPage : ContentPage
{
    public string WebSource { get; set; }

    public WikiPage()
    {
        InitializeComponent();
    }

    public WikiPage(string url)
    {
        WebSource = url;
        InitializeComponent();
        webView.Source = WebSource;

    }
}