﻿using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceProgramme : Service<Programme>, IServiceProgramme
    {
        public ServiceProgramme(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
