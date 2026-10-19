namespace GlassV_2627.DTOs;

public class StudentEditDTO
{
    public int? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public int Age { get; set; }
}

public class StudentResponseDTO
{
    public int Id { get; set; }
    public string Names { get; set; }
    public int Age { get; set; }
}

public class StudentUpdateGradeDTO
{
    public int StudentId { get; set; }
    public int NewGrade { get; set; }
}