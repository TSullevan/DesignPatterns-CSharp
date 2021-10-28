using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memento - Start\n");

            Student student = new Student();

            try
            {
                student.StartAdmissionProcess();
                throw new Exception();
            }
            catch (Exception)
            {
                student.Revert();
            }

            Console.WriteLine($"Student status after failure {student.Status}");
            Console.WriteLine("\nMemento - End");
        }
    }
}
