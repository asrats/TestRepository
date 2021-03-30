using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _cnt;

        public CourseRepository(UniversityDBContext cnt)
        {
            _cnt = cnt;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _cnt.Courses;
        }
    }
}
