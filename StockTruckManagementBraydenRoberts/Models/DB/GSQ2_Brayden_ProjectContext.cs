using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StockTruckManagementBraydenRoberts.Models.DB
{
    public partial class GSQ2_Brayden_ProjectContext : DbContext
    {
        public GSQ2_Brayden_ProjectContext()
        {
        }

        public GSQ2_Brayden_ProjectContext(DbContextOptions<GSQ2_Brayden_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IndividualTruck> IndividualTruck { get; set; }
        public virtual DbSet<TruckData> TruckData { get; set; }
        public virtual DbSet<TruckCustomer> TruckCustomer { get; set; }
        public virtual DbSet<TruckEmployee> TruckEmployee { get; set; }
        public virtual DbSet<TruckFeature> TruckFeature { get; set; }
        public virtual DbSet<TruckFeatureAssociation> TruckFeatureAssociation { get; set; }
        public virtual DbSet<TruckModel> TruckModel { get; set; }
        public virtual DbSet<TruckPerson> TruckPerson { get; set; }
        public virtual DbSet<TruckRental> TruckRental { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=citadel.manukautech.info,6302;Initial Catalog=GSQ2_Brayden_Project;Persist Security Info=True;User ID=GSQ2_Brayden;Password=fBit$77402;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<IndividualTruck>(entity =>
            {
                entity.HasKey(e => e.TruckId);

                entity.Property(e => e.TruckId).HasColumnName("TruckID");

                entity.Property(e => e.AdvanceDepositRequired).HasColumnType("money");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRentalPrice).HasColumnType("money");

                entity.Property(e => e.DateImported).HasColumnType("date");

                entity.Property(e => e.FuelType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationExpiryDate).HasColumnType("date");

                entity.Property(e => e.RegistrationNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Transmission)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TruckModelId).HasColumnName("TruckModelID");

                entity.Property(e => e.WofexpiryDate)
                    .HasColumnName("WOFExpiryDate")
                    .HasColumnType("date");

                entity.HasOne(d => d.TruckModel)
                    .WithMany(p => p.IndividualTruck)
                    .HasForeignKey(d => d.TruckModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IndividualTruck_TruckModel");
            });

            modelBuilder.Entity<TruckCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LicenseExpiryDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.TruckCustomer)
                    .HasForeignKey<TruckCustomer>(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TruckCustomer_TruckPerson");
            });





            modelBuilder.Entity<TruckEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OfficeAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtensionNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.TruckEmployee)
                    .HasForeignKey<TruckEmployee>(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TruckEmployee_TruckPerson");
            });

            modelBuilder.Entity<TruckFeature>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckFeatureAssociation>(entity =>
            {
                entity.HasKey(e => new { e.TruckId, e.FeatureId });

                entity.ToTable("Truck_Feature_Association");

                entity.Property(e => e.TruckId).HasColumnName("TruckID");

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.TruckFeatureAssociation)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Truck_Feature_Association_TruckFeature");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.TruckFeatureAssociation)
                    .HasForeignKey(d => d.TruckId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Truck_Feature_Association_IndividualTruck");
            });

            modelBuilder.Entity<TruckModel>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckData>(entity =>
            {
                entity.HasKey(e => e.ModelID);
                entity.Property(e => e.Model).HasColumnName("Model");
                entity.Property(e => e.Model).HasColumnName("Manufacturer");
                entity.Property(e => e.Model).HasColumnName("Colour");
                entity.Property(e => e.Model).HasColumnName("RegistrationNumber");
                entity.Property(e => e.Model).HasColumnName("DailyRentalPrice");


            });

                modelBuilder.Entity<TruckPerson>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckRental>(entity =>
            {
                entity.HasKey(e => e.RentalId);

                entity.Property(e => e.RentalId).HasColumnName("RentalID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.RentDate).HasColumnType("date");

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.ReturnDueDate).HasColumnType("date");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TruckId).HasColumnName("TruckID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TruckRental)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TruckRental_TruckCustomer");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.TruckRental)
                    .HasForeignKey(d => d.TruckId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TruckRental_IndividualTruck");
            });
        }
    }
}
