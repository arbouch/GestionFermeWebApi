using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionFermeWebApi.Models
{
    public class Ferme
    {
        [Key]
        public int FermeId { get; set; }    
        public string nomFerme { get; set; }
        public string nomProp { get; set; }
        public string adresse { get; set; }
        public string numTelProp { get; set; }
        public string gouveroratFerme { get; set; }
        public string delegation { get; set; }
        public DateTime dateAdhesion { get; set; }
        [MaxLength(50)] 
        public int cinPopr { get; set; }
    }
}
