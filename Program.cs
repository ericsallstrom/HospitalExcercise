namespace HospitalExcersise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Doctor doctor = new Doctor(name: "Lena Åkesson", role: "Doctor", salary: 68000);
            persons.Add(doctor);

            Doctor doctor2 = new Doctor(name: "Stefan Nordström", role: "Doctor", salary: 64000);
            persons.Add(doctor2);

            Nurse nurse = new Nurse(name: "Åke Svensson", role: "Nurse", shift: "Night");
            persons.Add(nurse);

            Nurse nurse2 = new Nurse(name: "Zabrina Thureson", role: "Nurse", shift: "Day");
            persons.Add(nurse2);

            Patient patient = new Patient(name: "Ingrid Leandersson", role: "Patient", symptom: "Leg hurts", diagnosis: "Broken bone");
            patient.CheckIn = new DateTime(2023, 10, 5);
            patient.CheckOut = new DateTime(2023, 12, 8);
            persons.Add(patient);

            Patient patient2 = new Patient(name: "Oscar Bodström", role: "Patient", symptom: "Fever", diagnosis: "Covid-19");
            patient2.CheckIn = new DateTime(2023, 10, 6);
            patient2.CheckOut = new DateTime(2023, 10, 16);
            persons.Add(patient2);

            foreach (Person person in persons)
            {
                person.PrintInfo();
                if (person is Doctor d)
                {
                    d.WritePrescription();
                }
                else if (person is Nurse n)
                {
                    n.TakeBloodTest();
                }
                else if (person is Patient p)
                {
                    p.GetPrescription();
                }
                Console.WriteLine();
            }
        }
    }
}