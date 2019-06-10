using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Models
{
    
    public class Bateau
    {
        [Key]
        public int BateauId { get; set; }
        [Required]
        public string Nom { get; set; }
        public float Longueur { get; set; }
        public float Largeur { get; set; }
        public float Poids { get; set; }
        public int AnnéeFabrication { get; set; }

        public Guid UtilisateurId { get; set; }
        [ForeignKey("UtilisateurId")]
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ICollection<Position_Bateau> Position_Bateaux { get; set; }

    }
}
