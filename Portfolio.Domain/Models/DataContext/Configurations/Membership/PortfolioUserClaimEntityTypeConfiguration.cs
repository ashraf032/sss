﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.Entities.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.DataContext.Configurations.Membership
{
    public class PortfolioUserClaimEntityTypeConfiguration : IEntityTypeConfiguration<PortfolioUserClaim>
    {
        public void Configure(EntityTypeBuilder<PortfolioUserClaim> builder)
        {
            builder.ToTable("UserClaims", "Membership");
        }
    }
}
