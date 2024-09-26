namespace PatientService.Model
{
    public class Prescription
    {
        public Guid Id { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Patient patient { get; set; }
    }
}
