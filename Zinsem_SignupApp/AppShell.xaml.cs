namespace Zinsem_SignupApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register routes used by GoToAsync
        Routing.RegisterRoute("profile", typeof(ProfilePage));
        Routing.RegisterRoute("signup", typeof(SignupPage));
    }
}