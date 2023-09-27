using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TripSharePay_Repository.Data.Entites;

public class RepositoryContext  : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> opt) : base(opt) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(RepositoryContext).Assembly);

        //Configuração de Relacionamento entre entidades e valores de varchar dentro do DB;
        builder.Entity<users>(entity =>
        {
            entity.Property(e => e.user_name).HasMaxLength(100);
        });
    }

    public DbSet<users> users { get; set; }
}