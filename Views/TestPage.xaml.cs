using MasterContentPageDemo.CustomControls;
using MasterContentPageDemo.ViewModels;

namespace MasterContentPageDemo.Views;

public partial class TestPage : MasterContentPage
{
	public TestPage(TestPageViewModel viewMOdel)
	{
		InitializeComponent();
		this.BindingContext = viewMOdel;
	}
}