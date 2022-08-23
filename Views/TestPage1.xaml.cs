using MasterContentPageDemo.CustomControls;
using MasterContentPageDemo.ViewModels;

namespace MasterContentPageDemo.Views;

public partial class TestPage1 : MasterContentPage
{
	public TestPage1(TestPage1ViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}