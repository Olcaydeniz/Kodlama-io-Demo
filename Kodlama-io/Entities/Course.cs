using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CategroyId { get; set; }    
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public double CoursePrice { get; set; }
        public string CourseImage { get; set; }
        public int CourseInstructorId { get; set; }
        public int ProgressBar { get; set; }
    }
}
