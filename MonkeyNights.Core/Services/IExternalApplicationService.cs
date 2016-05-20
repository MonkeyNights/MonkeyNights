namespace MonkeyNights.Core.Services
{
	public interface IExternalApplicationService
	{
		void OpenFacebookUrl(string url);

		void OpenYoutubeVideo(string youtubeVideoId);
	}
}