using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgoratechAssessment.Models
{
    [Table("UserDetails")]
    public class Users
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [StringLength(50)]

        public string Surname { get; set; }
        [DisplayName("Cell Number")]
        [DataType(DataType.PhoneNumber)]
        public int? CellNumber { get; set; }
        [DisplayName("SA ID Number")]
        public int? IdNumber { get; set; }
        [DisplayName("House Number")]
        public int? HouseNumber { get; set; }

        [DisplayName("Complex Name")]
        public string ComplexName { get; set; }

        public string Address { get; set; }
        [DisplayName("Postal Code")]
        public int? PostalCode { get; set; }
    }
}
