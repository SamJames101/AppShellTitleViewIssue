namespace AppShellTitleViewIssue;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("Page 1", typeof(Page1));
        Routing.RegisterRoute("Page 2", typeof(Page2));
        Routing.RegisterRoute("Page 3", typeof(Page3));
    }
}

