using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceVisionnage : Service<Visionnage>, IServiceVisionnage
    {
        public ServiceVisionnage(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<Programme> programmeVisionneeParUtilisateur(Utilisateur u, DateTime debut, DateTime fin)
        {
            return GetMany(v => v.Utilisateur == u && v.DateVisionnage >= debut && v.DateVisionnage <= fin)
                .Select(v => v.Programme)
                .Distinct()
                .ToList();
        }
    }
}
