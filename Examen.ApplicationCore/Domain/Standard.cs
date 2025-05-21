using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Standard : Utilisateur
    {
        [DefaultValue(true)]
        public bool PubliciteActivee { get; set; }
    }
}
