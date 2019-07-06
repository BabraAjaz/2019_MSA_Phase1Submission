using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace schoolSIMS.Model
{
    public partial class babraschoolSIMSContext : DbContext
    {
        public babraschoolSIMSContext()
        {
        }

        public babraschoolSIMSContext(DbContextOptions<babraschoolSIMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:babraschoolsims.database.windows.net,1433;Initial Catalog=schoolSIMS;Persist Security Info=False;User ID=baja156;Password=Babra1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.EmergencyContactName).IsUnicode(false);

                entity.Property(e => e.EmergencyContactNumber).IsUnicode(false);

                entity.Property(e => e.Ethnicity).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Major).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.ProgrammeStudying).IsUnicode(false);
            });
        }
    }
}
