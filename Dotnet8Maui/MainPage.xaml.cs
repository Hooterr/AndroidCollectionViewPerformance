using System.Diagnostics;

namespace Dotnet8Maui
{
    public partial class MainPage : ContentPage
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();
        public MainPage()
        {
            InitializeComponent();
            Collection.ItemsSource = Enumerable.Range(0, 10_000);
            _stopwatch.Start();
        }

        private long _previousMs;
        private void Collection_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            var delta = _stopwatch.ElapsedMilliseconds - _previousMs;

            ScrollText.Text = (e.VerticalDelta / delta).ToString("N5");

            _previousMs = _stopwatch.ElapsedMilliseconds;

        }
    }

}
