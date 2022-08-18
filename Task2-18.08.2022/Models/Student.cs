using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_18._08._2022.Models
{
    class Student
    {
        private int _age;
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public int Age 
        {
            get 
            {
                return _age;
            }
            set 
            {
                if (value > 0) _age = value;
            } 
        }
        public Student(string fullName, string groupNo, int age)
        {
            FullName = fullName;
            GroupNo = groupNo;
            Age = age;

        }
        public static bool CheckFullName(string fullName)
        {
            int cnt = 0;
            for(int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == ' ') cnt++;
            }
            if (cnt != 1) return false;
            string[] a = fullName.Split(' ');
            for (int i = 1; i < a[0].Length; i++)
            {
                if (char.IsUpper(a[0][i])) cnt++;
            }
            for (int i = 1; i < a[1].Length; i++)
            {
                if (char.IsUpper(a[1][i])) cnt++;
            }
            if (char.IsUpper(a[0][0]) && char.IsUpper(a[1][0]) && cnt == 1) return true;
            return false;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            for(int i = 1; i < groupNo.Length; i++)
            {
                if (char.IsDigit(groupNo[i])) continue;
                return false;
            }
            if (char.IsUpper(groupNo[0]) && groupNo.Substring(1).Length == 3) return true;
            return false;
        }

        public void GetInfo()
        {
            Console.WriteLine($"FullName: {FullName}\nGroupNo: {GroupNo}\nAge: {Age}");
        }

        
    }
}
