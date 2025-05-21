using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Premuim : Utilisateur
    {
        public DateTime DateExpiration { get; set; }
        public int PointsFidelite { get; set; }
    }
}
