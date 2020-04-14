using _04._Prototype.Models;
using System;

namespace _04._Prototype
{
    /// <summary>
    /// Creates new objects by copying this prototype.
    /// </summary>
    class StartUp
    {
        static void Main(string[] args)
        {
            Person personInstance = new Person();
            personInstance.Age = 42;
            personInstance.BirthDate = Convert.ToDateTime("1977-01-01");
            personInstance.Name = "Jack Daniels";
            personInstance.IdInfo = new IdInfo(666);

            // Perform a shallow copy personInstance personInstance and assign it to shallowCopyPerson.
            Person shallowCopyPerson = personInstance.ShallowCopy();
            // Make a deep copy of personInstance and assign it to deepCopyPerson.
            Person deepCopyPerson = personInstance.DeepCopy();

            // Display values of personInstance, shallowCopyPerson and deepCopyPerson.
            Console.WriteLine("Original values of personInstance, shallowCopyPerson, deepCopyPerson:");
            Console.WriteLine("   personInstance instance values: ");
            DisplayValues(personInstance);
            Console.WriteLine("   shallowCopyPerson instance values:");
            DisplayValues(shallowCopyPerson);
            Console.WriteLine("   deepCopyPerson instance values:");
            DisplayValues(deepCopyPerson);

            // Change the value of personInstance properties and display the values of personInstance,
            // shallowCopyPerson and deepCopyPerson.
            personInstance.Age = 32;
            personInstance.BirthDate = Convert.ToDateTime("1900-01-01");
            personInstance.Name = "Frank";
            personInstance.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of personInstance, shallowCopyPerson and deepCopyPerson after changes to personInstance:");
            Console.WriteLine("   personInstance instance values: ");
            DisplayValues(personInstance);
            Console.WriteLine("   shallowCopyPerson instance values (value types stay the same, but reference types have changed):");
            DisplayValues(shallowCopyPerson);
            Console.WriteLine("   deepCopyPerson instance values (everything was kept the same):");
            DisplayValues(deepCopyPerson);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}