using Kodlama_io.DataAccess.Abstracts;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>();
            Course course1 = new Course { CategroyId=1,CourseId = 1,CourseName= "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium", CourseDescription= "Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", CourseInstructorId=1,CoursePrice=0,CourseImage="/URL" };
            Course course2 = new Course { CategroyId = 2, CourseId = 2, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", CourseDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", CourseInstructorId = 2, CoursePrice = 0, CourseImage = "/URL" };
            _courses.Add(course1);
            _courses.Add(course2);
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course cours)
        {
            _courses.Remove(cours);

        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course cours)
        {
            Course existCourse =_courses.Find(x => x.CourseId == cours.CourseId);
            if (existCourse != null)
            {
                return;
                existCourse.CourseName = cours.CourseName;  
                existCourse.CourseDescription = cours.CourseDescription;    
                existCourse.CoursePrice = cours.CoursePrice;    
                existCourse.CourseImage = cours.CourseImage;
                existCourse.CourseInstructorId = cours.CourseInstructorId;  
                existCourse.ProgressBar = cours.ProgressBar;
                existCourse.CategroyId = cours.CategroyId;  
            }
        }
    }
}
