namespace TransparencyTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void MainPage_OnLoaded(object sender, EventArgs e)
    {
        #if WINDOWS
        
        var webView = (BlazorWebView.Handler.PlatformView as Microsoft.UI.Xaml.Controls.WebView2);

        webView.DefaultBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);

        #endif
    }
}
