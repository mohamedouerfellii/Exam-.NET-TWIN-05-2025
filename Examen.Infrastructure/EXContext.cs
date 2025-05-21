using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class EXContext : DbContext
    {
        public DbSet<Chaine> Chaines { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Visionnage> Visionnages { get; set; }
        public DbSet<Premuim> Premuims { get; set; }
        public DbSet<Standard> Standards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                            Initial Catalog=ExamenTWIN;
                                            Integrated Security=true;
                                            MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visionnage>()
                .HasOne(v => v.Utilisateur)
                .WithMany(u => u.Visionnages)
                .HasForeignKey(v => v.UtilisateurFk);

            modelBuilder.Entity<Visionnage>()
                .HasOne(v => v.Programme)
                .WithMany(p => p.Visionnages)
                .HasForeignKey(v => v.ProgrammeFk);

            modelBuilder.Entity<Visionnage>()
                .HasKey(v => new { v.UtilisateurFk, v.ProgrammeFk, v.DateVisionnage });

            modelBuilder.Entity<Utilisateur>()
                        .HasDiscriminator<int>("TypeeUtilisateur")
                        .HasValue<Utilisateur>(0)
                        .HasValue<Premuim>(1)
                        .HasValue<Standard>(2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
