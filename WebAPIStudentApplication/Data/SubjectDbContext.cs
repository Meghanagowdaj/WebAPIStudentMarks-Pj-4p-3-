using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIStudentApplication.Models;

namespace WebAPIStudentApplication.Data
{
    public class SubjectDbContext : DbContext
    {
        public SubjectDbContext (DbContextOptions<SubjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIStudentApplication.Models.Subject> Subject { get; set; } = default!;
    }
}
