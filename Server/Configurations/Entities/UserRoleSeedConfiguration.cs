using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "321a9501-1fa3-4c68-86e4-776d7b9278b8",
                    UserId = "c7b94f54-b0c7-481a-9673-c053df841567"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "321a9501-1fa3-4c68-86e4-776d7b9278b7",
                    UserId = "c7b94f54-b0c7-481a-9673-c053df841568"
                }
                ); 
        }
    }
}
