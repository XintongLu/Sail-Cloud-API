using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    public class Position_Bateau
    {
        [Key]
        public int Position_BateauId { get; set; }

        [JsonProperty(PropertyName = "Et")]
        public float Et { get; set; }
        [JsonProperty(PropertyName = "Ap")]
        public float Ap { get; set; }
        [JsonProperty(PropertyName = "PLt")]
        public float PLt { get; set; }
        [JsonProperty(PropertyName = "PLg")]
        public float PLg { get; set; }
        [JsonProperty(PropertyName = "PH")]
        public float PH { get; set; }
        [JsonProperty(PropertyName = "PHm")]
        public float PHm { get; set; }
        [JsonProperty(PropertyName = "PS")]
        public float PS { get; set; }
        [JsonProperty(PropertyName = "PSr")]
        public float PSr { get; set; }
        [JsonProperty(PropertyName = "PC")]
        public float PC { get; set; }
        [JsonProperty(PropertyName = "WAs")]
        public float WAs { get; set; }
        [JsonProperty(PropertyName = "WAa")]
        public float WAa { get; set; }
        [JsonProperty(PropertyName = "WTa")]
        public float WTa { get; set; }
        [JsonProperty(PropertyName = "WTd")]
        public float WTd { get; set; }
        [JsonProperty(PropertyName = "WTD")]
        public float WTD2 { get; set; }
        [JsonProperty(PropertyName = "WTs")]
        public float WTs { get; set; }
        [JsonProperty(PropertyName = "BS")]
        public float BS { get; set; }
        [JsonProperty(PropertyName = "$v")]
        public float v { get; set; }
        [JsonProperty(PropertyName = "$s")]
        public float s { get; set; }


        [JsonProperty(PropertyName = "$b")]
        public int BateauId { get; set; } // id bateau
        [ForeignKey("BateauId")]
        public virtual Bateau bateau { get; set; }
        [JsonProperty(PropertyName = "$f")]
        public Guid UtilisateurId { get; set; } // id utilisateur
        [ForeignKey("UtilisateurId")]
        public virtual Utilisateur Utilisateur { get; set; }


        [JsonProperty(PropertyName = "$e")]
        public float e { get; set; }
        [JsonProperty(PropertyName = "$t")]
        public DateTime t { get; set; }

        
    }
}
