﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Irimia_Ofelia_Lab2.Models;

namespace Irimia_Ofelia_Lab2.Data
{
    public class Irimia_Ofelia_Lab2Context : DbContext
    {
        public Irimia_Ofelia_Lab2Context (DbContextOptions<Irimia_Ofelia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Irimia_Ofelia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Irimia_Ofelia_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Irimia_Ofelia_Lab2.Models.Author>? Authors { get; set; } = default!;
    }
}
