namespace ChatApp.Api.Models;

public class Message
{
    public int Id { get; set; }
    public string Input { get; set; } = string.Empty;
    public int UserId  { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public User User { get; set; } = null!;
}