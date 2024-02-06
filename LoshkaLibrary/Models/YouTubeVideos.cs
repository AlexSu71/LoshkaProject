namespace LoshkaLibrary.Models
{
    public class YouTubeVideos
    {
        public int VideoId { get; set; }
        public string? VideoURL { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? PostedDate { get; set; }
    }
}
