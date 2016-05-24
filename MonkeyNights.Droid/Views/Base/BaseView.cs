using Android.OS;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace MonkeyNights.Droid.Views
{
	public abstract class BaseView : MvxAppCompatActivity
	{
		protected abstract int LayoutId { get; }

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(LayoutId);

			var toolbar = FindViewById<Toolbar>(Resource.Id.MainViewToolbar);
			SetSupportActionBar(toolbar);
		}
	}
}