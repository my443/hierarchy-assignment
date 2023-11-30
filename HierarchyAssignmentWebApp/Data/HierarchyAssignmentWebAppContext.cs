using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HierarchyAssignmentWebApp.Models;

namespace HierarchyAssignmentWebApp.Data
{
    public class HierarchyAssignmentWebAppContext : DbContext
    {
        public HierarchyAssignmentWebAppContext (DbContextOptions<HierarchyAssignmentWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<HierarchyAssignmentWebApp.Models.Entity> Entity { get; set; } = default!;
    }
}
