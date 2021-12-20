using System;
using System.Collections.Generic;

namespace _12_Switch
{
    public class Grades
    {
        public List<double> arrayDoublesGrades = new List<double>{};

        public void AddGrade(double grade)
        {
                this.arrayDoublesGrades.Add(grade);
        }
        public void AddGrade(string stringGrade)
        {
            if (stringGrade == "1" || stringGrade == "1+" || stringGrade == "2-" ||
            stringGrade == "2" || stringGrade == "2+" || stringGrade == "3-" ||
            stringGrade == "3" || stringGrade == "3+" || stringGrade == "4-" ||
            stringGrade == "4" || stringGrade == "4+" || stringGrade == "5-" ||
            stringGrade == "5" || stringGrade == "5+" || stringGrade == "6-" ||
            stringGrade == "6")
            {
                switch(stringGrade)
                {
                    case "1":
                        this.AddGrade(1.0);
                        break;
                    case "1+":
                        this.AddGrade(1.5);
                        break;
                    case "2-":
                        this.AddGrade(1.75);
                        break;
                    case "2":
                        this.AddGrade(2.0);
                        break;
                    case "2+":
                        this.AddGrade(2.5);
                        break;
                    case "3-":
                        this.AddGrade(2.75);
                        break;
                    case "3":
                        this.AddGrade(3.0);
                        break;
                    case "3+":
                        this.AddGrade(3.5);
                        break;
                    case "4-":
                        this.AddGrade(3.75);
                        break;
                    case "4":
                        this.AddGrade(4.0);
                        break;
                    case "4+":
                        this.AddGrade(4.5);
                        break;
                    case "5-":
                        this.AddGrade(4.75);
                        break;
                    case "5":
                        this.AddGrade(5.0);
                        break;
                    case "5+":
                        this.AddGrade(5.5);
                        break;
                    case "6-":
                        this.AddGrade(5.75);
                        break;
                    case "6":
                        this.AddGrade(6.0);
                        break;
                    default:
                        break;
                }
            }  
            else
            {
                throw new ArgumentException($"Invalid value");
            }  
        }

        public void ShowGrades()
        {
            foreach(var g in arrayDoublesGrades)
            {
                Console.WriteLine(g);
            }

            double sum = 0;
            int count = arrayDoublesGrades.Count;
            foreach(var g in arrayDoublesGrades)
            {
                sum += g;
            }

            Console.WriteLine($"Average grade is {sum/count}");

            /*
            double [] elementsOfTheList = arrayDoublesGrades.ToArray();
            elementsOfTheList.
            */
        }
    }
}