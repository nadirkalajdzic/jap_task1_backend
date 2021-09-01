namespace jap_task1_backend.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int VideoId { get; set; }
        public int UserId { get; set; }
    }
}
