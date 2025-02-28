﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.SpecialtyModule
{
    public class SpecialitySingleQuery : IRequest<Speciality>
    {
        public int Id { get; set; }
        public class SpecialitySingleQueryHandler : IRequestHandler<SpecialitySingleQuery, Speciality>
        {
            private readonly PortfolioDbContext db;

            public SpecialitySingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<Speciality> Handle(SpecialitySingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Specialities.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate==null, cancellationToken);
                return data;
            }
        }
    }
}
