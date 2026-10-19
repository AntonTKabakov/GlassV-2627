namespace GlassV_2627.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Username { get; internal set; }
    public int Grade { get; internal set; }
    public string Password { get; internal set; }
}