using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Association
{
    internal class School
    {
        public string Name { get; set; }

        public void OrganizeClasses(Teacher teacher)
        {
            teacher.Teach();
        }
    }
}
