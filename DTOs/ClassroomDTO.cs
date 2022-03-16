using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using School1.DTO;

namespace School1.DTO;

public record classDto
{
    // internal long ClassroomId;

    [JsonPropertyName("classroom_id")]
    public long ClassroomId { get; set; }

    [JsonPropertyName("section")]
    public string Section { get; set; }



    [JsonPropertyName("capacity")]
    public string Capacity { get; set; }


    [JsonPropertyName("Facilities")]
    public string Facilities { get; set; }



}