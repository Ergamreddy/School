using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using School1.DTO;

namespace School1.DTO;

public record subjectDto
{

    

    [JsonPropertyName("subject_id")]
    public long SubjectId { get; set; }


    [JsonPropertyName("subject_name")]
    public string SubjectName { get; set; }


    [JsonPropertyName("no_of_subjects")]
    public int NoOfSubjects { get; set; }

    [JsonPropertyName("teachers")]
    public List<teacherDto> Teachers {get; set;}


}

