using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }


        public SwitchContext(DbContextOptions options) : base(options)
        {

        }
    }
}
