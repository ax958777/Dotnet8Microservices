
using Microsoft.EntityFrameworkCore;
using PatientService.Model;


namespace PatientService.Data
{
    
    public class HospitalDbContext:DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<MedicalRecord> MedicalRecords { get; set; }
    }
}