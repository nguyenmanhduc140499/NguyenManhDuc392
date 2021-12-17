using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenManhDuc392.Models;

    public class NguyenManhDucDBContext : DbContext
    {
        public NguyenManhDucDBContext (DbContextOptions<NguyenManhDucDBContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenManhDuc392.Models.UniversityNMD392> UniversityNMD392 { get; set; }

        public DbSet<NguyenManhDuc392.Models.NMD392> NMD392 { get; set; }
    }
