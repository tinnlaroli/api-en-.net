using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.common.interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }
    }
}
