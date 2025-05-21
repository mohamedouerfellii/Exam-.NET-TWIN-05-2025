using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Visionnage
    {
        public DateTime DateVisionnage { get; set; }
        public bool Favori { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual Programme Programme { get; set; }
        public int UtilisateurFk { get; set; }
        public int ProgrammeFk { get; set; }
    }
}
