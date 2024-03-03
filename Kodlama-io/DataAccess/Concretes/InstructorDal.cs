using Kodlama_io.DataAccess.Abstracts;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;  
        public InstructorDal()
        {
            _instructors = new List<Instructor>();

            Instructor instructor1 = new Instructor { Id = 1,Name="Engin Demiroğ",Description= "Yazılım geliştirmeye lisede 'yazılım' bölümünde okurken başladım.",Image="URL()" };
            Instructor instructor2 = new Instructor { Id = 2, Name = "Halit Enes Kalaycı", Description = "Yazılım geliştirmeye lisede 'yaızlım' bölümünde okurken başladım.", Image = "URL()" };
            _instructors.Add(instructor1);  
            _instructors.Add(instructor2);  



        }
    
        public void Add(Instructor instructor)
        {
           _instructors.Add(instructor);    
        }

        public void Delete(Instructor instructor)
        {
            _instructors?.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;    
        }

        public void Update(Instructor instructor)
        {
            Instructor existInstructor = _instructors.Find(x => x.Id==instructor.Id);
            if (existInstructor != null)
            {
                return;
                existInstructor.Name = instructor.Name;
                existInstructor.Description = instructor.Description;   
                existInstructor.Image = instructor.Image;    

            }
        }
    }
}
