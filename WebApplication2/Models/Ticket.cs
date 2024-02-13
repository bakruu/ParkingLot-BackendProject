namespace WebApplication2.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
