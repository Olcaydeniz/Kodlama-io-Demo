using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public int CourseInstructorId { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
