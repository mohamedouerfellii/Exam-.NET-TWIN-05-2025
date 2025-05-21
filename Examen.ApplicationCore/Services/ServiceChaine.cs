using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceChaine : Service<Chaine>, IServiceChaine
    {
        public ServiceChaine(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public Chaine? chaineAvecPlusGrandNombreProgVisionnee()
        {
            return GetMany()
                    .OrderByDescending(c => c.Programmes.Sum(p => p.Visionnages.Count()))
                    .FirstOrDefault();
        }
    }
}
