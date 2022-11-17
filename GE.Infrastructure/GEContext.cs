
using GE.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.Infrastructure
{
    public class GEContext : DbContext
    {
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Membre> Membres { get; set; }
        public DbSet<Entraineur> Entraineurs { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Trophee> Trophees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                          Initial Catalog=GestionEquipeDB;
                                          Integrated Security=true;
                                          MultipleActiveResultSets=true " );
        }





        }
}
