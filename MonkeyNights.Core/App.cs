using MonkeyNights.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace MonkeyNights.Core
{
	public class App : MvxApplication
	{
		public override void Initialize() => RegisterAppStart<MainViewModel>();
	}
}

