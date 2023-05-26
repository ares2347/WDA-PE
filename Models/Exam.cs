namespace WDA_PE.Models;

public class Subject
{
    public Guid ExamId { get; set; }
    public DateTime StartTime { get; set; }
    public DateOnly Date { get; set; }
    public int Duration { get; set; }
    public ClassRoom ClassRoom { get; set; }
}