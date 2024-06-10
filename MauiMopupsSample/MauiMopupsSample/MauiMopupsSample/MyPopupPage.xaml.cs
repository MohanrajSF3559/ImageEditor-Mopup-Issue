using Mopups.Services;
using Syncfusion.Maui.ImageEditor;

namespace MauiMopupsSample;

public partial class MyPopupPage
{
	public MyPopupPage()
	{
		InitializeComponent();
		ImageEditorToolbar headerToolBar = this.imageEditor.Toolbars[0];
		ImageEditorToolbarGroupItem imageEditorToolbarGroupItem = (ImageEditorToolbarGroupItem)headerToolBar.ToolbarItems[1];
		ImageEditorToolbarItem imageEditorToolbarItem = imageEditorToolbarGroupItem.Items.FirstOrDefault(i=> i.Name == "SaveEdit");
		imageEditorToolbarItem.IsVisible = false;
	}

	private void CloseButton_Clicked(object sender, EventArgs e)
	{
		MopupService.Instance.PopAsync();

	}


	void Button_Clicked_1(System.Object sender, System.EventArgs e)
	{
		this.imageEditor.Crop(Syncfusion.Maui.ImageEditor.ImageCropType.Original);
	}
}