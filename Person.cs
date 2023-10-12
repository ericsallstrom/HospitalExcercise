﻿namespace HospitalExcersise
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Person(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public abstract void PrintInfo();
    }
}