using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Utilisateur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UtilisateurId { get; set; }

        [Required]
        public string Nom { get; set; }
        public String Prénom { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Bateau> Bateaux { get; set; }
    }
}
