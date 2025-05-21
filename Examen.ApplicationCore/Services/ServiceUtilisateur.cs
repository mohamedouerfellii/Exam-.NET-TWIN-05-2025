using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceUtilisateur : Service<Utilisateur>, IServiceUtilisateur
    {
        public ServiceUtilisateur(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public TimeSpan dureeTotVisionnee(Utilisateur u)
        {
            return u.Visionnages.Select(v => v.Programme.Duree).Aggregate(TimeSpan.Zero, (total, next) => total + next);
        }
    }
}
