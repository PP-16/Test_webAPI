using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSync.DAL.Entities
{
    public class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(2)]
        public int PositionCode { get; set; }

        
        [MaxLength(1)]
        [Required]
        public string PositionName { get; set; } = null!;
        [Required]

        public DateTime CreatedDate { get; set; }

        [MaxLength(1)]
        [Required]
        public string IsUsed { get; set; } = null!;

        [MaxLength(2)]
        [Required]
        public Division Division { get; set; } = null!;

    }
}