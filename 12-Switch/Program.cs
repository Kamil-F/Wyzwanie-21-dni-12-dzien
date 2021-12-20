using System;

namespace _12_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lekcja 12 - Switch'e i wyjatki - Zadanie domowe");

            var gradesToJournal = new Grades();

            while(true)
            {
                Console.WriteLine($"Hello! Enter grades (when finish press q): ");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }
                try
                {
                    gradesToJournal.AddGrade(input);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            Console.WriteLine("Added grades: ");
            gradesToJournal.ShowGrades();
        }
    }
}
