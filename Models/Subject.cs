using School1.DTO;

namespace School1.Models1;


public record Subject
{

    public long SubjectId { get; set; }

    public string SubjectName { get; set; }

     public int NoOfSubjects { get; set; }


    public subjectDto asDto
    {
        get
        {
            return new subjectDto
            {
                SubjectId = SubjectId,
                SubjectName = SubjectName,
                NoOfSubjects = NoOfSubjects,

            };
        }
    }
}