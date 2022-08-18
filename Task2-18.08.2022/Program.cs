using System;
using Task2_18._08._2022.Models;

namespace Task2_18._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            do
            {
                Console.Write("Enter the Full Name: ");
                fullName = Console.ReadLine();

            } while (!Student.CheckFullName(fullName));
            string groupNo;
            do
            {
                Console.Write("Enter the Group Number: ");
                groupNo = Console.ReadLine();

            } while (!Student.CheckGroupNo(groupNo));
            Console.Write("Enter the Age: ");

            int age = Convert.ToInt32(Console.ReadLine());
            
            Student Ibrahim = new Student(fullName, groupNo, age);
            Ibrahim.GetInfo();
        }
    }
}
