using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorApp1.Components.Data


{
    public class ScheduleDBContext : DbContext
    {
        public ScheduleDBContext(DbContextOptions<ScheduleDBContext> options) : base(options)
        {
            //
        }

        public DbSet<ScheduleEntry> ScheduleEntries { get; set; }

    }
}

