using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public List<Course> GetAll()
    {
       return _courseDal.GetAll();
    }

    public List<Course> GetAllByCategory(int categoryId)
    {
        return _courseDal.GetAllByCategory(categoryId);
    }

    public List<Course> GetAllByInstructor(int InstructorId)
    {
        return _courseDal.GetAllByInstructor(InstructorId);
    }

    public Course GetById(int id)
    {
        return _courseDal.GetById(id);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
