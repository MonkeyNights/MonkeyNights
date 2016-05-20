using MonkeyNights.Core.Models;
using MonkeyNights.Core.Services;
using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;

namespace MonkeyNights.Core.ViewModels
{
	public class VideosViewModel : BaseViewModel
	{
		private readonly IExternalApplicationService _externalApplicationService;

		public VideosViewModel(IExternalApplicationService externalApplicationService)
		{
			_externalApplicationService = externalApplicationService;
		}

		public ObservableCollection<Video> Videos { get; } = new ObservableCollection<Video>();

		public IMvxCommand OpenVideoCommand { get; }

		private void OpenVideoCommandExecute(Video video)
			=>  _externalApplicationService.OpenYoutubeVideo(video.Id);
	}
}