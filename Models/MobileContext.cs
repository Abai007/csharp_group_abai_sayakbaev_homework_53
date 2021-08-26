using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_51.Models
{

    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public MobileContext(DbContextOptions<MobileContext> options): base(options)
        {

        }
    }
}
