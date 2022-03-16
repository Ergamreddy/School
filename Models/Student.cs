using School1.DTO;

namespace School1.Models;


public record Student
{

    public long StudentId { get; set; }
    public string Name { get; set; }

    public string Surname { get; set; }

    public long Mobile { get; set; }

    public string Address{ get; set; }

    public long ClassRoomId { get; set; }

    

    public studentDto asDto
    {
        get
        {
            return new studentDto
            {
                StudentId = StudentId,
                Name = Name,
                Surname = Surname,
                Mobile = Mobile,
                Address = Address,
                ClassRoomId = ClassRoomId,
            };
        }
    }
}


