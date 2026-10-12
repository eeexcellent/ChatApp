namespace ChatApp.Api.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;

    public List<Message> Messages { get; set; } = [];
}