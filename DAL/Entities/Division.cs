using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSync.DAL.Entities;
public class Division
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	[MaxLength(2)]
	public string DivisionCode {get; set;} = null!;
	
	[MaxLength(80)]
	[Required]
	public string DivisionName {get; set;} = null!;

	[Required]
	public DateTime CreatedDate {get; set;} 

	[MaxLength(1)]
	[Required]
	public string IsUsed {get; set;}= null!;

}