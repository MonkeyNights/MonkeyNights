using Android.App;
using Android.Content.PM;
using Android.Views;

namespace MonkeyNights.Droid.Views
{
	// ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
	[Activity(Theme = "@style/MonkeyTheme", ScreenOrientation = ScreenOrientation.Portrait, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize, WindowSoftInputMode = SoftInput.StateHidden | SoftInput.AdjustPan)]
	public class MainView : BaseView
	{
		protected override int LayoutId => Resource.Layout.MainView;
	}
}