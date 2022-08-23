using MasterContentPageDemo.Views;

namespace MasterContentPageDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute($"{nameof(TestPage1)}", typeof(TestPage1));
	}
}
