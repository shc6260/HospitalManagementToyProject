namespace ToyProject.Model
{
    public class PatientRequestDto
    {
        public long? Id { get; set; }

        public string ChartNumber { get; set; }

        public string Name { get; set; }

        public string Social_Security_Number { get; set; }

        public string Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Memo { get; set; }

        public string Qualification_Info { get; set; }
    }
}
