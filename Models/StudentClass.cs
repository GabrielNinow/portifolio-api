namespace PortifolioAPI.Models;

public class StudentClass
{
    public StudentClass() { }

    public StudentClass(int studentId, int classId)
    {
        this.StudentId = studentId;
        this.ClassId = classId;
    }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int ClassId { get; set; }
    public Class Class { get; set; }
}