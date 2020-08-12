using System;
using System.Collections.Generic;
using System.Text;
using beka.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace beka.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public ApplicationDbContext()
        {

        }
        public DbSet<Departament>Departaments { get; set; }
        public DbSet<Test>Tests { get; set; }
        public DbSet<Question>Questions { get; set; }
        public DbSet<Answer>Answers { get; set; }
    }
}
