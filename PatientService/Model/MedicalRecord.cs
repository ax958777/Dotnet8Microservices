namespace PatientService.Model
{
    public class MedicalRecord
    {
        public Guid Id { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }

        public Patient patient { get; set; }
    }
}
