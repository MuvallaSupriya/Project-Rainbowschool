using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Subjectmarks.Models;

namespace Subjectmarks.Data
{
    public class SubjectmarksDbContext : DbContext
    {
        public SubjectmarksDbContext (DbContextOptions<SubjectmarksDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subjectmarks.Models.Student> Student { get; set; } = default!;
    }
}
