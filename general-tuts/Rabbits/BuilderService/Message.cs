namespace BuilderService;

public class Message
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public int Sequence { get; set; }
}