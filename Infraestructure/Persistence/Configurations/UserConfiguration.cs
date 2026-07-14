
using Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Persistence.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) {
            //throw new NotImplementedException();
            builder.ToTable("Users");

            builder.HasKey(u => u.User.id)

            builder.Property(u => u)

            builder.Property
        }
    }
}
