using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {

        private string name;
        private string courseID;
        private string lecturer;
        private int maxstudents;
        private int numstudents;

        public Course()
        {
            name = "John Doe";
            courseID = "12345";
            lecturer = "staff";
            maxstudents = 30;
            numstudents = 0;
        }
        public Course(string name1, string id)
        {
            name = name1;
            this.courseID = id;
            this.lecturer = "staff";
            maxstudents = 30;
            numstudents = 0;
        }
        public Course(String name1, string id, string lecturer1)
        {
            name = name1;
            this.courseID = id;
            this.lecturer = lecturer1;
            maxstudents = 30;
            numstudents = 0;
        }
        public Course(string name1, string id, string lecturer1, int MaxStudents)
        {
            this.name = name1;
            this.courseID = id;
            this.lecturer = lecturer1;
            maxstudents = MaxStudents;
            numstudents = 0;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string CourseID
        {
            get
            {
                return courseID;
            }
            set
            {
                if (value.Length == 6)
                {
                    int x = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            x = x++;

                        }
                    }
                    if (x == 6)
                    {
                        courseID = value;
                    }
                    else
                    {
                        Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                    }
                }
                else
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                }
            }
        }
        public string Lecturer
        {
            get
            {
                return lecturer;
            }
            set
            {
                lecturer = value;
            }
        }
        public int MaxStudents
        {
            get
            {
                return maxstudents;
            }
            set
            {
                if (value > 0 && value <= 80 && value >= numstudents)
                {
                    maxstudents = value;
                }
                else
                {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", courseID);
                }
            }
        }
        public int NumStudents
        {
            get
            {
                return numstudents;
            }
            set
            {
                if (value >= 0 && value <= maxstudents)
                {
                    numstudents = value;
                }
                else
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", courseID);
                }

            }
        }
        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", Name, CourseID, Lecturer, NumStudents, MaxStudents);

        }


    }
}
