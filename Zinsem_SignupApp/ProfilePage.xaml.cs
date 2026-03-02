using System.Net;

namespace Zinsem_SignupApp;

[QueryProperty(nameof(Username), "Username")]
[QueryProperty(nameof(Email), "Email")]
public partial class ProfilePage : ContentPage
{
    private string _username = "";
    public string Username
    {
        get => _username;
        set
        {
            _username = WebUtility.UrlDecode(value ?? "");
            UsernameLabel.Text = $"Username: {_username}";
        }
    }

    private string _email = "";
    public string Email
    {
        get => _email;
        set
        {
            _email = WebUtility.UrlDecode(value ?? "");
            EmailLabel.Text = $"Email: {_email}";
        }
    }

    public ProfilePage()
    {
        InitializeComponent();
    }

    private async void OnSignOutClicked(object sender, EventArgs e)
    {
        // Go back to signup (URI-based navigation)
        await Shell.Current.GoToAsync("//signup");
    }
}