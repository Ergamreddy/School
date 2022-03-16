using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using School1.DTO;
using School1.Models;
using School1.Controllers;
using School1.Repositories;

namespace School1.DTO;

public record teacherDto
{

    [JsonPropertyName("teacher_id")]
    public long TeacherId { get; set; }


    [JsonPropertyName("name")]
    public string Name { get; set; }


    [JsonPropertyName("surname")]
    public string Surname { get; set; }


    [JsonPropertyName("mobile")]

    public long Mobile { get; set; }


    [JsonPropertyName("subject_id")]

    public long SubjectId { get; set; }

    // [JsonPropertyName("teachers")]
    // public List<teacherDto> Teachers {get; set;}

    [JsonPropertyName("student")]
    public List<studentDto> Student {get; set;}


    public record UsersCreateDto
    {


        [JsonPropertyName("name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [JsonPropertyName("surname")]
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [JsonPropertyName("mobile")]
        public long Mobile { get; set; }

        [JsonPropertyName("subject_id")]
        [Required]

        public long SubjectId { get; set; }


    }

    public record UsersUpdateDto
    {
    
        [JsonPropertyName("surname")]
        [MaxLength(50)]
        public string Surname { get; set; }



        [JsonPropertyName("mobile")]
        public long Mobile { get; set; }

    }
}
