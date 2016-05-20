using MonkeyNights.Core.Models;
using MvvmCross.Core.ViewModels;

namespace MonkeyNights.Core.ViewModels
{
	public class MainViewModel : MvxViewModel
	{
		public MainViewModel()
		{
			CreateCommands();
		}

		private void CreateCommands()
		{
			ShowVideosCommand = new MvxCommand(ShowVideosCommandExecute);
		}

		public Video LastVideo { get; set; }

		public IMvxCommand ShowVideosCommand { get; private set; }

		private void ShowVideosCommandExecute() => ShowViewModel<VideosViewModel>();
	}
}