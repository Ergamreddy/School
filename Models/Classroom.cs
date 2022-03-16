using School1.DTO;

namespace School1.Models1;


public record Classroom
{

    public long ClassroomId { get; set; }

    public string Section { get; set; }

    public string Capacity { get; set; }

    public string Facilities { get; set; }

    public classDto asDto
    {
        get
        {
            return new classDto
            {
                ClassroomId = ClassroomId,
                Section = Section,
                Capacity = Capacity,
                Facilities = Facilities,

            };
        }
    }



}