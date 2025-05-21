using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Utilisateur
    {
        [Key]
        public int UtilisateurId { get; set; }
        public string NomUtilisateur { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Email must respect mail format.")]
        public string Email { get; set; }
        public DateTime DateNaissance { get; set; }
        public virtual ICollection<Visionnage> Visionnages { get; set; }
    }
}
