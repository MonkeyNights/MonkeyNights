namespace MonkeyNights.Core.Models
{
	public class Video
	{
		public string Id { get; set; }

		public string Name { get; set; }

		public string Thumbnail { get; set; }

		public string Url => $"http://www.youtube.com/watch?v={Id}";
	}
}