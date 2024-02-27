using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class InMemoryCourseDal : ICourseDal
{
    List<Course> _courses;
    public InMemoryCourseDal()
    {
        _courses = new List<Course>()
        {
            new Course {CourseId = 1,CategoryId = 1,InstructorId = 1,CourseName="c# kursu",CourseDescription="c# öğreniyoruz"},
            new Course {CourseId = 2,CategoryId = 1,InstructorId = 1,CourseName="python kursu",CourseDescription="python öğreniyoruz"},
            new Course {CourseId = 3,CategoryId = 2,InstructorId = 1,CourseName="photoshop kursu",CourseDescription="photoshop öğreniyoruz"},
            new Course {CourseId = 4,CategoryId = 2,InstructorId = 2,CourseName="After effects kursu",CourseDescription="After effects öğreniyoruz"},
            new Course {CourseId = 5,CategoryId = 2,InstructorId = 2,CourseName="premiere pro kursu",CourseDescription="premiere pro öğreniyoruz"},
        };
    }
    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public List<Course> GetAll()
    {
        
        return _courses;
    }

    public List<Course> GetAllByCategory(int categoryId)
    {
        return _courses.Where(course => course.CategoryId == categoryId).ToList();
    }

    public List<Course> GetAllByInstructor(int InstructorId)
    {
        return _courses.Where(course => course.InstructorId == InstructorId).ToList();
    }

    public Course GetById(int id)
    {
        return _courses.Where(course => course.CourseId == id).ToList()[0];
    }

    public void Update(Course course)
    {
        foreach (Course coursefor in _courses)
        {
            if (course.CourseId == coursefor.CourseId) {
                coursefor.CategoryId = course.CategoryId;
                coursefor.InstructorId = course.InstructorId;
                coursefor.CourseName = course.CourseName;
                coursefor.CourseDescription = course.CourseDescription;
                return;

            }

        }
    }
}
