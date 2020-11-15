using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Context;
using System;

namespace SwitchAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario() { Nome = "Usuario1", SobreNome = "SobreUsuario" };
            var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost;userid=developer;password=1234567;database=SwitchDB", m => m.MigrationsAssembly("Switch.Infra.Data"));
            
            using (var dbcontext = new SwitchContext(optionsBuilder.Options))
            {
                dbcontext.Usuarios.Add(usuario);
            }
        }
    }
}
