namespace ToyProject.Model
{
    public class TesterRequestDto
    {
        public long? Id { get; set; }

        public string License_Number { get; set; }

        public string Name { get; set; }

        public string Office_Info { get; set; }

        public bool Enabled { get; set; }
    }

    public class TesterAddRequestDto
    {
        public string License_Number { get; set; }

        public string Name { get; set; }

        public string Office_Info { get; set; }
    }
}
