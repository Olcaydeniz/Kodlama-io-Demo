using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Delete(Course cours);
        void Update(Course cours);
        List<Course> GetAll();
    }
}
