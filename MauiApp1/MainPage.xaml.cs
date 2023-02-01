using System.Diagnostics;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    Button loginButton;
    VerticalStackLayout layout;

    public MainPage()
    {
        this.BackgroundColor = Color.FromArgb("#72ACF1");

        layout = new VerticalStackLayout
        {
            Margin = new Thickness(15, 15, 15, 15),
            Padding = new Thickness(30, 60, 30, 30),
            Children =
            {
                new Label { Text = "Please log in", FontSize = 30, TextColor = Color.FromRgb(0,0,0) },
                new Label { Text = "Username", TextColor = Color.FromRgb(0, 0, 0) },
                new Entry (),
                new Label { Text = "Password", TextColor = Color.FromRgb(0, 0, 0) },
                new Entry { IsPassword = true }
            }
        };

        loginButton = new Button { Text = "Login", BackgroundColor = Color.FromRgb(0, 0, 0) };
        layout.Children.Add(loginButton);

        Content = layout;

        loginButton.Clicked += (sender, e) =>
        {
            Debug.WriteLine("Clicked !");
        };

        InitializeComponent();
    }

    void LoginButton_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine("Clicked !");

        var navigationParameter = new Dictionary<string, object>
        {

        };
    }

    void OnSelectionChange(object sender, SelectionChangedEventArgs e)
    {
        Debug.WriteLine("Selected !");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

    }

}

