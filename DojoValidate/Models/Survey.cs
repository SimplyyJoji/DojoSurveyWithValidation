using System.ComponentModel.DataAnnotations;
namespace DojoSurvModel.Models
{
  public class Survey
{
    [Required]
    [MinLength(4)]
    public string Name { get; set; }
    [Required]
    [MinLength(4)]
    public string Location { get; set; }
    [Required]
    
    public string Language { get; set; }
    [Required]
    [MinLength(4)]
    public string Comments { get; set; }

    // your Survey fields go here
} 
}