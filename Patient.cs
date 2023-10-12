namespace HospitalExcersise
{
    internal class Patient : Person
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Diagnosis { get; set; }
        public string Symptom { get; set; }

        public Patient(string name, string role, string symptom, string diagnosis) : base(name, role)
        {
            Symptom = symptom;
            Diagnosis = diagnosis;
        }

        public void Symtoms()
        {
            Console.WriteLine($"My symptoms are {Symptom}");
        }
        public void GetPrescription()
        {
            Console.WriteLine($"Prescription for {Diagnosis}");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Patient name: {Name}" +
                $"\nCheck In: {CheckIn.ToLongDateString()}" +
                $"\nSymptom: {Symptom}" +
                $"\nDiagnosis: {Diagnosis}" +
                $"\nCheck Out {CheckOut.ToLongDateString()}");
        }
    }
}