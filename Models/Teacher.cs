using School1.DTO;

namespace School1.Models;



public record Teacher
{
    // internal object Surname;

    public long TeacherId { get; set; }
    public string Name { get; set; }

    public string Surname { get; set; }

    public long Mobile { get; set; }

    public long SubjectId { get; set; }
    public teacherDto asDto
    {
        get
        {
            return new teacherDto
            {
                TeacherId = TeacherId,
                Name = Name,
                Surname = Surname,
                Mobile = Mobile,
                SubjectId = SubjectId,
            };
        }
    }

}

