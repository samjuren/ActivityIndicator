namespace ActivityIndicator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            WebViewVisibility(true);
        }

        private void webView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            WebViewVisibility(false);
        }

        private void WebViewVisibility(bool isWebViewVisible)
        {
            webView.IsVisible = isWebViewVisible;
            actIndicator.IsVisible = !isWebViewVisible;
            actIndicator.IsRunning = !isWebViewVisible;
        }
    }
}
