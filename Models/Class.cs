namespace PortifolioAPI.Models;

public class Class
{
    public Class() { }
    public Class(int id, string name, int teacherId)
    {
        this.Id = id;
        this.Name = name;
        this.TeacherId = teacherId;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public IEnumerable<StudentClass> StudentClasses { get; set; }
}