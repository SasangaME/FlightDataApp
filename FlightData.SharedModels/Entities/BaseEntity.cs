using System.ComponentModel.DataAnnotationprs;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightData.SharedModels.Entities;

public class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}