namespace HospitalExcersise
{
    internal class Nurse : Person
    {
        public string Shift { get; set; }

        public Nurse(string name, string role, string shift) : base(name, role)
        {
            Shift = shift;
        }
        public void TakeBloodTest()
        {
            Console.WriteLine($"{Name} will now take your blood test.");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nRole: {Role}" +
                $"\nShift: {Shift}");
        }
    }
}