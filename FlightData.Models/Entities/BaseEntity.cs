using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFCore.ModelBuilderExtensions.Attributes;

namespace FlightData.Models.Entities;

public class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [SqlDefaultValue("getutcdate()")]
    public DateTime CreatedAt { get; set; }
    [SqlDefaultValue("getutcdate")]
    public DateTime UpdatedAt { get; set; }
}