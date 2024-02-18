using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMS_Full_Stack.Models;

namespace EMS_FullStack1.Data
{
    public class EMS_FullStack1DbContext : DbContext
    {
        public EMS_FullStack1DbContext (DbContextOptions<EMS_FullStack1DbContext> options)
            : base(options)
        {
        }

        public DbSet<EMS_Full_Stack.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
