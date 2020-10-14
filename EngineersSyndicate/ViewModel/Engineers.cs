using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersSyndicate.ViewModel
{
    public class Engineers
    {
        [Column("Ssn")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int Ssn { get; set; }

        [Column("FullName")]
        [StringLength(50)]
        [Required]
        public String FullName { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public String Email { get; set; }

        public int Gender { get; set; }
        [Phone]
        public String Phone { get; set; }
        public string address { get; set; }

        [ForeignKey("Ssn")]
        public int? superId { get; set; }

    }
}
