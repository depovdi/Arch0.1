using Rf.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rf.Repositories.Contexts
{
    public class FormulierDbContext : DbContext
    {
        public FormulierDbContext() : base("RapporteringsFormulieren")
        {
            Database.SetInitializer<FormulierDbContext>(new CreateDatabaseIfNotExists<FormulierDbContext>());
        }

        public DbSet<Formulier> Formulieren { get; set; }
        public DbSet<Afdeling> Afdelingen { get; set; }
        public DbSet<Voertuig> Voertuigen { get; set; }
        public DbSet<DetailCode> DetailCodes { get; set; }
        public DbSet<Bestemming> Bestemmingen { get; set; }
        public DbSet<Ca> Cas { get; set; }
        public DbSet<HoofdCode> HoofdCodes { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Locatie> Locaties { get; set; }
        public DbSet<Oorsprong> Oorsprongen { get; set; }
        public DbSet<Oorzaak> Oorzaken { get; set; }
        public DbSet<Persoon> Personen { get; set; }
        public DbSet<ProcesType> ProcesTypes { get; set; }
        public DbSet<QualityProcedure> QualityProcedures { get; set; }
        public DbSet<Rp> Rps { get; set; }
        public DbSet<Soort> Soorten { get; set; }
        public DbSet<SoortKlacht> KlachtSoorten { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Betrokkene> Betrokkenen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Afdeling>().ToTable("Afdelingen");
            modelBuilder.Entity<Voertuig>().ToTable("Voertuigen");
            modelBuilder.Entity<Bestemming>().ToTable("Bestemmingen");
            modelBuilder.Entity<Ca>().ToTable("Cas");
            modelBuilder.Entity<HoofdCode>().ToTable("HoofdCodes");
            modelBuilder.Entity<Klant>().ToTable("Klanten");
            modelBuilder.Entity<Locatie>().ToTable("Locaties");
            modelBuilder.Entity<Oorsprong>().ToTable("Oorsprongen");
            modelBuilder.Entity<Oorzaak>().ToTable("Oorzaken");
            modelBuilder.Entity<Persoon>().ToTable("Personen");
            modelBuilder.Entity<ProcesType>().ToTable("ProcesTypes");
            modelBuilder.Entity<QualityProcedure>().ToTable("QualityProcedures");
            modelBuilder.Entity<Rp>().ToTable("Rps");
            modelBuilder.Entity<Soort>().ToTable("Soorten");
            modelBuilder.Entity<SoortKlacht>().ToTable("KlachtSoorten");
            modelBuilder.Entity<Unit>().ToTable("Units");
            modelBuilder.Entity<Betrokkene>().ToTable("Betrokkenen");
            modelBuilder.Entity<Formulier>().ToTable("Formulieren");

            modelBuilder.Entity<Formulier>()
                .HasKey(f => f.Id);

            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.Voertuig);
            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.Soortklacht);
            modelBuilder.Entity<Formulier>()
                .HasRequired(f => f.Opsteller);
            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.Ontvanger);
            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.DetailCode);
            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.Rp);
            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.QualityProcedure);
            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.Procestype);
            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.Unit);
            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.HoofdCode);
            modelBuilder.Entity<Formulier>()
                .HasOptional(f => f.Afdeling);

            modelBuilder.Entity<Formulier>()
                .HasMany(f => f.Betrokkenen)
                .WithMany(b => b.Formulieren)
                .Map(fb => 
                {
                    fb.MapLeftKey("FormulierRefId");
                    fb.MapRightKey("BetrokkeneRefId");
                    fb.ToTable("FormulierBetrokkenen");
                });

            modelBuilder.Entity<Formulier>()
                .HasMany(f => f.Klanten)
                .WithMany(k => k.Formulieren)
                .Map(fb =>
                {
                    fb.MapLeftKey("FormulierRefId");
                    fb.MapRightKey("KlantenRefId");
                    fb.ToTable("FormulierKlanten");
                });

            modelBuilder.Entity<Formulier>()
                .HasMany(f => f.Oorsprongen)
                .WithMany(o => o.Formulieren)
                .Map(fb =>
                {
                    fb.MapLeftKey("FormulierRefId");
                    fb.MapRightKey("OorsprongenRefId");
                    fb.ToTable("FormulierOorsprongen");
                });

            modelBuilder.Entity<Formulier>()
                .HasMany(f => f.Bestemmingen)
                .WithMany(b => b.Formulieren)
                .Map(fb =>
                {
                    fb.MapLeftKey("FormulierRefId");
                    fb.MapRightKey("BestemmingenRefId");
                    fb.ToTable("FormulierBestemmingen");
                });

            modelBuilder.Entity<Formulier>()
                .HasMany(f => f.Locaties)
                .WithMany(l => l.Formulieren)
                .Map(fb =>
                {
                    fb.MapLeftKey("FormulierRefId");
                    fb.MapRightKey("LocatiesRefId");
                    fb.ToTable("FormulierLocaties");
                });

            modelBuilder.Entity<Formulier>()
                .HasMany(f => f.Soorten)
                .WithMany(s => s.Formulieren)
                .Map(fb =>
                {
                    fb.MapLeftKey("FormulierRefId");
                    fb.MapRightKey("SoortenRefId");
                    fb.ToTable("FormulierSoorten");
                });

            modelBuilder.Entity<Formulier>()
                .HasMany(f => f.Oorzaken)
                .WithMany(o => o.Formulieren)
                .Map(fb =>
                {
                    fb.MapLeftKey("FormulierRefId");
                    fb.MapRightKey("OorzakenRefId");
                    fb.ToTable("FormulierOorzaken");
                });

            modelBuilder.Entity<Formulier>()
                .HasMany(f => f.Cas)
                .WithMany(c => c.Formulieren)
                .Map(fb =>
                {
                    fb.MapLeftKey("FormulierRefId");
                    fb.MapRightKey("CasRefId");
                    fb.ToTable("FormulierCas");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
