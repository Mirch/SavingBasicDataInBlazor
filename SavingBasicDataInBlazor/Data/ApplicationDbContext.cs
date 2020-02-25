using Microsoft.EntityFrameworkCore;
using SavingBasicDataInBlazor.Models;
using System;

namespace SavingBasicDataInBlazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Reminder> Reminders { get; set; }
    }
}
