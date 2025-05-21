using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public enum Thematique
    {
        Sport,
        Enfant,
        Famille
    }

    public class Chaine
    {
        [Key]
        public int ChaineId { get; set; }
        public string NomChaine { get; set; }
        public string NomProgramme { get; set; }
        public Thematique Thematique { get; set; }
        public virtual ICollection<Programme> Programmes { get; set; }
    }
}
