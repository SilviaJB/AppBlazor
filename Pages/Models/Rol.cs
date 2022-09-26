using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysSalvadorAdventure.Pages.Models
{
    public class Rol
    {
        public Rol()
        {
            Usuarios = new HashSet<Usuario>();
        }

        [Key]
        public int IdRol { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [InverseProperty("IdRolNavigation")]
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
