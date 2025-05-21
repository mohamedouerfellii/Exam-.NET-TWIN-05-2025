using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Programme
    {
        [Key]
        public int ProgrammeId { get; set; }
        [StringLength(100)]
        [Required]
        public string NomProgramme { get; set; }
        public TimeSpan Duree { get; set; }
        public string Animateur { get; set; }
        public virtual ICollection<Visionnage> Visionnages { get; set; }
        public virtual Chaine Chaine { get; set; }
    }
}
