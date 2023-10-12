namespace HospitalExcersise
{
    internal class Doctor : Person
    {
        public decimal Salary { get; set; }

        public Doctor(string name, string role, decimal salary) : base(name, role)
        {
            Salary = salary;
        }

        public void WritePrescription()
        {
            Console.WriteLine($"{Name} writes a prescription.");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nRole: {Role}" +
                $"\nSalary: {Salary:C}");
        }
    }
}