using System;

namespace Lab2
{
    class Student
    {
        public string Name;
        public string StudentID;
        private int year = 0;
        public int YearOfBirth
        {
            get { return year; }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", StudentID);
                }
            }
        }
        public bool isActive;
        public Student()
        {
            this.Name = "John Doe";
            this.StudentID = "Unknown";
            this.YearOfBirth = 1995;
            this.isActive = false;
        }
        public Student(string Name, string StudentID)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = 1995;
            this.isActive = true;
        }
        public Student(string Name, string StudentID, int YearOfBirth)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = YearOfBirth;
            this.isActive = true;
        }
        public Student(string Name, string StudentID, int YearOfBirth, bool isActive)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = YearOfBirth;
            this.isActive = isActive;
        }


        public int getAge()
        {
            return DateTime.Today.Year - YearOfBirth;
        }
        public override string ToString()
        {
            if (isActive == true)
            {
                return "[Studen: " + Name + " (" + StudentID + ")" + ", age=" + getAge() + ", is active student]";
            }
            else
            {
                return "[Studen: " + Name + " (" + StudentID + ")" + ", age=" + getAge() + ", is NOT active student]";
            }
        }
    }
}