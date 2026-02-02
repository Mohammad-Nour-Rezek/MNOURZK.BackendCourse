using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics
{
    internal class StudentList
    {
        int size;
        Student[] students;
        
        public Student this[int index]
        {
            get 
            {
                if (index < students.Length)
                    return students[index];
                else
                    return null;
            }
            set {
                if (index < size)
                {
                    students[index] = value;
                }
            }
        }

        public Student this[string index]
        {
            get { 
                if (index == "first") 
                {
                    return students[0];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index == "first")
                {
                    students[0] = value;
                }
            }
        }

        public string ListName { get; set; }

        public StudentList(int _size = 10)
        {
            size = _size;
            students = new Student[_size];
        }
    }
}
