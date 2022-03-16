using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
// using School1.DOT;

namespace School1.DTO;

public record studentDto
{
       [JsonPropertyName("student_id")]
       public long StudentId{get;set;}


        [JsonPropertyName("name")]
        public string Name{get;set;}


        [JsonPropertyName("surname")]
        public string Surname{get;set;}


        [JsonPropertyName("mobile")]

        public long Mobile{get;set;}

         [JsonPropertyName("address")]

        public string Address{get;set;}

        [JsonPropertyName ("classroom_id")]

        public long ClassRoomId{get;set;}

        [JsonPropertyName("teached_by")]

        public List<teacherDto> Teacher{get;set;}

        [JsonPropertyName("given_subjects")]

        public List<subjectDto> Subject{get;set;}

}

public record UserCreateDto
{


        [JsonPropertyName("name")]
        [Required]
        [MaxLength(50)]
        public string Name{get;set;}

        [JsonPropertyName("surname")]
         [Required]
         [MaxLength(50)]
        public string Surname{get;set;}

        [JsonPropertyName("mobile")]
        public long Mobile{get;set;}


        [JsonPropertyName("address")]
         [Required]
         [MaxLength(255)]

        public string Address{get;set;}

        [JsonPropertyName("classroom_id")]
        [Required]

        public long ClassRoomId{get;set;}
}

public record UserUpdateDto
{
    internal long Mobile;

    [JsonPropertyName("surname")]
         [MaxLength(50)]
        public string Surname{get;set;}

        

        [JsonPropertyName("address")]
        [MaxLength(255)]
        public string Address{get;set;}

}