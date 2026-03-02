using System.Net;

namespace Zinsem_SignupApp;

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        ErrorLabel.IsVisible = false;

        string username = UsernameEntry.Text?.Trim() ?? "";
        string email = EmailEntry.Text?.Trim() ?? "";
        string password = PasswordEntry.Text ?? "";
        string confirm = ConfirmPasswordEntry.Text ?? "";

        if (string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(confirm))
        {
            ShowError("All fields are required.");
            return;
        }

        if (password != confirm)
        {
            ShowError("Password and Confirm Password must match.");
            return;
        }

        // Encode values for query string safety (spaces, @, etc.)
        string u = WebUtility.UrlEncode(username);
        string eMail = WebUtility.UrlEncode(email);

        await Shell.Current.GoToAsync($"profile?Username={u}&Email={eMail}");
    }

    private void ShowError(string message)
    {
        ErrorLabel.Text = message;
        ErrorLabel.IsVisible = true;
    }
}