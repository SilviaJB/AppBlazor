using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysSalvadorAdventure.Pages.Models
{
    public class Usuario
    {
        public Usuario()
        {
            TouristPlaces = new HashSet<TouristPlace>();
        }

        [Key]
        public int IdUser { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string Telephone { get; set; } = null!;
        [StringLength(60)]
        [Unicode(false)]
        public string Login { get; set; } = null!;
        [StringLength(32)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        public int? IdRol { get; set; }

        [ForeignKey("IdRol")]
        [InverseProperty("Usuarios")]
        public virtual Rol? IdRolNavigation { get; set; }
        [InverseProperty("IdUserNavigation")]
        public virtual ICollection<TouristPlace> TouristPlaces { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Confirmar el password")]
        [StringLength(32, ErrorMessage = "Password debe estar entre 5 a 32 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password y confirmar password deben de ser iguales")]
        [Display(Name = "Confirmar password")]
        public string ConfirmPassword_aux { get; set; }
    }
}
