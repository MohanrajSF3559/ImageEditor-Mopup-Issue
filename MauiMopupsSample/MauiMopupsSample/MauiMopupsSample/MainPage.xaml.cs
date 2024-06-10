using Mopups.Interfaces;

namespace MauiMopupsSample;

public partial class MainPage : ContentPage
{
	IPopupNavigation popupNavigation;

	public MainPage(IPopupNavigation popupNavigation)
	{
		InitializeComponent();

		this.popupNavigation = popupNavigation;
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
        popupNavigation.PushAsync(new MyPopupPage());
	}
}

