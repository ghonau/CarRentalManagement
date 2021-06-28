using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole 
            { 
                Id = "321a9501-1fa3-4c68-86e4-776d7b9278b7",
                Name = "User",
                NormalizedName = "USER"
            },
            new IdentityRole
            {
                Id = "321a9501-1fa3-4c68-86e4-776d7b9278b8",
                Name ="Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
            );


        }
    }
}
