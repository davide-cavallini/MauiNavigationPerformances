using System.Collections.ObjectModel;

namespace TransientNavigationSample;

public partial class SecondPage : ContentPage
{
    public ObservableCollection<ShapeModel> Shapes { get; set; }

    public SecondPage()
    {
        InitializeComponent();

        Shapes = new ObservableCollection<ShapeModel>();
        ShapesCollectionView.ItemsSource = Shapes;
        InitializeAsync();
    }

    public Task InitializeAsync()
    {
        // the creation of the shapes is done in the main thread
        return MainThread.InvokeOnMainThreadAsync(RenderShapes);
    }

    private void RenderShapes()
    {
        var random = new Random();
        Shapes.Clear();

        // creates 35 shapes with 5 labels and 1 button
        // this simulates a runtime ui creation
        for (int i = 0; i < 35; i++)
        {
            var stackLayout = new StackLayout();
            for (int j = 0; j < 5; j++)
            {
                DateTime time = DateTime.Now;
                stackLayout.Children.Add(new Label { Text = "test" });
            }
            stackLayout.Children.Add(new Button { Text = "test" });

            Shapes.Add(new ShapeModel
            {
                Color = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256)),
                Layout = stackLayout
            });
        }
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///mainpage");
    }
}

public class ShapeModel
{
    public required Color Color { get; set; }

    public required StackLayout Layout { get; set; }
}
