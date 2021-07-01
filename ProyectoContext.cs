using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Proyecto_Vacuna.model;

#nullable disable

namespace Proyecto_Vacuna1
{
    public partial class ProyectoContext : DbContext
    {
        public ProyectoContext()
        {
        }

        public ProyectoContext(DbContextOptions<ProyectoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<DateVaccine> DateVaccines { get; set; }
        public virtual DbSet<DayVaccine> DayVaccines { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Dosi> Dosis { get; set; }

        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Index_cabin> Index_Cabins { set; get; }
        public virtual DbSet<InstitutionObjective> InstitutionObjectives { set; get; }

        public virtual DbSet<Pacient> Pacients { set; get; }
        public virtual DbSet<SideEffect> SideEffects { set; get; }
        public virtual DbSet<TipoEmployee> TipoEmployees { set; get; }
        public virtual DbSet<TypeVaccine> TypeVaccines { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;database=vacuna3;user=root;password=palodecoco2321");
            }
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TipoEmployee>()
                .HasData(
                new TipoEmployee

                {
                    Id = 1,
                    type = "Enfermero"
                },
                 new TipoEmployee

                 {
                     Id = 2,
                     type = "Doctor"
                 },
                  new TipoEmployee

                  {
                      Id = 3,
                      type = "Pasante"
                  },
                   new TipoEmployee

                   {
                       Id = 4,
                       type = "Policia"
                   },
                    new TipoEmployee

                    {
                        Id = 5,
                        type = "Soldado"
                    }
                    );

            modelBuilder.Entity<Disease>()
            .HasData(
                new Disease
                {
                    id = 1,
                    disease = "Hipertension arterial"
                },
                new Disease
                {
                    id = 2,
                    disease = "Diabetes"
                },
                new Disease
                {
                    id = 3,
                    disease = "Sobrepeso"
                },
                new Disease
                {
                    id = 4,
                    disease = "Dislipidemia"
                },
                new Disease
                {
                    id = 5,
                    disease = "Enfermedad Renal Cronica"
                },
                new Disease
                {
                    id = 6,
                    disease = "Ninguna"
                }
                );
            modelBuilder.Entity<Dosi>()
            .HasData(
                new Dosi
                {
                    id = 1,
                    dosis = "Primera dosis"
                },
                new Dosi
                {
                    id = 2,
                    dosis = "Segunda dosis"
                }
                );

            modelBuilder.Entity<Index_cabin>()
        .HasData(
                new Index_cabin
                {
                    id = 1,
                    index = "Primera cabina"

                },
                new Index_cabin
                {
                    id = 2,
                    index = "Segunda cabina"

                },
                new Index_cabin
                {
                    id = 3,
                    index = "Tercera cabina"

                },

                    new Index_cabin
                    {
                        id = 4,
                        index = "Cuarta cabina"

                    },
                    new Index_cabin
                    {
                        id = 5,
                        index = "Quinta cabina"

                    });



            modelBuilder.Entity<InstitutionObjective>()
  .HasData(
          new InstitutionObjective
          {
              id = 1,
              Institution = "Adultos mayores de 60 años"
          },
           new InstitutionObjective
           {
               id = 2,
               Institution = "Personal del sistema integrado de Salud"
           },
            new InstitutionObjective
            {
                id = 3,
                Institution = "Encargados de la seguridad nacional"
            },
             new InstitutionObjective
             {
                 id = 4,
                 Institution = "Personas mayores de 18 años con enfermadades no transmisibles o alguna discapacidad"
             },
              new InstitutionObjective
              {
                  id = 5,
                  Institution = "Personal del gobierno central"
              }
              );

            modelBuilder.Entity<SideEffect>()
.HasData(
                new SideEffect
                {
                    id = 1,
                    side = "Dolor y/o irritacion en el area de la inyeccion"
                },
                new SideEffect
                {
                    id = 2,
                    side = "Enrojecimiento en el area de la inyeccion"
                },
                new SideEffect
                {
                    id = 3,
                    side = "Fatiga"
                },
                new SideEffect
                {
                    id = 4,
                    side = "Dolor de cabeza"
                },
                new SideEffect
                {
                    id = 5,
                    side = "Fatiga"
                },
                new SideEffect
                {
                    id = 6,
                    side = "Mialgia"
                },
                new SideEffect
                {
                    id = 7,
                    side = "Otro"
                },
                new SideEffect
                {
                    id = 8,
                    side = "Ninguno"
                }
                );

            modelBuilder.Entity<TypeVaccine>()
        .HasData(
                new TypeVaccine
                {
                    id = 1,
                    type_Vaccine = "AstraZeneca"
                },
                new TypeVaccine
                {
                    id = 2,
                    type_Vaccine = "Sinovac"
                },
                new TypeVaccine
                {
                    id = 3,
                    type_Vaccine = "Phyzen"
                }
                );






            OnModelCreatingPartial(modelBuilder);


        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
